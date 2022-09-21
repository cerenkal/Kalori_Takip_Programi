using Entities.Concrete;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public interface ITuketilenBesin
    {
        int ID { get; set; }

        int? KullaniciID { get; set; }
        Kullanici Kullanici { get; set; }

        int? BesinBilgileriID { get; set; }
        BesinBilgileri BesinBilgileri { get; set; }

        Ogun Ogun { get; set; }
        DateTime TuketilenTarih { get; set; }
    }
}
