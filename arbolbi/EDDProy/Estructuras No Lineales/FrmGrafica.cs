using EDDemo.Estructuras_No_Lineales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo
{
    public partial class FrmGrafica : Form
    {
        NodoBinario raiz;
        public FrmGrafica(NodoBinario raiz)
        {
            InitializeComponent();
            this.raiz = raiz;
        }
        
        private void FrmGrafica_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (raiz != null)
            {
                DibujarArbol(g, raiz, panelDibujo.Width / 2, 20, panelDibujo.Width / 4, 50);
            }
        }
        // Evento Paint del formulario FrmGrafica
        private void panelDibujo_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; // Obtiene el objeto Graphics para dibujar 
            if (raiz != null)
            {
                DibujarArbol(g, raiz, panelDibujo.Width / 2, 20, panelDibujo.Width / 4, 50);  // Llama al método DibujarArbol para dibujar el árbol binario
            }
        }
        private void DibujarArbol(Graphics g, NodoBinario nodo, int x, int y, int dx, int dy)
        {
            if (nodo != null)
            {
                // Dibuja una elipse blanca con borde negro para representar el nodo
                g.FillEllipse(Brushes.White, x - 15, y - 15, 30, 30);
                g.DrawEllipse(Pens.Black, x - 15, y - 15, 30, 30);
                // Escribe el valor del nodo dentro de la elipse
                g.DrawString(nodo.Dato.ToString(), this.Font, Brushes.Black, x - 10, y - 10);

                // Si hay un nodo hijo izquierdo, dibuja la línea y llama recursivamente
                if (nodo.Izq != null)
                {
                    g.DrawLine(Pens.Black, x, y, x - dx, y + dy);//dibuja la linea
                    DibujarArbol(g, nodo.Izq, x - dx, y + dy, dx / 2, dy);//llama recursivamente
                }
                // Si hay un nodo hijo derecho, dibuja la línea y llama recursivamente
                if (nodo.Der != null)
                {
                    g.DrawLine(Pens.Black, x, y, x + dx, y + dy);
                    DibujarArbol(g, nodo.Der, x + dx, y + dy, dx / 2, dy);
                }
            }
        }

        private void FrmGrafica_Load(object sender, EventArgs e)
        {

        }
    }
}
