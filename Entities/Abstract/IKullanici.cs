using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public interface IKullanici
    {
        int ID { get; set; }
        string KullaniciAdi { get; set; }
        string KullaniciSoyadi { get; set; }
        string Mail { get; set; }
        string KullaniciSifre { get; set; }
        string KullaniciSifreTekrari { get; set; }

        int? KullniciHedefBilgileriID { get; set; }
        KullniciHedefBilgileri KullniciHedefBilgileri { get; set; }

        int? AktiviteBilgileriID { get; set; }
        AktiviteBilgileri AktiviteBilgileri { get; set; }


        List<TuketilenBesin> TuketilenBesinler { get; set; }

        int? SuVerisiID { get; set; }
        SuVerisi SuVerisi { get; set; }

        List<EgzersizVerisi> Egzersizler { get; set; }

        int? VucutAnaliziID { get; set; }
        VucutAnalizi VucutAnalizi { get; set; }

        int? MakroBesinRaporuID { get; set; }
        MakroBesinRaporu MakroBesinRaporu { get; set; }
    }
}
