﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_No_Lineales
{
    public partial class frmArboles : Form
    {
        ArbolBusqueda miArbol;
        NodoBinario miRaiz;

        public frmArboles()
        {
            InitializeComponent();
            miArbol = new ArbolBusqueda();
            miRaiz = null;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
 
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();

            //Limpiamos la cadena donde se concatenan los nodos del arbol 
            miArbol.strArbol = "";

            //Se inserta el nodo con el dato capturado
            miArbol.InsertaNodo(int.Parse(txtDato.Text), ref miRaiz);

            //Leer arbol completo y mostrarlo en caja de texto
            miArbol.Muestra(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;
            
            txtDato.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            miArbol = null;
            miRaiz = null;
            miArbol = new ArbolBusqueda();
            txtArbol.Text  = "";
            txtDato.Text = "";
        }

        

        private void btnRecorrer_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            //recorrido PreOrden
            if (miRaiz == null)
            {
                lblRePreOrden.Text = "El arbol esta vacio";
                return;
            }
            lblRePreOrden.Text = "";
            miArbol.PreOrden(miRaiz);

            lblRePreOrden.Text = miArbol.strRecorrido;

            //recorrido InOrden
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                lblReInOrden.Text = "El arbol esta vacio";
                return;
            }
            lblReInOrden.Text = "";
            miArbol.InOrden(miRaiz);
            lblReInOrden.Text = miArbol.strRecorrido;

            //recorrido PostOrden
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                lblRePostOrden.Text = "El arbol esta vacio";
                return;
            }
            lblRePostOrden.Text = "";
            miArbol.PostOrden(miRaiz);
            lblRePostOrden.Text = miArbol.strRecorrido;
        }

        private void btnCrearArbol_Click(object sender, EventArgs e)
        {
            //Limpiamos los objetos y clases del anterior arbol
            miArbol = null;
            miRaiz = null;
            miArbol = new ArbolBusqueda();
            txtArbol.Text = "";
            txtDato.Text = "";

            miArbol.strArbol = "";

            Random rnd = new Random();

            for (int nNodos = 1; nNodos <= txtNodos.Value; nNodos++)
            {
                int Dato = rnd.Next(1, 100);
                //Obtenemos el nodo Raiz del arbol
                miRaiz = miArbol.RegresaRaiz();

                //Se inserta el nodo con el dato capturado
                miArbol.InsertaNodo(Dato, ref miRaiz);
            }

            //Leer arbol completo y mostrarlo en caja de texto
            miArbol.Muestra(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;

            txtDato.Text = "";
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            int valor = int.Parse(txtBuscar.Text);
            miArbol.MostrarBuqueda(valor);
        }

        

        private void btnDibujarA_Click(object sender, EventArgs e)
        {
            FrmGrafica grafica = new FrmGrafica(miRaiz);
            grafica.Show();
        }

    }
}
