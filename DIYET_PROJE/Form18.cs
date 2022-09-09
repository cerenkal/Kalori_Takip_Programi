using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIYET_PROJE
{
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }

        private void rjButton4_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            double oy1, oy2, oy3;
            oy1 = 60;
            oy2 = 30;
            oy3 = 15;


            //Point leri temizleme.
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }

            //Grafiğe değer ekleme
            chart1.Series["Makro"].Points.Add(oy1);
            chart1.Series["Makro"].Points.Add(oy2);
            chart1.Series["Makro"].Points.Add(oy3);


            //x ekseninde öğrenci isimlerini belirleme
            chart1.Series["Makro"].Points[0].AxisLabel = "Karbonhidrat";
            chart1.Series["Makro"].Points[1].AxisLabel = "Protein";
            chart1.Series["Makro"].Points[2].AxisLabel = "Yag";



            //Sütun renklerini belirleme
            chart1.Series["Makro"].Points[0].Color = Color.SkyBlue;
            chart1.Series["Makro"].Points[1].Color = Color.LightCoral;
            chart1.Series["Makro"].Points[2].Color = Color.Violet;
        }
    }
}
