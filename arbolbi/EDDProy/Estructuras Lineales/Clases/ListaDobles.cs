using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Estructuras_Lineales.Clases
{
    public class ListaDobles<T>
    {
        private Nodo<T> top;
        private Nodo<T> final;

        public ListaDobles()
        {
            top = null;
            final = null;   
        }
        public void Add(T dato)
        {
            Nodo<T> nuevoNodo = new Nodo<T>(dato);
            if (top == null)
            {
                top = nuevoNodo;
                final = nuevoNodo;
            }
            else
            {
                final.sig=nuevoNodo;
                nuevoNodo.ants = final;
                final=nuevoNodo;
            }
        }
        public void Quitar(T dato)
        {
            Nodo<T> aux = top;
            while (aux != null)
            {
                if (aux.Dato.Equals(dato))
                {
                    if(aux.ants != null)
                    {
                        aux.ants.sig = aux.sig;
                    }
                    else
                    {
                        top=aux.sig;
                    }
                    if (aux.sig != null)
                    {
                        aux.sig.ants = aux.ants;
                    }
                    else
                    {
                        final=aux.sig;
                    }
                    break;
                }
                aux=aux.sig ;
            }
        }

        public bool Buscar(T dato)
        {
            Nodo<T> aux = top;
            while(aux != null)
            {
                if(aux.Dato.Equals(dato))
                {
                    return true;
                }
                aux=aux.sig ;
            }
            return false;
        }
        public IEnumerable<T> GetItems()
        {
            Nodo<T> aux=top;
            while (aux != null)
            {
                yield return aux.Dato;
                aux=aux.sig ;
            }
        }
    }
}
