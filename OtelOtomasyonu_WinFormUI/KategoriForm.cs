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
    public partial class KategoriForm : Form
    {
        public KategoriForm()
        {
            InitializeComponent();
        }

        KategoriORM kategoriOrm = new KategoriORM();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Kategoriler kategori = new Kategoriler();
            kategori.Adi = txtKategoriAdi.Text;
            bool sonuc = kategoriOrm.Insert(kategori);
            if (sonuc)
            {
                MessageBox.Show("Kategori Eklendi.");
                dataGridView1.DataSource = kategoriOrm.Select();
            }
            else
            {
                MessageBox.Show("Kategori eklerken bir hata oluştu.");
            }
            txtKategoriAdi.Clear();
        }

        private void KategoriForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = kategoriOrm.Select();
        }
    }
}
