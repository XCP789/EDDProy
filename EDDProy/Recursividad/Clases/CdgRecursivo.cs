using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Recursividad.Clases
{
    public class CdgRecursivo
    {
        // Factorial de un número
        public int Factorial(int n) 
        { 
            if (n <= 1) 
                return 1; 
            else 
                return n * Factorial(n - 1); 
        } 
        // Cálculo de un exponente
        public int Potencia(int baseNum, int exponente) 
        { 
            if (exponente == 0) 
                return 1; 
            else 
                return baseNum * Potencia(baseNum, exponente - 1); 
        }
        // Sumar los elementos de un arreglo
        public int SumarArreglo(int[] arreglo, int n)
        {
            if (n <= 0)
                return 0;
            else
                return arreglo[n - 1] + SumarArreglo(arreglo, n - 1);
        }
    }
}
