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
        private string kullaniciSifre;

        public int ID { get; set; }
        public string KullaniciAdi { get; set; }
        public string KullaniciSoyadi { get; set; }
        public string Mail { get; set; }
        public string KullaniciSifre
        {
            get => kullaniciSifre;
            set
            {
                int buyuk = 0;
                int kucuk = 0;
                int karakter = 0;

                char[] Dizi = kullaniciSifre.ToCharArray();

                if (Dizi.Length == 6)
                {
                    for (int i = 0; i < Dizi.Length; i++)
                    {

                        if (Dizi[i].ToString() == Dizi[i].ToString().ToUpper())
                            buyuk++;
                        if (Dizi[i].ToString() == Dizi[i].ToString().ToLower())
                            kucuk++;
                        if (Convert.ToInt32(Dizi[i]) >= 33 && Convert.ToInt32(Dizi[i]) <= 47)
                        {
                            karakter++;
                        }

                    }


                    if (buyuk >= 1 && kucuk >= 1 && karakter >= 1 && KullaniciSifreTekrari == value)
                        kullaniciSifre = value;
                    else kullaniciSifre = String.Empty;


                }

                else kullaniciSifre = String.Empty;
            }
        }
        public string KullaniciSifreTekrari { get; set; }

        public int KullniciHedefBilgileriID { get; set; }
        public KullniciHedefBilgileri KullniciHedefBilgileri { get; set; }

        public int AktiviteBilgileriID { get; set; }
        public AktiviteBilgileri AktiviteBilgileri { get; set; }



        public List<TuketilenBesin> TuketilenBesinler { get; set; }


        public int SuVerisiID { get; set; }
        public SuVerisi SuVerisi { get; set; }



        public List<EgzersizVerisi> Egzersizler { get; set; }

        public int VucutAnaliziID { get; set; }
        public VucutAnalizi VucutAnalizi { get; set; }


        public int MakroBesinRaporuID { get; set; }
        public MakroBesinRaporu MakroBesinRaporu { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string CreatedBy { get; set; }
        public string DeletedBy { get; set; }
        public string ModifiedBy { get; set; }
        public Status Status { get; set; } = Status.Active;
    }
}
