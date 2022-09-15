using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public interface IMakroBesinRaporu
    {
        int ID { get; set; }

        int KaloriDegeri { get; set; }
        int KarbonhidratDegeri { get; set; }
        int ProteinDegeri { get; set; }
        int YagDegeri { get; set; }
        DateTime VerilisTarihi { get; set; }

        List<Kullanici> Kullanicilar { get; set; }

         List<BesinBilgileri> BesinBilgileri { get; set; }

    }
}
