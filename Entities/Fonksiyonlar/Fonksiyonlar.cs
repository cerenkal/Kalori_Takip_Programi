using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entities.Fonksiyonlar
{
    public class Fonksiyonlar
    {

        public static void Temizle(Control.ControlCollection koleksiyon) 
        {
            foreach (var item in koleksiyon)
            {

                if (item is TextBox)
                {
                    (item as TextBox).Clear();
                }
            }
        }

        public static bool BosMu(Control.ControlCollection koleksiyon)
        {
            foreach (var item in koleksiyon)
            {

                if (item is TextBox)
                {
                    if ((item as TextBox).Text == string.Empty || (item as TextBox).Text == null)
                    {
                        return true;
                    }
                }


            }

            return false;
        }


    }
}
