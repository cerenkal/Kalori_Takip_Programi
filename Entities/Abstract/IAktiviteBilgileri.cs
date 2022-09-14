using Entities.Concrete;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public interface IAktiviteBilgileri
    {
        int ID { get; set; }
        Aktivite Aktivite { get; set; }

        float AktiviteKatSayi { get; set; }

        List<Kullanici> Kullanicilar { get; set; }
    }
}
