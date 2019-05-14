using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.CariHesap.Context
{
    public class Kategori
    {
        public int Id { get; set; }
        public string KategoriAdi { get; set; }
        public string Aciklama { get; set; }
        public bool Silindi { get; set; }

        //Relations

    }
}
