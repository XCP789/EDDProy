using EDDemo.Recursividad.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Recursividad
{
    public partial class FrmRecursividad : Form
    {
        private CdgRecursivo recursividad;
        private Random random;
        public FrmRecursividad()
        {
            InitializeComponent();
            recursividad = new CdgRecursivo(); 
            random = new Random();
        }

        private void btnCalcularFactorial_Click(object sender, EventArgs e)
        {
            int numero = (int)numericFactorial.Value;
            int resultado = recursividad.Factorial(numero);
            lblResultadoFactorial.Text = resultado.ToString();
        }

        private void btnCalcularPotencia_Click(object sender, EventArgs e)
        {
           
        }

        private void MostrarArreglo(int[] arreglo, Label label)
        {
            label.Text = string.Join(", ", arreglo); // Mostrar el arreglo separado por comas
        }

        private void btnGenerarArreglo_Click(object sender, EventArgs e)
        {
            int tamaño = (int)numericTamañoArreglo.Value;
            if (tamaño > 0)
            {
                int[] arreglo = GenerarArreglo(tamaño);
                MostrarArreglo(arreglo, lblArreglo);
                int suma = recursividad.SumarArreglo(arreglo, arreglo.Length);
                lblResultadoArreglo.Text = $"Suma: {suma}";
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número válido y mayor a 0.");
            }
        }
        private int[] GenerarArreglo(int tamaño)
        {
            int[] arreglo = new int[tamaño]; 
            for (int i = 0; i < tamaño; i++)
            {
                arreglo[i] = random.Next(1000); // Generar números aleatorios entre 0 y 999
            } 
            return arreglo; 
        }

        private void btnCalcularPotencia_Click_1(object sender, EventArgs e)
        {
            int baseNum = (int)numericBase.Value;
            int exponente = (int)numericExponente.Value;
            int resultado = recursividad.Potencia(baseNum, exponente);
            lblResultadoPotencia.Text = resultado.ToString();
        }
    }
}
