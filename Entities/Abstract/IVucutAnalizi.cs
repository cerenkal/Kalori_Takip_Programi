using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public interface IVucutAnalizi
    {
        int ID { get; set; }

        float VKI { get; set; }
        float VYO { get; set; }
        float BMH { get; set; }

        List<Kullanici> Kullanicilar { get; set; }
    }
}
