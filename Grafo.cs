using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prims_kruskal
{
    public class Grafo
    {
        public List<Nodo> Nodos { get; private set; }
        private List<Enlace> Enlaces;

        /// <summary>
        /// Constructor de grafo. Inicializa el grafo
        /// </summary>
        public Grafo()
        {
            this.Nodos = new List<Nodo>();
            this.Enlaces = new List<Enlace>();
        }

        /// <summary>
        /// Si el nodo no existe lo agrego a la lista de nodos
        /// </summary>
        /// <param name="n">Nodo a agregar</param>
        /// <returns>True si el nodo se agrego</returns>
        public bool AgregarNodo(Nodo n)
        {
            if (ExisteNodo(n))
            {
                return false;
            }
            Nodos.Add(n);
            return true;
        }

        /// <summary>
        ///  Si ambos nodos en el enlace existen, agrego el enlace al grafo
        /// </summary>
        /// <param name="e">Enlace a agregar</param>
        /// <returns>True si se agrego</returns>
        public bool AgregarEnlace(Enlace e) //
        {

            if (ExisteNodo(e.NodoA) && ExisteNodo(e.NodoB))
            {
                this.Enlaces.Add(e);
                return true;
            }
            return false;

        }

        /// <summary>
        /// Busca si existe el nodo en el grafo
        /// </summary>
        /// <param name="n">Nodo a buscar</param>
        /// <returns>True si existe</returns>
        private bool ExisteNodo(Nodo n)
        {
            foreach (Nodo aux in Nodos)
            {
                if (n.nombre == aux.nombre)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Elimina el enlace
        /// </summary>
        /// <param name="e">Enlace a eliminar</param>
        /// <returns>True si se elimino</returns>
        public bool BorrarEnlace(Enlace e)
        {
            return this.Enlaces.Remove(e);
        }

        /// <summary>
        /// Devuelve una lista de enlaces que contiene el nodo pasado por parametro, si al menos uno de los nodos del enlace no esta visitado
        /// </summary>
        /// <param name="n1"> Nodo a buscar</param>
        /// <returns>Lista de enlaces</returns>
        public List<Enlace> GetEnlaces(Nodo n1)
        {
            var aux = new List<Enlace>();
            foreach (var e in this.Enlaces)
            {
                if (((e.NodoA.Equals(n1)) || (e.NodoB.Equals(n1))) && (!e.NodoA.visitado || !e.NodoB.visitado))
                {
                    aux.Add(e);
                }
            }

            return aux;
        }

        /// <summary>
        /// Devuelve el primer nodo del grafo y lo marca en visitado
        /// </summary>
        /// <returns>Devuelve Nodo</returns>
        public Nodo GetNodo()
        {
            var n = this.Nodos.FirstOrDefault();
            if (n != null)
                n.visitado = true;

            return n;
        }

        /// <summary>
        /// Verifica si todos los nodos fueron visitados
        /// </summary>
        /// <returns>True si todos fueron visitados</returns>
        public bool TodosVisitados()
        {
            foreach (var nodo in this.Nodos)
            {
                if (!nodo.visitado)
                    return false;
            }
            return true;
        }

        /// <summary>
        /// Devuelve una lista de los enlaces ordenados de menor a mayor
        /// </summary>
        /// <returns>Lista de enlaces</returns>
        public List<Enlace> GetEnlacesDeMenorAMayor()
        {
            Enlaces.Sort(new ComparadorDeEnlaces());
            return Enlaces;
        }

        /// <summary>
        /// Devuelve una lista de enlaces donde ambos nodos estan visitados
        /// </summary>
        /// <param name="n1">Nodo a comparar</param>
        /// <returns>Lista de enlaces visitados</returns>
        public List<Enlace> GetEnlacesVisitados(Nodo n1)
        {
            List<Enlace> resultado = new List<Enlace>();
            foreach (var enlace in this.Enlaces)
            {
                Nodo naux = enlace.GetOtroNodo(n1);
                if (naux != null)
                {
                    if (naux.visitado)
                        resultado.Add(enlace);
                }
            }

            return resultado;
        }
    }
}
