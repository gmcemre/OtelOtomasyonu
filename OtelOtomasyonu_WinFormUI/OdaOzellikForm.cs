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
    public partial class OdaOzellikForm : Form
    {
        public OdaOzellikForm()
        {
            InitializeComponent();
        }

        private void OdaOzellikForm_Load(object sender, EventArgs e)
        {
            OdaORM odalar = new OdaORM();
            cmbOdalar.DisplayMember = "Adi";
            cmbOdalar.ValueMember = "Id";
            cmbOdalar.DataSource = odalar.Select();
            OzelliklerORM ozOrm = new OzelliklerORM();
            listOzellikler.DisplayMember = "Adi";
            listOzellikler.ValueMember = "Id";
            listOzellikler.DataSource = ozOrm.Select();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            OdaOzellikleriORM odaOzOrm = new OdaOzellikleriORM();
            OdaOzellikleri odaOzellikleri = new OdaOzellikleri();
            odaOzellikleri.OdaID = (int)cmbOdalar.SelectedValue;
            odaOzellikleri.OzellikID = (int)listOzellikler.SelectedValue;
            short deger;
            if (short.TryParse(txtDeger.Text, out deger))
            {
                odaOzellikleri.Deger = deger;
            }
            bool sonuc = odaOzOrm.Insert(odaOzellikleri);
            if (sonuc)
            {
                MessageBox.Show("Odaya seçilen özellik eklendi.");
            }
            else
            {
                MessageBox.Show("Özellik atama sırasında bir hata oluştu.");
            }
            txtDeger.Clear();
        }
    }
}
