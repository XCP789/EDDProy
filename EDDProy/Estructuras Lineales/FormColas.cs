using EDDemo.Estructuras_Lineales.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EDDemo.Estructuras_Lineales
{
    public partial class FormColas : Form
    {       
        private Cola<int> Cola;
        public FormColas()
        {
            InitializeComponent();
            Cola = new Cola<int>();

        }
        private void MostrarCola()
        {
            LstCola.Items.Clear();
            NodoCola<int> aux = Cola.top;
            while (aux != null)
            {
                LstCola.Items.Add(aux.Valor); 
                aux = aux.sig;
            }
        }


        private void btnQueue_Click_1(object sender, EventArgs e)
        {
            int dato = int.Parse(txtCaja.Text);
            Cola.encolar(dato);
            txtCaja.Clear();
            MostrarCola();
        }

        private void btnDequeue_Click_1(object sender, EventArgs e)
        {
           if(Cola.vacio())
            {
                MessageBox.Show("la cola esta vacia");
            }
            else
            {
                int dato = Cola.desencolar();
                txtCaja.Clear();
                MostrarCola();
            }
        }

        

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            if (Cola.vacio())
            {
                MessageBox.Show("la cola esta vacia");
            }
            else
            {
                Cola = new Cola<int>();
                MostrarCola();
            }
        }

        private void txtCaja_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
