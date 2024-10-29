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

        public FrmGrafica()
        {
        }

        private void FrmGrafica_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (raiz != null)
            {
                DibujarArbol(g, raiz, panelDibujo.Width / 2, 20, panelDibujo.Width / 4, 50);
            }
        }

        private void panelDibujo_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; if (raiz != null)
            {
                DibujarArbol(g, raiz, panelDibujo.Width / 2, 20, panelDibujo.Width / 4, 50);
            }
        }
        private void DibujarArbol(Graphics g, NodoBinario nodo, int x, int y, int dx, int dy)
        {
            if (nodo != null)
            {
                // Dibuja el nodo
                g.FillEllipse(Brushes.White, x - 15, y - 15, 30, 30);
                g.DrawEllipse(Pens.Black, x - 15, y - 15, 30, 30);
                g.DrawString(nodo.Dato.ToString(), this.Font, Brushes.Black, x - 10, y - 10);

                // Dibuja las líneas y los nodos hijos
                if (nodo.Izq != null)
                {
                    g.DrawLine(Pens.Black, x, y, x - dx, y + dy);
                    DibujarArbol(g, nodo.Izq, x - dx, y + dy, dx / 2, dy);
                }

                if (nodo.Der != null)
                {
                    g.DrawLine(Pens.Black, x, y, x + dx, y + dy);
                    DibujarArbol(g, nodo.Der, x + dx, y + dy, dx / 2, dy);
                }
            }
        }

    }
}
