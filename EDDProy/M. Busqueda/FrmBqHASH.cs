using EDDemo.M._Busqueda.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.M._Busqueda
{
    public partial class FrmBqHASH : Form
    {
        private BusquedaHASH busquedaHash; 
        private Random random;
        public FrmBqHASH()
        {
            InitializeComponent();
            busquedaHash= new BusquedaHASH();
            random = new Random();
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

        private void MostrarArreglo(int[] arreglo, Label label)
        {
            label.Text = string.Join(", ", arreglo); // Mostrar el arreglo separado por comas
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int tamano = (int)Numerador2.Value;
            if(tamano>0)
            {
                int[] arreglo =GenerarArreglo(tamano);
                MostrarArreglo(arreglo, lblArreglo);

                busquedaHash.insertar(arreglo);
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número válido y mayor a 0.");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int elemento = (int)Numerador.Value; 
            int resultado = busquedaHash.Buscar(elemento); 
            if (resultado != -1) 
            { 
                MessageBox.Show($"Elemento encontrado en el índice: {resultado}"); 
            } 
            else 
            { 
                MessageBox.Show("Elemento no encontrado."); 
            }
        }
    }
}
