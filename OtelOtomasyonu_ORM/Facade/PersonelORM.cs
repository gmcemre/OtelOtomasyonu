using OtelOtomasyonu_ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyonu_ORM.Facade
{
    public class PersonelORM : ORMBase<Personeller>
    {
        public static Personeller AktifKullanici;
        public Personeller GirisYap(Personeller p)
        {
            SqlDataAdapter adp = new SqlDataAdapter("prc_Personeller_Giris", Tools.Connection);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@ka", p.KullaniciAdi);
            adp.SelectCommand.Parameters.AddWithValue("@prl", p.Parola);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            if (dt.Rows.Count == 0)
                return null;
            Personeller aktif = new Personeller();
            foreach (DataRow item in dt.Rows)
            {
                aktif.Id = (int)item["Id"];
                aktif.Adi = item["Adi"].ToString();
                aktif.Soyadi = item["Soyadi"].ToString();
                aktif.KullaniciAdi = item["KullaniciAdi"].ToString();
                aktif.Parola = item["Parola"].ToString();
            }
            return aktif;
        }
    }
}
