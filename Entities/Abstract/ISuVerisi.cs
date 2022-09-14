using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public interface ISuVerisi
    {
        int ID { get; set; }

        float SuMiktari { get; set; }

        DateTime TuketilenTarih { get; set; }
    }
}
