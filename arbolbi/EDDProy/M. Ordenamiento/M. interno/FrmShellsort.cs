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
    public partial class FrmShellsort : Form
    {
        private Shellsort shellsort;
        private Random random;
        public FrmShellsort()
        {
            InitializeComponent();
            shellsort = new Shellsort();
            random = new Random();
        }

        private int[] GenerarA(int n)
        {
            int[] arreglo= new int[n];
            for (int i = 0; i < n; i++)
            {
                arreglo[i]=random.Next(1000);
            }
            return arreglo;
        }
        private void MostrarA(int[] arreglo, Label lbl )
        {
            lbl.Text=String.Join(", ", arreglo);
        }

        private void FrmShellsort_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int n = (int)Enumerador.Value;
            if (n > 0)
            {
                int[] arreglo=GenerarA(n);
                MostrarA(arreglo, lblDesordenado);

                shellsort.Ordenar(arreglo);
                MostrarA(arreglo, lblOrdenado);
            }
            
        }
    }
}
