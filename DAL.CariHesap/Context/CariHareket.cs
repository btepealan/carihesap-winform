using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.CariHesap.Context
{
    public class CariHareket
    {
        public int Id { get; set; }
        public string IslemTuru { get; set; }
        public DateTime Tarih { get; set; }
        public int CariId { get; set; }
        public string Belge { get; set; }
        public decimal Borc { get; set; }
        public decimal Alacak { get; set; }
        public int UrunHareketId { get; set; }
        public int KasaHareketId { get; set; }
        public bool Silindi { get; set; }

        //Relations

    }
}
