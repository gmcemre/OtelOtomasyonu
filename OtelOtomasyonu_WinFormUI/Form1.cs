using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelOtomasyonu_WinFormUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        KasaForm kf = new KasaForm();
        private void kasaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (kf.IsDisposed)
                kf = new KasaForm();
            kf.MdiParent = this;
            kf.Show();
        }

        KategoriForm ktgForm = new KategoriForm();
        private void kategorilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ktgForm.IsDisposed)
                ktgForm = new KategoriForm();
            ktgForm.MdiParent = this;
            ktgForm.Show();
        }

        UrunForm uForm = new UrunForm();
        private void ürünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (uForm.IsDisposed)
                uForm = new UrunForm();
            uForm.MdiParent = this;
            uForm.Show();
        }

        BirimTipForm bt = new BirimTipForm();
        private void birimTipleriToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (bt.IsDisposed)
                bt = new BirimTipForm();
            bt.MdiParent = this;
            bt.Show();
        }

        OdaTurleriForm otForm = new OdaTurleriForm();
        private void odaÖzellikleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (otForm.IsDisposed)
                otForm = new OdaTurleriForm();
            otForm.MdiParent = this;
            otForm.Show();
        }
        OdaForm oForm = new OdaForm();
        private void odalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (oForm.IsDisposed)
                oForm = new OdaForm();
            oForm.MdiParent = this;
            oForm.Show();
        }

        OzelliklerForm ozForm = new OzelliklerForm();
        private void birimTipleriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ozForm.IsDisposed)
                ozForm = new OzelliklerForm();
            ozForm.MdiParent = this;
            ozForm.Show();
        }

        OdaOzellikForm odaOzFrom = new OdaOzellikForm();
        private void özelliklerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (odaOzFrom.IsDisposed)
                odaOzFrom = new OdaOzellikForm();
            odaOzFrom.MdiParent = this;
            odaOzFrom.Show();
        }

        MusteriForm mForm = new MusteriForm();
        private void müşterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mForm.IsDisposed)
                mForm = new MusteriForm();
            mForm.MdiParent = this;
            mForm.Show();
        }

        PersonellerForm pFrom = new PersonellerForm();
        private void personellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pFrom.IsDisposed)
                pFrom = new PersonellerForm();
            pFrom.MdiParent = this;
            pFrom.Show();
        }

        SatisForm sf = new SatisForm();
        private void satışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sf.IsDisposed)
                sf = new SatisForm();
            sf.MdiParent = this;
            sf.Show();
        }
    }
}
