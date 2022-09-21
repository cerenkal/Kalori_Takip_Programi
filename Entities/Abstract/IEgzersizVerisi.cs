using Entities.Concrete;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public interface IEgzersizVerisi
    {
        int ID { get; set; }

        Egzersiz Egzersiz { get; set; }

        int KaloriDegeri { get; set; }
        int? KullaniciID { get; set; }
        Kullanici Kullanici { get; set; }
    }
}
