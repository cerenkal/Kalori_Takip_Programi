using Entities.Concrete;
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
        float BesinGramaji { get; set; }
        int BesinAdeti { get; set; }

        int BesinMakrolarID { get; set; }
        BesinMakrolar BesinMakrolar { get; set; }
        List<TuketilenBesin> TuketilenBesinler { get; set; }
    }
}
