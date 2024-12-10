using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Estructuras_Lineales.Clases
{
        public class NodoCola<T>
        {
            public T Valor;
            public NodoCola<T> sig;

        public NodoCola()
        {
        }

        public NodoCola(T valor)
            {
                Valor = valor;
                sig = null;
            }
        }

        public class Cola<T>
        {
            public NodoCola<T> top;
            public NodoCola<T> cola;

            public Cola()
            {
                top = null;
                cola = null;
            }
            public bool vacio()
            {
                return top == null;
            }
        public void encolar(T valor)
        {
            NodoCola<T> nuevoN = new NodoCola<T>(valor);
            if (cola == null)
            {
                top = nuevoN;
                cola = nuevoN;
            }
            else
            {
                cola.sig = nuevoN;
                cola = nuevoN;
            }
        }
        public T desencolar()
        {
            if (vacio())
            {
                return default(T);
            }
            T valor = top.Valor;
            top=top.sig;
            if (top==null)
            {
                cola= null;
            }
            return valor;
        }
     }
    
}
