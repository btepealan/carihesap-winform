using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.CariHesap.Context
{
    public class UrunHareket
    {
        public int Id { get; set; }
        public DateTime Tarih { get; set; }
        public string IslemTuru { get; set; }
        public int UrunId { get; set; }
        public string Belge { get; set; }
        public string Birim { get; set; }
        public int Adet { get; set; }
        public decimal BirimFiyat { get; set; }
        public decimal Tutar { get; set; }
        public bool Silindi { get; set; }

        //Relations


    }
}
