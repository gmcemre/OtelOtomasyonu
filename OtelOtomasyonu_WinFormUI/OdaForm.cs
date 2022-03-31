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
    public partial class OdaForm : Form
    {
        public OdaForm()
        {
            InitializeComponent();
        }
        OdaORM oOrm = new OdaORM();
        private void OdaForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = oOrm.Select();
            OdaTurORM otOrm = new OdaTurORM();
            cmbOdaTuru.DisplayMember = "Adi";
            cmbOdaTuru.ValueMember = "Id";
            cmbOdaTuru.DataSource = otOrm.Select();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Odalar oda = new Odalar();
            oda.Adi = txtOdaAdi.Text;
            oda.Aciklama = txtAciklama.Text;
            oda.OdaTurID = Convert.ToInt32(cmbOdaTuru.SelectedValue);
            bool sonuc = oOrm.Insert(oda);
            if (sonuc)
            {
                MessageBox.Show("Oda Eklendi.");
                dataGridView1.DataSource = oOrm.Select();
            }
            else
            {
                MessageBox.Show("Oda eklenirken bir hata oluştu.");
            }
            txtOdaAdi.Clear();
            txtAciklama.Clear();
        }
    }
}
