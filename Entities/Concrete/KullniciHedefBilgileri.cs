using Entities.Abstract;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class KullniciHedefBilgileri : IKullaniciHedefBilgileri, IBaseEntity

    {
       

        public int ID { get; set; }
        public Hedef Hedef { get; set; }

        public float HedefKatSayi { get; set; }


        public List<Kullanici> Kullanicilar { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string CreatedBy { get; set; }
        public string DeletedBy { get; set; }
        public string ModifiedBy { get; set; }
        public Status Status { get; set; } = Status.Active;
     

        public float KatSayiDon(Hedef hedef)
        {
            float katSayi = 0;

            switch (hedef)
            {
                case Hedef.Kilo_Almak:
                    katSayi = 200;
                    break;
                case Hedef.Kilo_Vermek:
                    katSayi = -200;
                    break;
                case Hedef.Kilo_Korumak:
                    katSayi = 0;
                    break;

            }

            return katSayi;
        }
    }
}
