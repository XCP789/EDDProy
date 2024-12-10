using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.M._Ordenamiento.Clases
{
    internal class MergeNatural
    {
        public void MergeNt(int[] arreglo)
        {
            if (arreglo.Length <= 1) return;
            int[] temp = new int[arreglo.Length];
            while (true)
            {
                int izqIndex = 0;
                bool merged = false;

                while (izqIndex < arreglo.Length)
                {
                    int mid = FindRun(arreglo, izqIndex);
                    if (mid == arreglo.Length - 1) break;

                    int derIndex = FindRun(arreglo, mid + 1);

                    Unir(arreglo, temp, izqIndex, mid, derIndex);
                    merged = true;

                    izqIndex = derIndex + 1;
                }

                if (!merged)
                    break;
            }
        }
        private int FindRun(int[] arreglo, int inicio)
        {
            while (inicio < arreglo.Length - 1 && arreglo[inicio] <= arreglo[inicio + 1])
            {
                inicio++;
            }
            return inicio;
        }

        private void Unir(int[] arreglo, int[] temp, int izq, int mid, int der)
        {
            int izqIndex = izq;
            int derIndex = mid + 1;
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
    }
}
