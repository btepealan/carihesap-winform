using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.CariHesap.Context
{
    public class Cari
    {
        public int Id { get; set; }
        public string CariTipi { get; set; }
        public string Unvan { get; set; }
        public string Yetkili { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public string Sehir { get; set; }
        public string VergiNo { get; set; }
        public string VergiDairesi { get; set; }
        public decimal ToplamBorc { get; set; }
        public decimal ToplamAlacak { get; set; }
        public decimal Bakiye { get; set; }
        public bool Silindi { get; set; }

        //Relations

    }
}
