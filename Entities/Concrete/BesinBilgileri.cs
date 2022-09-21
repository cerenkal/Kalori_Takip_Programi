using Entities.Abstract;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class BesinBilgileri : IBesinBilgileri, IBaseEntity
    {
        public int ID { get; set; }
        public string BesinAdi { get; set; }
        public OlcuBirimi OlcuBirimi { get; set; }
        public float GramKarsiligi { get; set; }
        public float Kalori { get; set; }
        public float Karbonhidrat { get; set; }
        public float Protein { get; set; }
        public float Yag { get; set; }
        public float ToplamKalori { get; set; }

        public List<MakroBesinRaporu> MakroBesinRaporlari { get; set; }
        public List<TuketilenBesin> TuketilenBesinler { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string CreatedBy { get; set; }
        public string DeletedBy { get; set; }
        public string ModifiedBy { get; set; }
        public Status Status { get; set; } = Status.Active;
        
    }
}
