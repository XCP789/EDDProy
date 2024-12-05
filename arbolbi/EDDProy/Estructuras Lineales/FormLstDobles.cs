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
    public partial class FormLstDobles : Form
    {
        private ListaDobles<String> listaD;
        public FormLstDobles()
        {
            InitializeComponent();
            listaD = new ListaDobles<String>();
        }
        private void Mostrarlista()
        {
            lstListaD.Items.Clear();
            foreach (var item in listaD.GetItems())
            {
                lstListaD.Items.Add(item);
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            String item = txtListaD.Text;
            listaD.Add(item);
            txtListaD.Clear();
            Mostrarlista();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            String item = txtListaD.Text;
            listaD.Quitar(item);
            txtListaD.Clear();
            Mostrarlista();
        }

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            listaD=new ListaDobles<String>();
            Mostrarlista();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String item =txtListaD.Text;
            txtListaD.Clear();
            bool found=listaD.Buscar(item);
            if (found)
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
