using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyonu_ORM.Entity
{
    public class Urunler
    {
        public Urunler()
        {
            Aktif = true;
        }
        public int Id { get; set; }
        public string Adi { get; set; }
        public decimal Fiyat { get; set; }
        public double Miktar { get; set; }
        public int KategoriID { get; set; }
        public int BirimTipID { get; set; }
        public bool Aktif { get; set; }
    }
}
