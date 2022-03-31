using OtelOtomasyonu_ORM.Entity;
using OtelOtomasyonu_ORM.Facade;
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
    public partial class KasaForm : Form
    {
        public KasaForm()
        {
            InitializeComponent();
        }

        KasaORM kasaOrm = new KasaORM();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Kasa kasa = new Kasa();
            kasa.Adi = txtKasaAdi.Text;
            kasa.Aciklama = txtAciklama.Text;
            bool sonuc = kasaOrm.Insert(kasa);
            if (sonuc)
            {
                MessageBox.Show("Kasa Eklendi.");
                dataGridView1.DataSource = kasaOrm.Select();
            }
            else
            {
                MessageBox.Show("Kasa eklenirken bir hata oluştu.");
            }
            txtKasaAdi.Clear();
            txtAciklama.Clear();
        }

        private void KasaForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = kasaOrm.Select();
        }
    }
}
