using Entities.Abstract;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class EgzersizVerisi : IEgzersizVerisi, IBaseEntity
    {
        private int kaloriDegeri;

        public int ID { get; set; }
        public Egzersiz Egzersiz { get; set; }
        public int Suresi { get; set; }
        public int KaloriDegeri
        {
            get => kaloriDegeri;
            set
            {
                kaloriDegeri = KaloriDegeriHesapla(Suresi, Egzersiz);
            }

        }
        public List<Kullanici> Kullanicilar { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string CreatedBy { get; set; }
        public string DeletedBy { get; set; }
        public string ModifiedBy { get; set; }
        public Status Status { get; set; } = Status.Active;


        public int KaloriDegeriHesapla(int sure, Egzersiz egzersiz)
        {
            int Kalori = 0;



            switch (egzersiz)
            {
                case Egzersiz.GucAntremani:
                    Kalori = 5 * sure;
                    break;
                case Egzersiz.Yuruyus:
                    Kalori = 4 * sure;
                    break;
                case Egzersiz.BisikleteBinme:
                    Kalori = 3 * sure;
                    break;
                case Egzersiz.Kosu:
                    Kalori = 6 * sure;
                    break;
                case Egzersiz.KondisyonBisikleti:
                    Kalori = 4 * sure;
                    break;
                case Egzersiz.Yoga:
                    Kalori = 2 * sure;
                    break;
                case Egzersiz.Yuzme:
                    Kalori = 5 * sure;
                    break;
                case Egzersiz.Boks:
                    Kalori = 6 * sure;
                    break;
                case Egzersiz.DaireselAntreman:
                    Kalori = 4 * sure;
                    break;
                case Egzersiz.DansEtmek:
                    Kalori = 6 * sure;
                    break;
                case Egzersiz.EvdeYapilanEgzersiz:
                    Kalori = 3 * sure;
                    break;
                case Egzersiz.FonskiyonelAntreman:
                    Kalori = 8 * sure;
                    break;
                case Egzersiz.Futbol:
                    Kalori = 6 * sure;
                    break;
                case Egzersiz.KickBoks:
                    Kalori = 4 * sure;
                    break;
                case Egzersiz.Kurek:
                    Kalori = 2 * sure;
                    break;
                case Egzersiz.Voleybol:
                    Kalori = 2 * sure;
                    break;
                case Egzersiz.Basketbol:
                    Kalori = 5 * sure;
                    break;
                case Egzersiz.Jimnastik:
                    Kalori = 3 * sure;
                    break;
                case Egzersiz.Zumba:
                    Kalori = 5 * sure;
                    break;


            }


            return Kalori;
        }
    }
}
