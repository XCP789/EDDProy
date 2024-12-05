    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Estructuras_Lineales.Clases
{
    public class Pila<T>
    {
        private Nodo<T> top;
        public Pila()
        {
            top=null;
        }
        public void insertar(T dato)
        {
            Nodo<T> nuevoNodo = new Nodo<T>(dato);
            nuevoNodo.sig = top;
            top=nuevoNodo;
        }
        public T Eliminar()
        {
            if (top == null)
            {
                return default(T);
            }
            T dato = top.Dato;
            top = top.sig;
            return dato;
        }
        public bool Vacio()
        {
            return top == null;
        }
        public void vaciar()
        {
            top=null ;
        }
        public IEnumerable<T> pilas()
        {
            Nodo<T> aux = top;
            while (aux != null)
            {
                yield return aux.Dato;
                aux = aux.sig;
            }
        }

    }
}
