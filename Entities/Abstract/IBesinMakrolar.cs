using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public interface IBesinMakrolar
    {
        int ID { get; set; }
        float Kalori { get; set; }
        float Karbonhidrat { get; set; }
        float Protein { get; set; }
        float Yag { get; set; }


        int BesinBilgileriID { get; set; }
        BesinBilgileri BesinBilgileri { get; set; }

        List<MakroBesinRaporu> MakroBesinRaporlari { get; set; }
    }
}
