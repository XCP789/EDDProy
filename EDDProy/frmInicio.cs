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
using EDDemo.M._Busqueda;
using EDDemo.M._Ordenamiento.M._externo;
using EDDemo.M._Ordenamiento.M._interno;
using EDDemo.Recursividad;

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

        private void quickshortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmQuicksort mQuicksort = new FrmQuicksort();
            mQuicksort.MdiParent = this;
            mQuicksort.Show();
        }

        private void radixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRadix mRadix = new FrmRadix();
            mRadix.MdiParent = this;
            mRadix.Show();
        }

        private void intercalacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Intercalacion minterc = new Intercalacion();
            minterc.MdiParent = this;
            minterc.Show();
        }

        private void mezclaDirectaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MezclaDirecta mMezclaD = new MezclaDirecta();
            mMezclaD.MdiParent = this;
            mMezclaD.Show();
        }

        private void mezclaNaturalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MezclaNatural mMezclaN = new MezclaNatural();
            mMezclaN.MdiParent = this;
            mMezclaN.Show();
        }

        private void busquedaBinariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBqBinaria bqBinaria = new FrmBqBinaria();
            bqBinaria.MdiParent = this;
            bqBinaria.Show();
        }

        private void busquedaPorHASHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBqHASH frmHASH = new FrmBqHASH();
            frmHASH.MdiParent = this;
            frmHASH.Show();
        }

        private void factorialDeUnNumeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRecursividad mrecursividad = new FrmRecursividad();
            mrecursividad.MdiParent = this;
            mrecursividad.Show();
        }
    }
}
