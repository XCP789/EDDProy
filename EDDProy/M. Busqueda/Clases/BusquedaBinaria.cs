using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.M._Busqueda.Clases
{
    public class BusquedaBinaria
    {
        public int Buscar(int[] arreglo, int elemento)
        {
            int izq = 0;
            int der = arreglo.Length - 1;
            while (izq <= der)
            {
                int mid = izq + (der - izq) / 2;
                if (arreglo[mid] == elemento)
                {
                    return mid; // Elemento encontrado
                }
                else if
                    (arreglo[mid] < elemento)
                {
                    izq = mid + 1;
                }
                else
                {
                    der = mid - 1;
                }
            }
            return -1; // Elemento no encontrado
        }        
    }
}
