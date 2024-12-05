using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo.Estructuras_Lineales;
using EDDemo.Estructuras_No_Lineales;
using EDDemo.M._Ordenamiento.M._externo;
using EDDemo.M._Ordenamiento.M._interno;

namespace EDDemo
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pilasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPilas mPilas = new FormPilas();
            mPilas.MdiParent = this;
            mPilas.Show();
        }

        private void estructurasLinealesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void arbolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArboles mArboles = new frmArboles();
            mArboles.MdiParent = this;
            mArboles.Show();

            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void colasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormColas mColas = new FormColas();
            mColas.MdiParent = this;
            mColas.Show();
        }

        private void listasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLstSimples mLsimple = new FormLstSimples();
            mLsimple.MdiParent = this;
            mLsimple.Show();
        }

        private void lToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLstDobles mLdobles = new FormLstDobles();
            mLdobles.MdiParent = this;
            mLdobles.Show();
        }

        private void listasCircularesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLstCirculares mLcirculantes = new FormLstCirculares();
            mLcirculantes.MdiParent = this;
            mLcirculantes.Show();
        }

        private void burbujaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBurbuja mBurbuja = new FrmBurbuja();
            mBurbuja.MdiParent = this;
            mBurbuja.Show();
        }

        private void shellsortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShellsort mShellsort = new FrmShellsort();
            mShellsort.MdiParent = this;
            mShellsort.Show();
        }
    }
}
