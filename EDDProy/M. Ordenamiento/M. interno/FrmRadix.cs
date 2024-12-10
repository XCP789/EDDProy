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

namespace EDDemo.M._Ordenamiento.M._interno
{
    public partial class FrmRadix : Form
    {
        private Radix radixsort;
        private Random random;
        public FrmRadix()
        {
            InitializeComponent();
            radixsort = new Radix();
            random = new Random();

        }
        private int[] GenerarA(int tamano)
        {
            int[] arreglo= new int[tamano];
            for(int i = 0; i<tamano;i++)
            {
                arreglo[i] = random.Next(1000);
            }
            return arreglo;
        }
        private void MostrarA(int[] arreglo, Label lbl)
        {
            lbl.Text = string.Join(", ", arreglo);
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int tamano=(int)Numerador.Value;
            if (tamano>0)
            {
                int[] arreglo = GenerarA(tamano);
                MostrarA(arreglo, lblDesordenado);

                radixsort.Ordenar(arreglo);
                MostrarA(arreglo, lblOrdenado);
            }
        }


    }
}
