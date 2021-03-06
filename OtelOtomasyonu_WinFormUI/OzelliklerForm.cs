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
    public partial class OzelliklerForm : Form
    {
        public OzelliklerForm()
        {
            InitializeComponent();
        }

        OzelliklerORM ozOrm = new OzelliklerORM();
        private void OzelliklerForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ozOrm.Select();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ozellikler oz = new Ozellikler();
            oz.Adi = txtAdi.Text;
            oz.Aciklama = txtAciklama.Text;
            bool sonuc = ozOrm.Insert(oz);
            if (sonuc)
            {
                MessageBox.Show("Özellik eklendi.");
                dataGridView1.DataSource = ozOrm.Select();
            }
            else
            {
                MessageBox.Show("Özellik eklenirken bir hata oluştu.");
            }
            txtAdi.Clear();
            txtAciklama.Clear();
        }
    }
}
