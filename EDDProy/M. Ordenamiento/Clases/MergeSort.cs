using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.M._Ordenamiento.Clases
{
    public class MergeSort
    {
        public void Ordenar(int[] arreglo)
        {
            if (arreglo.Length <= 1) return;
            int[] aux = new int[arreglo.Length];
            Ordenar(arreglo, aux, 0, arreglo.Length - 1);
        }
        private void Ordenar(int[] arreglo, int[] aux, int bajo, int alto)
        {
            if (bajo < alto)
            {
                int medio = (bajo + alto) / 2;
                Ordenar(arreglo, aux, bajo, medio);
                Ordenar(arreglo, aux, medio + 1, alto);
                Mezclar(arreglo, aux, bajo, medio, alto);
            }
        }
        private void Mezclar(int[] arreglo, int[] aux, int bajo, int medio, int alto)
        {
            for (int k = bajo; k <= alto; k++)
            {
                aux[k] = arreglo[k];
            }
            int i = bajo, j = medio + 1;
            for (int k = bajo; k <= alto; k++)
            {
                if (i > medio)
                {
                    arreglo[k] = aux[j++];
                }
                else if (j > alto)
                {
                    arreglo[k] = aux[i++];
                }
                else if (aux[j] < aux[i])
                {
                    arreglo[k] = aux[j++];
                }
                else
                {
                    arreglo[k] = aux[i++];
                }
            }
        }
    }
}
