using OtelOtomasyonu_ORM.Entity;
using OtelOtomasyonu_ORM.Facade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelOtomasyonu_WinFormUI
{
    public partial class SatisForm : Form
    {
        public SatisForm()
        {
            InitializeComponent();
        }

        private void SatisForm_Load(object sender, EventArgs e)
        {
            MusteriORM mOrm = new MusteriORM();
            cmbMusteri.DisplayMember = "Adi";
            cmbMusteri.ValueMember = "Id";
            cmbMusteri.DataSource = mOrm.Select();
            OdaORM oOrm = new OdaORM();
            cmbOda.DisplayMember = "Adi";
            cmbOda.ValueMember = "Id";
            cmbOda.DataSource = oOrm.Select();
            UrunORM uOrm = new UrunORM();
            dataGridView1.DataSource = uOrm.Select();
        }

        private void btnSatisaEkle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Lütfen satışa eklemek istediğiniz ürünü seçiniz!");
                return;
            }

            ListViewItem lvi = new ListViewItem();
            lvi.Text = (listView1.Items.Count + 1).ToString();
            lvi.SubItems.Add(dataGridView1.CurrentRow.Cells["Adi"].Value.ToString());
            lvi.SubItems.Add(nudUrunMiktari.Value.ToString());
            lvi.SubItems.Add(nudUrunFiyati.Value.ToString());
            lvi.SubItems.Add(nudIndirim.Value.ToString());
            lvi.Tag = dataGridView1.CurrentRow.Cells["Id"].Value;
            listView1.Items.Add(lvi);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SatisORM sORM = new SatisORM();
            Satis satis = new Satis();
            satis.MusteriID = Convert.ToInt32(cmbMusteri.SelectedValue);
            satis.OdaID = Convert.ToInt32(cmbOda.SelectedValue);
            satis.OdaFiyati = nudOdaFiyati.Value;
            satis.PersonelID = PersonelORM.AktifKullanici.Id;
            satis.SatisTarihi = DateTime.Now;

            int satisID = Convert.ToInt32(sORM.InsertScalar(satis));
            if (satisID > 0)
            {
                SatisDetayORM sdOrm = new SatisDetayORM();
                bool sonuc = false;
                foreach (ListViewItem lvi in listView1.Items)
                {
                    SatisDetay sd = new SatisDetay();
                    sd.SatisID = satisID;
                    sd.UrunID = Convert.ToInt32(lvi.Tag);
                    sd.Miktar = Convert.ToDouble(lvi.SubItems[2].Text);
                    sd.Fiyat = Convert.ToDecimal(lvi.SubItems[3].Text);
                    sd.Indirim = Convert.ToDouble(lvi.SubItems[4].Text);
                    sonuc = sdOrm.Insert(sd);
                    if (sonuc == false)
                    {
                        MessageBox.Show("Satış kaydı oluşturulurken bir hata oluştu.");
                    }
                }
                if (sonuc)
                {
                    MessageBox.Show("Satış kaydı eklendi.");
                }
            }
        }
    }
}
