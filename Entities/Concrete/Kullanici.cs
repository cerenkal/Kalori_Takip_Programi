using Entities.Abstract;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Kullanici : IKullanici, IBaseEntity
    {
     

        public int ID { get; set; }
        public string KullaniciAdi { get; set; }
        public string KullaniciSoyadi { get; set; }
        public string Mail { get; set; }
        public string KullaniciSifre { get; set; }
        public string KullaniciSifreTekrari { get; set; }

        public virtual int? KullniciHedefBilgileriID { get; set; }
        public KullniciHedefBilgileri KullniciHedefBilgileri { get; set; }

        public virtual int? AktiviteBilgileriID { get; set; }
        public AktiviteBilgileri AktiviteBilgileri { get; set; }



        public List<TuketilenBesin> TuketilenBesinler { get; set; }


        public virtual int? SuVerisiID { get; set; }
        public SuVerisi SuVerisi { get; set; }



        public List<EgzersizVerisi> Egzersizler { get; set; }

        public virtual int? VucutAnaliziID { get; set; }
        public VucutAnalizi VucutAnalizi { get; set; }


        public virtual int? MakroBesinRaporuID { get; set; }
        public MakroBesinRaporu MakroBesinRaporu { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string CreatedBy { get; set; }
        public string DeletedBy { get; set; }
        public string ModifiedBy { get; set; }
        public Status Status { get; set; } = Status.Active;
     

        public string sifreBelirle(string sifre)
        {
            

            int buyuk = 0;
            int kucuk = 0;
            int karakter = 0;

            char[] Dizi = sifre.ToCharArray();

            if (Dizi.Length == 6)
            {
                for (int i = 0; i < Dizi.Length; i++)
                {
                    if (64<Dizi[i] && Dizi[i]<91)
                    {
                        buyuk++;
                    }
                    if (96 < Dizi[i] && Dizi[i] < 123)
                    {
                        kucuk++;
                    }

                    if (32 < Dizi[i] && Dizi[i] < 48)
                    {
                        karakter++;
                    }



                }


                if (buyuk >= 1 && kucuk >= 1 && karakter >= 1 && KullaniciSifreTekrari == sifre)
                {
                    KullaniciSifre = sifre;
                    return KullaniciSifre;
                }


                else
                {
                    KullaniciSifre = String.Empty;
                    return KullaniciSifre;

                }


            }

            else
            {
                KullaniciSifre = String.Empty;
                return KullaniciSifre;

            }


        }
    }
}
