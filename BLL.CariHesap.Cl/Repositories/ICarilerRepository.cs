using DAL.CariHesap.Cl.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.CariHesap.Cl.Repositories
{
   public interface ICarilerRepository
    {
        bool CariEkle(Cari k);
        bool CariGuncelle();
        bool CariSil(Cari k);
        bool CariSil(int ID);
        List<Cari> CariListele();
        List<Cari> CariListeleByCariTipi(string CariTipi);
        List<Cari> CariListeleByUnvan(string Unvan);


    }
}
