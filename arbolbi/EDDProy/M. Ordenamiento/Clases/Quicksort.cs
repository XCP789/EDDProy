using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.M._Ordenamiento.Clases
{
    public class Quicksort
    {
        private void intercambiar(int[] arreglo, int i, int j)
        {
            int temp=arreglo[i];
            arreglo[i]=arreglo[j];
            arreglo[j]=temp;
        }
        private int particion(int[] arrglo, int bajo, int alto)
        {
            int pivote = arrglo[alto];
            int i = (bajo - 1);

            for (int j = bajo; j < alto; j++)
            {
                if (arrglo[j] < pivote)
                {
                    i++;
                    intercambiar(arrglo, i, j);
                }
            }
            intercambiar(arrglo, i + 1, alto);
            return i + 1;
        }
        private void QSrecursivo(int[] arreglo, int bajo, int alto)
        {
            if(bajo<alto)
            {
                int m=particion(arreglo,bajo, alto);
                QSrecursivo(arreglo,bajo,m - 1);
                QSrecursivo(arreglo,m + 1,alto);
            }
        }
        public void Ordenar(int[] arreglo) 
        {
            QSrecursivo(arreglo, 0, arreglo.Length - 1);
        }
    }

}
