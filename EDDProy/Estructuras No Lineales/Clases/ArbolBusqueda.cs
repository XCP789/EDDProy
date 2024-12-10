using EDDemo.Estructuras_No_Lineales;
using EDDemo.Estructuras_Lineales.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_No_Lineales
{
    public class ArbolBusqueda
    {
        NodoBinario Raiz;
        public String strArbol;
        public String strRecorrido;

        public ArbolBusqueda()
        {
            Raiz = null;
            strArbol = "";
            strRecorrido = "";
        }

        public Boolean EstaVacio()
        {
            if (Raiz == null)
                return true;
            else
                return false;
        }
        public NodoBinario RegresaRaiz()
        {
            return Raiz;
        }

        public void InsertaNodo(int Dato, ref NodoBinario Nodo)
        {
            if (Nodo == null)
            {
                Nodo = new NodoBinario(Dato);

                if (Raiz == null)
                    Raiz = Nodo;
            }
            else if(Dato == Nodo.Dato)
            {
                MessageBox.Show($"el valor {Dato} ya existe en el arbol");
            }
            else if (Dato < Nodo.Dato)
                InsertaNodo(Dato, ref Nodo.Izq);
            else if (Dato > Nodo.Dato)
                InsertaNodo(Dato, ref Nodo.Der);
        }
        public void Muestra(int nivel, NodoBinario nodo)
        {
            if (nodo == null)
                return;
            Muestra(nivel + 1, nodo.Der);
            for (int i = 0; i < nivel; i++)
            {
                strArbol = strArbol + "     ";
            }
            strArbol = strArbol + nodo.Dato.ToString() + "\r\n";
            Muestra(nivel + 1, nodo.Izq);
        }
        public String toDot(NodoBinario nodo)
        {
            StringBuilder b = new StringBuilder();
            if (nodo.Izq != null)
            {
                b.AppendFormat("{0}->{1} [side=L] {2}", nodo.Dato.ToString(), nodo.Izq.Dato.ToString(), Environment.NewLine);
                b.Append(toDot(nodo.Izq));
            }

            if (nodo.Der != null)
            {
                b.AppendFormat("{0}->{1} [side=R] {2}", nodo.Dato.ToString(), nodo.Der.Dato.ToString(), Environment.NewLine);
                b.Append(toDot(nodo.Der));
            }

            return b.ToString();
        }
        //preorden
        public void PreOrden(NodoBinario nodo)
        {
            if (nodo == null) return;

            strRecorrido = strRecorrido + nodo.Dato + ", ";
            PreOrden(nodo.Izq);
            PreOrden(nodo.Der);

            return;
        }

        public void InOrden(NodoBinario nodo)
        {
            if (nodo == null) return;

            InOrden(nodo.Izq);
            strRecorrido = strRecorrido + nodo.Dato + ", ";
            InOrden(nodo.Der);

            return;
        }

        public void PostOrden(NodoBinario nodo)
        {
            if (nodo == null) return;

            PostOrden(nodo.Izq);
            PostOrden(nodo.Der);
            strRecorrido = strRecorrido + nodo.Dato + ", ";

            return;
        }

        public bool busqueda(int valor)
        {
            return busqueda(Raiz, valor);
        }

        private bool busqueda(NodoBinario nodo, int valor)
        {
            if(nodo == null) return false;

            if (nodo.Dato == valor)
            {
                return true;
            }

            else if (valor < nodo.Dato)
            {
                return busqueda(nodo.Izq, valor);
            }
            else
            {
                return busqueda(nodo.Der, valor);
            }
        }

        public void MostrarBuqueda(int valor)
        {
            bool encontrado = busqueda(valor);
            if (encontrado)
            {
                MessageBox.Show($"El {valor} SI se encuentra en el arbol");
            }
            else
            {
                MessageBox.Show($"El {valor} NO se encuentra en el arbol");
            }
        }
        public void podarArbol(ref NodoBinario nodo)
        {
            if(nodo == null) 
                return;
            podarArbol(ref nodo.Izq);
            podarArbol(ref nodo.Der);
            nodo = null;
        }

        private NodoBinario BuscarPredecesor(NodoBinario nodo)
        {
            NodoBinario aux = nodo.Izq;
            while (aux != null && aux.Der != null)
            {
                aux = aux.Der;
            }
            return aux;
        }
        public NodoBinario EliminarPredecesor(NodoBinario raiz, int dato)
        {
            if(raiz == null)
                return raiz;
            if (dato<raiz.Dato)
            {
                raiz.Izq=EliminarPredecesor(raiz.Der, dato);
            }
            else if (dato>raiz.Dato)
            {
                raiz.Der=EliminarPredecesor(raiz.Izq, dato);
            }
            else
            {
                if (raiz.Izq == null)
                    return raiz.Der;
                else if (raiz.Der == null)
                    return raiz.Izq;
                NodoBinario predecesor = BuscarPredecesor(raiz);
                raiz.Dato = predecesor.Dato;
                raiz.Izq= EliminarPredecesor(raiz.Izq, predecesor.Dato);
            }
            return raiz;
        }

        private NodoBinario BuscarSucesor(NodoBinario nodo)
        {
            NodoBinario aux = nodo.Der;
            while (aux != null && aux.Der != null)
            {
                aux = aux.Der;
            }
            return aux;
        }
        public NodoBinario EliminarSucesor(NodoBinario raiz, int dato)
        {
            if(raiz== null)
                return raiz;
            if (dato < raiz.Dato)
            {
                raiz.Izq = EliminarSucesor(raiz.Izq, dato);
            }
            else if (dato>raiz.Dato)
            {
                raiz.Der=EliminarSucesor(raiz.Der, dato);
            }
            else
            {
                if(raiz.Izq ==null)
                    return raiz.Der;
                else if (raiz.Der == null)
                    return raiz.Izq;
                NodoBinario sucesor = BuscarSucesor(raiz);
                raiz.Dato = sucesor.Dato;
                raiz.Der = EliminarSucesor(raiz.Der, sucesor.Dato);
            }
            return raiz;
        }

        public void RecorrerAmplitud(NodoBinario nodo)
        {
            if(nodo==null)
                return;
            Cola<NodoBinario> cola = new Cola<NodoBinario>();
            cola.encolar(nodo);

            while(!cola.vacio())
            {
                NodoBinario nodoAux = cola.desencolar();
                strRecorrido += nodoAux.Dato + ", ";

                if (nodoAux.Izq!=null)
                    cola.encolar(nodoAux.Izq);
                if (nodoAux.Der!=null)
                    cola.encolar(nodoAux.Der);
            }
        }

        public int Altura(NodoBinario nodo)
        {
            if(nodo==null)
            {
                return -1;
            }
            else
            {
                int alturaIzq=Altura(nodo.Izq);
                int alturaDer=Altura(nodo.Der);

                if(alturaIzq>alturaDer)
                {
                    return alturaIzq + 1;
                }
                else
                {
                    return alturaDer + 1;
                }
            }
        }
        public int contarHojas(NodoBinario nodo)
        {
            if (nodo == null)
            {
                return 0;
            }
            if (nodo.Izq==null && nodo.Der==null)
            {
                return 1;
            }
            else
            {
                return contarHojas(nodo.Izq) + contarHojas(nodo.Der);
            }
        }
        public int contarNodos(NodoBinario nodo)
        {
            if (nodo == null)
            {
                return 0;
            }
            else
            {
                return 1 + contarNodos(nodo.Izq)+contarNodos(nodo.Der);
            }
        }
        public bool AblCompleto(NodoBinario nodo)
        {
            if (nodo == null)
                return true;
            Cola<NodoBinario> cola = new Cola<NodoBinario>();
            cola.encolar(nodo);

            bool encontrarHijo=false;
            while (!cola.vacio())
            {
                NodoBinario nodoAux = cola.desencolar();
                if (nodoAux.Izq != null)
                { 
                    if(encontrarHijo)
                    return false;
                    cola.encolar(nodoAux.Izq);
                }
                else
                {
                    encontrarHijo = true;
                }

                if (nodoAux.Der != null)
                {
                    if (encontrarHijo)
                        return false;
                    cola.encolar(nodoAux.Der);
                }
                else
                {
                    encontrarHijo = true;
                }
            }
            return true;
        }

        public bool ArbolLleno(NodoBinario nodo)
        {
            if (nodo==null) return true;

            if(nodo.Izq == null && nodo.Der == null) return true;

            if(nodo.Izq !=null && nodo.Der != null)
                return ArbolLleno(nodo.Izq) && ArbolLleno(nodo.Der); 

            return false;
        }

    }

}
