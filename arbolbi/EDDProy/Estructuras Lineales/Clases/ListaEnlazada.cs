using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Estructuras_Lineales.Clases
{
    public class ListaEnlazada<T>
    {
        private Nodo<T> top;
        public ListaEnlazada()
        {
            top = null;
        }

        public void Add(T dato)
        {
            Nodo<T> nuevoNodo = new Nodo<T>(dato);
            if (top == null)
            {
                top = nuevoNodo;
            }
            else
            {
                Nodo<T> aux = top;
                while (aux.sig != null)
                {
                    aux = aux.sig;
                }
                aux.sig = nuevoNodo;
            }
        }
        public void Eliminar(T dato)
        {
            if (top == null) return;

            if (top.Dato.Equals(dato))
            {
                top=top.sig;
                return;
            }
            Nodo<T> aux = top;
            while (aux.sig != null && !aux.sig.Dato.Equals(dato))//verifica que el nodo no sea nulo, && verifica que el 
                //siguiente dato del nodo no sea igual al dato que buscamos elminiar
            {
                aux = aux.sig;
            }
            if (aux.sig != null)
            {
                aux.sig = aux.sig.sig;
            }
        }
        public bool Buscar(T dato)
        {
            Nodo<T> aux = top;
            while (aux != null)
            {
                if (aux.Dato.Equals(dato))
                {
                    return true;
                }
                aux = aux.sig;
            }
            return false;
        }

        public IEnumerable<T> GetItems()
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

