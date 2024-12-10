using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Estructuras_Lineales.Clases
{
    public class Nodo<T>
    {
        public T Dato {  get; set; }
        public Nodo<T> sig { get; set; }
        public Nodo<T> ants { get; set; }

        public Nodo(T dato)
        {
            Dato = dato;
            sig=null;
            ants = null;
        }
    }
}
