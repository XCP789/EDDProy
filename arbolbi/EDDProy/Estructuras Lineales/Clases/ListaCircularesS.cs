using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Estructuras_Lineales.Clases
{
    public class ListaCircularesS <T>
    {
        private Nodo<T> top;
        
        public ListaCircularesS()
        {
            top=null;
        }
        public void insertar (T dato)
        {
            Nodo<T> nuevoNodo = new Nodo<T> (dato);
            if (top == null)
            {
                top = nuevoNodo;
                top.sig = top;
            }
            else
            {
                Nodo<T> aux = top;
                while (aux.sig != top)
                {
                    aux = aux.sig;
                }
                aux.sig = nuevoNodo;
                nuevoNodo.sig = top;
            }
        }
        public void eliminar(int posicion)
        {
            if (top == null) return;

            if (posicion==0) 
            {
                if (top.sig == top)
                {
                    top = null;
                }
                else 
                {
                    Nodo<T> aux = top;
                    while (aux.sig != top)
                    {
                        aux = aux.sig;
                    }
                    aux.sig=top.sig;

                    top = top.sig;
                }
                return;
            }
            Nodo<T> ants=top;
            Nodo<T> temp=top.sig;

            int index = 1;
            while(temp != top && index < posicion)
            {
                ants = temp;
                temp=temp.sig;
                index++;
            }
            if (index == posicion)
            {
                ants.sig= temp.sig;
            }
        }
        public bool buscar(T dato)
        {
            if(top == null) return false;

            Nodo<T> temp= top;
            do
            {
                if (temp.Dato.Equals(dato)) return true;
                temp = temp.sig;
            } while (temp != top);
            return false;
        }

        public void vaciar()
        {
            top = null;
        }

        public IEnumerable<T> GetItems()
        {
            if(top==null) yield break;
            Nodo<T> temp = top;

            do
            {
                yield return temp.Dato;
                temp = temp.sig;
            }while (temp != top);
        }
    }
}
