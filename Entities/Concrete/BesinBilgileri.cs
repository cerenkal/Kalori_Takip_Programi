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
        public float BesinGramaji { get; set; }
        public int BesinAdeti { get; set; }




        public int BesinMakrolarID { get; set; }
        public BesinMakrolar BesinMakrolar { get; set; }
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
