using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.CariHesap.Context
{
    public class Urun
    {
        public int Id { get; set; }
        public string UrunAdi { get; set; }
        public int KategoriId { get; set; }
        public int Miktar { get; set; }
        public int KritikSeviye { get; set; }
        public decimal Fiyat { get; set; }
        public bool Silindi { get; set; }

        //Relations

    }
}
