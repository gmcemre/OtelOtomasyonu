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
    public partial class GirisYapForm : Form
    {
        public GirisYapForm()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            PersonelORM pOrm = new PersonelORM();
            Personeller p = new Personeller();
            p.KullaniciAdi = txtKullaniciAdi.Text;
            p.Parola = txtParola.Text;
            Personeller aktif = pOrm.GirisYap(p);
            if (aktif == null)
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
            }
            else
            {
                PersonelORM.AktifKullanici = aktif;
                Form1 f = new Form1();
                this.Hide();
                f.ShowDialog();
            }
        }
        private void GirisYapForm_Load(object sender, EventArgs e)
        {
            txtParola.PasswordChar = '*';
        }
    }
}
