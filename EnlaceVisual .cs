using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace prims_kruskal
{

    public class EnlaceVisual : Enlace
    {
        public Color Color { get; set; }

        public Point Medio 
        { 
            get
                {
                    return this.GetMedioEnlace();
                } 
        }

        public EnlaceVisual(int peso, Nodo nodoA, Nodo nodoB)
		{
            this.NodoA = nodoA;
            this.NodoB = nodoB;
            this.Peso = peso;
            this.Color = Color.Black;
		}
        private Point GetMedioEnlace()
        {
            Point pNodoA = ((NodoVisual)this.NodoA).Center; // casteo de nodo a nodovisual
            Point pNodoB = ((NodoVisual)this.NodoB).Center; // casteo de nodo a nodovisual
            int x, y = 0;
            if (pNodoA.X == pNodoB.X)
            {
                x = pNodoA.X;
            }
            else
            {
                x = (pNodoA.X + pNodoB.X) / 2;
            }
            

            if (pNodoA.Y == pNodoB.Y)
            {
                y = pNodoA.Y;
            }
            else 
            {
                y = (pNodoA.Y + pNodoB.Y) / 2;
            }
            return new Point(x, y); 
        }
    }
}
