using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.M._Ordenamiento.Clases
{
    public class Radix
    {
        private void ContarArreglo(int[] arreglo, int exp)
        {
            int n = arreglo.Length;
            int[] salida = new int[n];
            int[] conteo = new int[10];

            for (int i = 0; i < n; i++)
                conteo[(arreglo[i] / exp) % 10]++;

            for (int i = 1; i<10; i++)
                conteo[i] += conteo[i-1];
            
            for (int i = n-1; i >= 0; i--)
            {
                salida[conteo[(arreglo[i] / exp) % 10]-1] = arreglo[i];
                conteo[(arreglo[i] / exp) % 10]--;
            }

            for(int i = 0;i < n; i++)
                arreglo[i] = salida[i];

        }
        private int Maximo(int[] arreglo)
        {
            int max = arreglo[0];
            for(int i = 1; i<arreglo.Length; i++)
            {
                if(arreglo[i] > max)
                    max = arreglo[i];
            }
            return max;
        }
        public void Ordenar(int[] arreglo)
        {
            int m = Maximo(arreglo);
            for (int exp=1; m/exp>0; exp*=10)
            {
                ContarArreglo(arreglo, exp);
            }
        }
    }
}
