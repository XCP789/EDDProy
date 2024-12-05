using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo.Estructuras_Lineales.Clases;

namespace EDDemo.Estructuras_Lineales
{
    public partial class FormPilas : Form
    {
        private Pila<int> pila; 
        public FormPilas()
        {
            InitializeComponent();
            pila = new Pila<int>();
        }
        private void MostrarPila()
        {
            lstPila.Items.Clear();
            foreach (var cola in pila.pilas())
            {
                lstPila.Items.Add(cola);
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCaja.Text != null)
            {
                int dato=int.Parse(txtCaja.Text);
                pila.insertar(dato);
                txtCaja.Clear();
                MostrarPila();
                
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (pila.Vacio())
            {
                MessageBox.Show("la pila esta vacia");
            }
            else
            {
                int dato= pila.Eliminar();
                MostrarPila();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            if (pila.Vacio())
            {
                MessageBox.Show("la pila esta vacia");
            }
            else
            {
                pila.vaciar();
                MostrarPila();
            }
        }
    }
}
