using Entities.Abstract;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class AktiviteBilgileri : IBaseEntity, IAktiviteBilgileri
    {
        public int ID { get; set; }

        public float AktiviteKatSayi { get; set; }

        public Aktivite Aktivite { get; set; }
      

        public List<Kullanici> Kullanicilar { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string CreatedBy { get; set; }
        public string DeletedBy { get; set; }
        public string ModifiedBy { get; set; }
        public Status Status { get; set; } = Status.Active;
      

        public float AktiviteKatsayisiHesapla(Aktivite aktivite)
        {
            float katSayi = 0;
            switch (aktivite)
            {
                case Aktivite.Pek_Hareketli_Degil:
                    katSayi = 0.9F;
                    break;
                case Aktivite.Az_Hareketli:
                    katSayi = 1.1F;
                    break;
                case Aktivite.Aktif:
                    katSayi = 1.4F;
                    break;
                case Aktivite.Cok_Hareketli:
                    katSayi = 1.6F;
                    break;
                default:
                    break;
            }

            return katSayi;
        }
    }
}
