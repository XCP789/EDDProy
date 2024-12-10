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
    public partial class FormLstCirculares : Form
    {
        private ListaCircularesS<String> listaCircular;
        public FormLstCirculares()
        {
            InitializeComponent();
            listaCircular=new ListaCircularesS<String>();
        }
        private void Mostrarlista()
        {
            lstCircular.Items.Clear();
            foreach (var item in listaCircular.GetItems())
            {
                lstCircular.Items.Add(item);
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            String item=txtCirculares.Text;
            listaCircular.insertar(item);
            txtCirculares.Clear();
            Mostrarlista();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int posicion;
            if (int.TryParse(txtCirculares.Text, out posicion))
            {
                listaCircular.eliminar(posicion);
                txtCirculares.Clear();
                Mostrarlista();
            }
            else
            {
                MessageBox.Show("ingresa una posicion");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String item = txtCirculares.Text;
            bool found = listaCircular.buscar(item);
            if(found)
            {
                MessageBox.Show("valor encontrado");
            }
            else
            {
                MessageBox.Show("valor no encontrado");
            }
        }

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            listaCircular.vaciar();
            Mostrarlista();
        }
    }
}
