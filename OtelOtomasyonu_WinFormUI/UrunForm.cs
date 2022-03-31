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
    public partial class UrunForm : Form
    {
        public UrunForm()
        {
            InitializeComponent();
        }

        UrunORM uOrm = new UrunORM();
        BirimTipORM btpOrm = new BirimTipORM();
        private void UrunForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = uOrm.Select();
            BirimTipORM btpOrm = new BirimTipORM();
            cmbBirimTip.DisplayMember = "Adi";
            cmbBirimTip.ValueMember = "Id";
            cmbBirimTip.DataSource = btpOrm.Select();
            KategoriORM kOrm = new KategoriORM();
            cmbKategori.DisplayMember = "Adi";
            cmbKategori.ValueMember = "Id";
            cmbKategori.DataSource = kOrm.Select();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Urunler urun = new Urunler();
            urun.Adi = txtUrunAdi.Text;
            urun.Fiyat = nudFiyat.Value;
            urun.Miktar = (float)nudMiktar.Value;
            urun.BirimTipID = Convert.ToInt32(cmbBirimTip.SelectedValue);
            urun.KategoriID = Convert.ToInt32(cmbKategori.SelectedValue);

            bool sonuc = uOrm.Insert(urun);
            if (sonuc)
            {
                MessageBox.Show("Ürün eklendi.");
                dataGridView1.DataSource = uOrm.Select();
            }
            else
            {
                MessageBox.Show("Ürün eklenirken bir hata oluştu.");
            }
            txtUrunAdi.Clear();
            nudFiyat.ResetText();
            nudMiktar.ResetText();
        }
    }
}
