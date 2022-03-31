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
    public partial class MusteriForm : Form
    {
        public MusteriForm()
        {
            InitializeComponent();
        }

        MusteriORM mOrm = new MusteriORM();
        private void MusteriForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = mOrm.Select();
            cmbMedeniDurum.DataSource = Enum.GetNames(typeof(MedeniDurumTip));
            cmbCinsiyet.DataSource = Enum.GetNames(typeof(Cinsiyet));
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Musteriler musteri = new Musteriler();
            musteri.Adi = txtAdi.Text;
            musteri.Soyadi = txtSoyadi.Text;
            musteri.SirketAdi = txtSirketAdi.Text;
            musteri.Tckn = mskTckn.Text;
            musteri.TelNo = mskTelNo.Text;
            musteri.DogumTarihi = dtpDogumTarihi.Value;
            musteri.MedeniDurum = (MedeniDurumTip)Enum.Parse(typeof(MedeniDurumTip), cmbMedeniDurum.SelectedItem.ToString());
            musteri.Cinsiyet = (Cinsiyet)Enum.Parse(typeof(Cinsiyet), cmbCinsiyet.SelectedItem.ToString());

            bool sonuc = mOrm.Insert(musteri);
            if (sonuc)
            {
                MessageBox.Show("Müşteri Eklendi.");
                dataGridView1.DataSource = mOrm.Select();
            }
            else
            {
                MessageBox.Show("Müşteri Eklenirken Bir Hata Oluştu.");
            }
        }
    }
}
