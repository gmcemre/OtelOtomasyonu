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
    public partial class PersonellerForm : Form
    {
        public PersonellerForm()
        {
            InitializeComponent();
        }

        PersonelORM pOrm = new PersonelORM();
        private void PersonellerForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pOrm.Select();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Personeller personel = new Personeller();
            personel.Adi = txtAdi.Text;
            personel.Soyadi = txtSoyadi.Text;
            personel.Tckn = mskdTckn.Text;
            personel.TelNo = mskdTelNo.Text;
            personel.Adres = txtAdres.Text;
            personel.DogumTarihi = dtpDogumTarihi.Value;
            personel.IseGirisTarihi = dtpIseGiris.Value;
            personel.Maas = nudMaas.Value;
            personel.KullaniciAdi = txtKullaniciAdi.Text;
            personel.Parola = txtParola.Text;
            bool sonuc = pOrm.Insert(personel);
            if (sonuc)
            {
                MessageBox.Show("Personel Eklendi.");
                dataGridView1.DataSource = pOrm.Select();
            }
            else
            {
                MessageBox.Show("Persoel eklenirken bir hata oluştu.");
            }
        }
    }
}
