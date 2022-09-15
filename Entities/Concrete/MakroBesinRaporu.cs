using Entities.Abstract;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class MakroBesinRaporu : IMakroBesinRaporu, IBaseEntity
    {
        public int ID { get; set; }

        public int KaloriDegeri { get; set; }
        public int KarbonhidratDegeri { get; set; }
        public int ProteinDegeri { get; set; }
        public int YagDegeri { get; set; }

        public DateTime VerilisTarihi { get; set; }

        public List<Kullanici> Kullanicilar { get; set; }
        public List<BesinBilgileri> BesinBilgileri { get; set; }

       

        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string CreatedBy { get; set; }
        public string DeletedBy { get; set; }
        public string ModifiedBy { get; set; }
        public Status Status { get; set; } = Status.Active;
    }
}
