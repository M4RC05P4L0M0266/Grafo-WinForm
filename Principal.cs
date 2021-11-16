
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prims_kruskal
{
    public partial class Principal : Form
    {
        public static Form K;
        private NodoVisual seleccionado;
        private List<Nodo> nodos;
        private List<Enlace> enlaces;
        private Grafo g = new Grafo();
        private List<Enlace> resolucion;
        private int indiceResolucion; 

        SolidBrush pincelNegro = new SolidBrush(Color.Black);
        SolidBrush pincelVerde = new SolidBrush(Color.Green);
        Font letra = new Font("Arial", 9);
        

        public Principal() // constructor
        {
            InitializeComponent();
            this.nodos = new List<Nodo>(); // lista de nodos
            this.enlaces = new List<Enlace>();
            this.resolucion = new List<Enlace>();
            this.indiceResolucion = 0;
            K = this;
            this.seleccionado = null; //inicializa seleccionado en null 
            ///////////////////
        }
        private void btnDibujarNodo_Click(object sender, EventArgs e) // Funcion: recibe los valores para dibijar el nodo, crea un nuevo punto y un nuevo nodo y llama a la funcion para dibujar
        {
            if (this.textBox3.Text != "" && this.textBox4.Text != "")
            {
                NodoVisual n = new NodoVisual();
                int x, y = 0;
                x = int.Parse(this.textBox3.Text);
                y = int.Parse(this.textBox4.Text);
                Point p = new Point(x, y);
                n.Center = p;
                n.nombre = this.textBox1.Text;
                bool selectNodo = true;
                if (this.nodos.Count > 0)
                {
                    foreach (var Nodo in nodos)
                    {
                        if (n.nombre == Nodo.nombre)
                        {
                            MessageBox.Show("No se puede repetir el nombre de un Nodo", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            selectNodo = false;
                        }
                    }
                }
                if (selectNodo)
                {
                    this.nodos.Add(n);
                    this.g.AgregarNodo((Nodo)n);
                    this.Dibujar();
                    this.textBox1.Text = string.Empty;
                    this.textBox3.Text = string.Empty;
                    this.textBox4.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("Debe completar los campor X, Y!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }
        private void btnDibujarEnlace_Click(object sender, EventArgs e) //Evento: Dibujo; Captura los elementos seleccionados en el dropdown y luego los busca por el nombre en la lista de nodos, luego se los manda a la funcion de dibujar la linea
        {
            var desde = this.Desde.Items[this.Desde.SelectedIndex]; //elem seleccionado desde
            var hasta = this.Hasta.Items[this.Hasta.SelectedIndex]; //elem seleccionado hasta
            var nodo_desde= this.nodos.FirstOrDefault(d => d.nombre == desde); //busca en la lista de nodos donde el nombre sea el mismo
            var nodo_hasta = this.nodos.FirstOrDefault(h => h.nombre == hasta); //busca en la lista de nodos donde el nombre sea el mismo
            var peso = int.Parse(this.textBox6.Text);
            this.DibujarEnlace(peso, (NodoVisual)nodo_desde, (NodoVisual)nodo_hasta);
            this.Desde.ResetText();
            this.Hasta.ResetText();
            this.textBox6.Text = string.Empty;

            
        }
        private void Dibujar() // Funcion: Dibujo; Dibuja los nodos con sus respectivos nombres, a su ves carga los nombres los dropdowns.
        {
            Pen pen = new Pen(pincelNegro, 3); 
            Desde.Items.Clear();
            Hasta.Items.Clear();
            Graphics s = prims_kruskal.Principal.K.CreateGraphics();
            s.Clear(System.Drawing.SystemColors.ActiveCaption);
            foreach (NodoVisual nodo in this.nodos)
            {
                Desde.Items.Add(nodo.nombre);
                Hasta.Items.Add(nodo.nombre);
                s.FillEllipse(pincelNegro, nodo.Center.X, nodo.Center.Y, 30, 30);
                s.DrawString(nodo.nombre, letra, pincelNegro, nodo.Center.X + 7, nodo.Center.Y + 30);
            }

            foreach (var enlace in this.enlaces)
            {
                Point nodoA = new Point(((NodoVisual)enlace.NodoA).Center.X + 15, ((NodoVisual)enlace.NodoA).Center.Y + 15);
                Point nodoB = new Point(((NodoVisual)enlace.NodoB).Center.X + 15, ((NodoVisual)enlace.NodoB).Center.Y + 15);
                s.DrawLine(new Pen(((EnlaceVisual)enlace).Color, 3), nodoA, nodoB);
                s.FillEllipse(pincelVerde, ((EnlaceVisual)enlace).Medio.X, ((EnlaceVisual)enlace).Medio.Y, 15, 15);
                s.DrawString(enlace.Peso.ToString(), letra, pincelVerde, ((EnlaceVisual)enlace).Medio.X + 3, ((EnlaceVisual)enlace).Medio.Y + 15);
            }
            
        }
        private void DibujarEnlace(int peso, NodoVisual desde, NodoVisual hasta) // Funcion : Dibujo; Se encarga de trazar una linea entre dos nodos
        {
            Graphics g = prims_kruskal.Principal.K.CreateGraphics();
            Point d = new Point(desde.Center.X + 15, desde.Center.Y + 15);
            Point h = new Point(hasta.Center.X + 15, hasta.Center.Y + 15);
            EnlaceVisual e = new EnlaceVisual(peso, desde, hasta);
            Pen pen = new Pen(pincelNegro, 3); 
            bool selectEnlace = true;
            if (this.enlaces.Count > 0)
            {
                foreach (var Enlace in enlaces)
                {
                    if (e.NodoA == Enlace.NodoA && e.NodoB == Enlace.NodoB || e.NodoB == Enlace.NodoA && e.NodoA == Enlace.NodoB)
                    {
                        MessageBox.Show("No se puede repetir un enlace ya creado", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        selectEnlace = false;
                    }
                }
            }
            if (e.NodoA == e.NodoB)
            {
                MessageBox.Show("No se puede crear un enlace a si mismo", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                selectEnlace = false;
            }
            if (selectEnlace)
            {
                enlaces.Add(e);
                g.DrawLine(new Pen(e.Color, 3), d, h);
                g.FillEllipse(pincelVerde, e.Medio.X, e.Medio.Y, 15, 15);
                g.DrawString(e.Peso.ToString(), letra, pincelVerde, e.Medio.X + 3, e.Medio.Y + 15);
                this.g.AgregarEnlace(e);
            }
        }
      
        private void Form1_MouseDown(object sender, MouseEventArgs e) //evento: movimiento; genera un cuadrado alrededor del circulo que al tocarlo simula la seleccion del nodo
        {
            foreach (NodoVisual n in this.nodos)
            {
                if ((n.Center.X <= e.X) && (n.Center.X + 30 >= e.X) && (n.Center.Y <= e.Y) && (n.Center.Y + 30 >= e.Y))
                {
                    this.seleccionado = n;
                   
                }
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e) //evento: movimiento; controla el movimiento del nodo, va actualizando el x e y del nodo y redibujandolo a medida que se mueve
        {

            if (this.seleccionado != null) 
            {
                this.seleccionado.Center.X = e.X;
                this.seleccionado.Center.Y = e.Y;
                Graphics s = prims_kruskal.Principal.K.CreateGraphics();
                s.Clear(this.BackColor);
                this.Dibujar();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)// evento: movimiento; suelta el nodo cuando soltas el click del mouse
        {
            this.seleccionado = null;
        }

        

        private void btnKruskal_Click(object sender, EventArgs e)
        {
            this.ResetResolucion();
            this.resolucion = Kruskal.Ejecutar(g);
            this.Dibujar();
            this.ImprimirResultado();
        }
        private void ImprimirResultado()
        {
            string resultado = "Lista de Enlaces: " + Environment.NewLine;
            int pesoTotal = 0;
            foreach (var enlace in this.resolucion)
            {
                resultado += "[" + enlace.NodoA.nombre + "-" + enlace.NodoB.nombre + "]" + Environment.NewLine;
                pesoTotal += enlace.Peso;
            }
            this.lblResultado.Text = resultado + "Costo Total: "+ pesoTotal; 
        }

       
        private void ResetResolucion() {
            this.resolucion = new List<Enlace>();
            this.indiceResolucion = 0;
            this.lblResultado.Text = string.Empty;

            foreach (EnlaceVisual enlace in this.enlaces)
            {
                enlace.Color = Color.Black;
            }
        }

        private void Reset()
        {
            this.g = new Grafo();
            this.nodos = new List<Nodo>();
            this.enlaces = new List<Enlace>();
            this.resolucion = new List<Enlace>();
            this.indiceResolucion = 0;
            this.lblResultado.Text = string.Empty;
            this.Dibujar();
        }

        private void btnGrafo3_Click(object sender, EventArgs e)  // crea grafo de 3 nodos
        {
            this.Reset();
            var n1 = new NodoVisual();
            n1.Center = new Point(13, 13);
            n1.nombre = "N1";
            var n2 = new NodoVisual();
            n2.Center = new Point(300, 200);
            n2.nombre = "N2";
            var n3 = new NodoVisual();
            n3.Center = new Point(450, 13);
            n3.nombre = "N3";

            g.AgregarNodo(n1);
            g.AgregarNodo(n2);
            g.AgregarNodo(n3);

            this.nodos.Add(n1);
            this.nodos.Add(n2);
            this.nodos.Add(n3);

            var e1 = new EnlaceVisual(2, n1, n2);
            var e2 = new EnlaceVisual(7, n2, n3);
            var e3 = new EnlaceVisual(3, n1, n3);

            g.AgregarEnlace(e1);
            g.AgregarEnlace(e2);
            g.AgregarEnlace(e3);

            this.enlaces.Add(e1);
            this.enlaces.Add(e2);
            this.enlaces.Add(e3);

            this.Dibujar();
        }

        private void btnGrafo6_Click(object sender, EventArgs e)
        {
            this.Reset();

            var n1 = new NodoVisual();
            n1.Center = new Point(13, 13);
            n1.nombre = "N1";
            var n2 = new NodoVisual();
            n2.Center = new Point(300, 200);
            n2.nombre = "N2";
            var n3 = new NodoVisual();
            n3.Center = new Point(450, 13);
            n3.nombre = "N3";
            var n4 = new NodoVisual();
            n4.Center = new Point(450, 350);
            n4.nombre = "N4";
            var n5 = new NodoVisual();
            n5.Center = new Point(13, 350);
            n5.nombre = "N5";
            var n6 = new NodoVisual();
            n6.Center = new Point(200, 200);
            n6.nombre = "N6";

            g.AgregarNodo(n1);
            g.AgregarNodo(n2);
            g.AgregarNodo(n3);
            g.AgregarNodo(n4);
            g.AgregarNodo(n5);
            g.AgregarNodo(n6);

            this.nodos.Add(n1);
            this.nodos.Add(n2);
            this.nodos.Add(n3);
            this.nodos.Add(n4);
            this.nodos.Add(n5);
            this.nodos.Add(n6);

            var e1 = new EnlaceVisual(2, n1, n2);
            var e2 = new EnlaceVisual(7, n2, n3);
            var e3 = new EnlaceVisual(3, n1, n3);
            var e4 = new EnlaceVisual(20, n1, n6);
            var e5 = new EnlaceVisual(5, n3, n6);
            var e6 = new EnlaceVisual(9, n1, n5);
            var e7 = new EnlaceVisual(3, n5, n4);

            g.AgregarEnlace(e1);
            g.AgregarEnlace(e2);
            g.AgregarEnlace(e3);
            g.AgregarEnlace(e4);
            g.AgregarEnlace(e5);
            g.AgregarEnlace(e6);
            g.AgregarEnlace(e7);

            this.enlaces.Add(e1);
            this.enlaces.Add(e2);
            this.enlaces.Add(e3);
            this.enlaces.Add(e4);
            this.enlaces.Add(e5);
            this.enlaces.Add(e6);
            this.enlaces.Add(e7);

            this.Dibujar();
        }

        private void btnGrafo12_Click(object sender, EventArgs e)
        {
            this.Reset();

            var n1 = new NodoVisual();
            n1.Center = new Point(13, 13);
            n1.nombre = "N1";
            var n2 = new NodoVisual();
            n2.Center = new Point(300, 200);
            n2.nombre = "N2";
            var n3 = new NodoVisual();
            n3.Center = new Point(450, 13);
            n3.nombre = "N3";
            var n4 = new NodoVisual();
            n4.Center = new Point(450, 350);
            n4.nombre = "N4";
            var n5 = new NodoVisual();
            n5.Center = new Point(13, 350);
            n5.nombre = "N5";
            var n6 = new NodoVisual();
            n6.Center = new Point(200, 200);
            n6.nombre = "N6";
            var n7 = new NodoVisual();
            n7.Center = new Point(570, 405);
            n7.nombre = "N7";
            var n8 = new NodoVisual();
            n8.Center = new Point(570, 280);
            n8.nombre = "N8";
            var n9 = new NodoVisual();
            n9.Center = new Point(400, 150);
            n9.nombre = "N9";
            var n10 = new NodoVisual();
            n10.Center = new Point(500, 200);
            n10.nombre = "N10";
            var n11 = new NodoVisual();
            n11.Center = new Point(50, 405);
            n11.nombre = "N11";
            var n12 = new NodoVisual();
            n12.Center = new Point(200, 405);
            n12.nombre = "N12";


            g.AgregarNodo(n1);
            g.AgregarNodo(n2);
            g.AgregarNodo(n3);
            g.AgregarNodo(n4);
            g.AgregarNodo(n5);
            g.AgregarNodo(n6);
            g.AgregarNodo(n7);
            g.AgregarNodo(n8);
            g.AgregarNodo(n9);
            g.AgregarNodo(n10);
            g.AgregarNodo(n11);
            g.AgregarNodo(n12);

            this.nodos.Add(n1);
            this.nodos.Add(n2);
            this.nodos.Add(n3);
            this.nodos.Add(n4);
            this.nodos.Add(n5);
            this.nodos.Add(n6);
            this.nodos.Add(n7);
            this.nodos.Add(n8);
            this.nodos.Add(n9);
            this.nodos.Add(n10);
            this.nodos.Add(n11);
            this.nodos.Add(n12);

            var e1 = new EnlaceVisual(2, n1, n2);
            var e2 = new EnlaceVisual(7, n2, n3);
            var e3 = new EnlaceVisual(3, n1, n3);
            var e4 = new EnlaceVisual(20, n1, n6);
            var e5 = new EnlaceVisual(5, n3, n6);
            var e6 = new EnlaceVisual(9, n1, n5);
            var e7 = new EnlaceVisual(3, n5, n4);
            var e8 = new EnlaceVisual(22, n4, n7);
            var e9 = new EnlaceVisual(8, n7, n8);
            var e10 = new EnlaceVisual(1, n9, n10);
            var e11 = new EnlaceVisual(10, n10, n11);
            var e12 = new EnlaceVisual(52, n11, n12);
            var e13 = new EnlaceVisual(19, n12, n7);

            g.AgregarEnlace(e1);
            g.AgregarEnlace(e2);
            g.AgregarEnlace(e3);
            g.AgregarEnlace(e4);
            g.AgregarEnlace(e5);
            g.AgregarEnlace(e6);
            g.AgregarEnlace(e7);
            g.AgregarEnlace(e8);
            g.AgregarEnlace(e9);
            g.AgregarEnlace(e10);
            g.AgregarEnlace(e11);
            g.AgregarEnlace(e12);
            g.AgregarEnlace(e13);

            this.enlaces.Add(e1);
            this.enlaces.Add(e2);
            this.enlaces.Add(e3);
            this.enlaces.Add(e4);
            this.enlaces.Add(e5);
            this.enlaces.Add(e6);
            this.enlaces.Add(e7);
            this.enlaces.Add(e8);
            this.enlaces.Add(e9);
            this.enlaces.Add(e10);
            this.enlaces.Add(e11);
            this.enlaces.Add(e12);
            this.enlaces.Add(e13);

            this.Dibujar();
        }


    }
}
