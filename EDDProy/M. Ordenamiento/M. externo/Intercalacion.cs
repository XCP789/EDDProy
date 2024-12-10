﻿using EDDemo.M._Ordenamiento.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.M._Ordenamiento.M._externo
{
    public partial class Intercalacion : Form
    {
        private MergeSort mergeSort; 
        private Random random; 
        public Intercalacion() 
        { 
            InitializeComponent(); 
            mergeSort = new MergeSort(); 
            random = new Random(); 
        }
        private void MostrarArreglo(int[] arreglo, Label label)
        {
            label.Text = string.Join(", ", arreglo); // Mostrar el arreglo separado por comas
        }
        private int[] GenerarArreglo(int tamano)
        {
            int[] arreglo = new int[tamano]; for (int i = 0; i < tamano; i++)
            {
                arreglo[i] = random.Next(1000); // Generar números aleatorios entre 0 y 999
            }
            return arreglo;
        }
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int tamano = (int)Numerador.Value;
            if (tamano > 0)
            {
                int[] arreglo = GenerarArreglo(tamano); 
                MostrarArreglo(arreglo, lblDesordenado);

                mergeSort.Ordenar(arreglo);
                MostrarArreglo(arreglo, lblOrdenado);
            }
            
        }

        private void Intercalacion_Load(object sender, EventArgs e)
        {

        }
    }
}
