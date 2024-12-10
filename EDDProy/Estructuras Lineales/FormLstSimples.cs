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
    public partial class FormLstSimples : Form
    {
        private ListaEnlazada<String> lista;
        public FormLstSimples()
        {
            InitializeComponent();
            lista = new ListaEnlazada<String>();
           
        }
        private void Mostrarlista()
        {
            lstListaE.Items.Clear();
            foreach (var item in lista.GetItems())
            {
                lstListaE.Items.Add(item);
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string item=txtLista.Text;
            lista.Add(item);
            txtLista.Clear();
            Mostrarlista();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string item= txtLista.Text;
            lista.Eliminar(item);
            txtLista.Clear();
            Mostrarlista();
        }

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            lista = new ListaEnlazada<String>();
            Mostrarlista();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String item = txtLista.Text;
            txtLista.Clear();
            bool found = lista.Buscar(item);
            if(found)
            {
                MessageBox.Show("valor encontrado");
            }
            else
            {
                MessageBox.Show("valor no encontrado");
            }
        }
    }
}
