using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.M._Busqueda.Clases
{
    public class BusquedaHASH
    {
        private Dictionary<int, int> hashTable;
        public BusquedaHASH()
        {
            hashTable = new Dictionary<int, int>();
        }
        public void insertar(int[] arreglo)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                if(!hashTable.ContainsKey(arreglo[i]))
                {
                    hashTable.Add(arreglo[i], i);
                }
            }
        }

        public int Buscar(int elemento)
        {
            if(hashTable.ContainsKey(elemento))
            {
                return hashTable[elemento];
            }
            else
            {
                return -1;
            }
        }
    }
}
