using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.M._Ordenamiento.M._interno
{
    public class Shellsort
    {
        public void Ordenar(int[] arreglo)
        {
            int n = arreglo.Length;
            int gap = n / 2;
            while (gap > 0)
            {
                for (int i = gap; i < n; i++)
                {
                    int temp=arreglo[i];
                    int j = i;
                    while(j>= gap && arreglo[j-gap]>temp)
                    {
                        arreglo[j]= arreglo[j-gap];
                        j-=gap;

                    }
                    arreglo[j] = temp;
                }
                gap /= 2;
            }
        }
    }
}
