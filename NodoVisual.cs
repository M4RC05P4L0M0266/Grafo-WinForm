using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace prims_kruskal
{
    public class NodoVisual : Nodo
    {
        
        public Point Center;
        
        public ArrayList ar = new ArrayList();

        private Font font = new Font("Arial", 9);
        private SolidBrush brush = new SolidBrush(Color.Black);

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Principal());
        }

		public void DibujarNodo()
		{
            Graphics s = prims_kruskal.Principal.K.CreateGraphics();
			s.FillEllipse(brush,Center.X,Center.Y,30,30);
			s.DrawString(nombre,font,brush,Center.X,Center.Y+30);
		} 

    }
}
