using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.M._Ordenamiento.Clases
{
    public class MergeDirecta
    {
        private void unir(int[] arreglo, int[] temp, int izq, int mid, int der)
        {
            int izqIndex = izq;
            int derIndex = mid +1;
            int tempIndex = izq;

            while (izqIndex <= mid && derIndex <= der)
            {
                if (arreglo[izqIndex] <= arreglo[derIndex])
                {
                    temp[tempIndex++] = arreglo[izqIndex++];
                }
                else
                {
                    temp[tempIndex++] = arreglo[derIndex++];
                }
            }

            while (izqIndex <= mid) 
            { 
                temp[tempIndex++] = arreglo[izqIndex++]; 
            } 
            while (derIndex <= der) 
            { 
                temp[tempIndex++] = arreglo[derIndex++]; 
            }
            for (int i = izq; i <= der; i++)
            {
                arreglo[i] = temp[i];
            }
        }


        private void ordenar(int[] arreglo, int[] temp, int izq, int der)
        {
            if (izq >= der) return;
            int mid = (izq + der) / 2;

            ordenar(arreglo, temp, izq, mid);
            ordenar(arreglo, temp, mid + 1, der);
            unir(arreglo, temp, izq, mid, der);

        }
        public void MergeDtc(int[] arreglo)
        {
            if (arreglo.Length <= 1) return;

            int[] temp= new int[arreglo.Length];
            ordenar(arreglo, temp, 0, arreglo.Length - 1);
        }
    }
}
