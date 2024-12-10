using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.M._Ordenamiento.Clases
{
    public class Burbuja
    {
        public void Ordenar(int[] arreglo)
        {
            int n = arreglo.Length;
            for (int i = 0; i < n - 1;  i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (arreglo[j] > arreglo[j + 1])
                    {
                        int temp = arreglo[j];
                        arreglo[j] = arreglo[j + 1];
                        arreglo[j + 1] = temp;
                    }
                }
            }
        }
    }
}
