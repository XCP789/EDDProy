using EDDemo.M._Ordenamiento.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.M._Ordenamiento.M._externo
{
    public partial class FrmBurbuja : Form
    {
        private Burbuja burbuja;
        private Random random;
        public FrmBurbuja()
        {
            InitializeComponent();
            burbuja = new Burbuja();
            random = new Random();
        }

        private void FrmBurbuja_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int tamanio = (int)Enumerar.Value;
            if (tamanio > 0)
            {
                int[] arreglo = GenerarArreglo(tamanio);
                MostrarA(arreglo, lblDesordendo);

                burbuja.Ordenar(arreglo);
                MostrarA(arreglo, lblOrdenado);
            }
        }

        private int[] GenerarArreglo(int tamanio)
        {
            int[] arreglo = new int[tamanio];
            for (int i = 0; i < tamanio; i++)
            {
                arreglo[i] = random.Next(100);
            }
            return arreglo;
        }

        private void MostrarA(int[] arreglo, Label label)
        {
            label.Text=string.Join(",", arreglo);
        }
    }
}
