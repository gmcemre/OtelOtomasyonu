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
    public partial class BirimTipForm : Form
    {
        public BirimTipForm()
        {
            InitializeComponent();
        }

        BirimTipORM btOrm = new BirimTipORM();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            BirimTipleri bt = new BirimTipleri();
            bt.Adi = txtBirimTipAdi.Text;
            bool sonuc = btOrm.Insert(bt);
            if (sonuc)
            {
                MessageBox.Show("Birim Tip Eklendi.");
                dataGridView1.DataSource = btOrm.Select();
            }
            else
            {
                MessageBox.Show("Birim Tip Eklenirken Bir Hata Oluştu.");
            }
            txtBirimTipAdi.Clear();
        }

        private void BirimTipForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = btOrm.Select();
        }
    }
}
