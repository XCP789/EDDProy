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
    public partial class FrmQuicksort : Form
    {
        private Quicksort quicksort;
        private Random random;
        public FrmQuicksort()
        {
            InitializeComponent();
            quicksort = new Quicksort();
            random = new Random();
        }


        private void FrmQuicksort_Load(object sender, EventArgs e)
        {

        }
        private int[] GenerarA(int tamano)
        {
            int[] arreglo = new int[tamano];
            for(int i = 0; i<tamano; i++)
            {
                arreglo[i] = random.Next(100);

            }
            return arreglo;
        }
        private void MostarA(int[] arreglo, Label lbl)
        {
            lbl.Text = string.Join(", ", arreglo);
        }
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int tamano = (int)Numerador.Value;
            if (tamano > 1)
            {
                int[] arreglo = GenerarA(tamano);
                MostarA(arreglo, lblDesordenado);

                quicksort.Ordenar(arreglo);
                MostarA(arreglo, lblOrdenado);  
            }
        }
    }
}
