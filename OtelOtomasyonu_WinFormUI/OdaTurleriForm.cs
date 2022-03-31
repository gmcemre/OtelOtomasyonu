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
    public partial class OdaTurleriForm : Form
    {
        public OdaTurleriForm()
        {
            InitializeComponent();
        }

        OdaTurORM otOrm = new OdaTurORM();
        private void OdaTurleriForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = otOrm.Select();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            OdaTurleri ot = new OdaTurleri();
            ot.Adi = txtOdaTurAdi.Text;
            ot.Aciklama = txtAciklama.Text;
            bool sonuc = otOrm.Insert(ot);
            if (sonuc)
            {
                MessageBox.Show("Oda Türü Eklendi.");
                dataGridView1.DataSource = otOrm.Select();
            }
            else
            {
                MessageBox.Show("Oda Türü eklenirken bir hata oluştu.");
            }
            txtOdaTurAdi.Clear();
            txtAciklama.Clear();
        }
    }
}
