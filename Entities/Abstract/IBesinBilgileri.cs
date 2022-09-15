using Entities.Concrete;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public interface IBesinBilgileri
    {
        int ID { get; set; }
        string BesinAdi { get; set; }
         OlcuBirimi OlcuBirimi { get; set; }
        float GramKarsiligi { get; set; }

         float Kalori { get; set; }
         float Karbonhidrat { get; set; }
         float Protein { get; set; }
         float Yag { get; set; }

        List<MakroBesinRaporu> MakroBesinRaporlari { get; set; }
        List<TuketilenBesin> TuketilenBesinler { get; set; }
    }
}
