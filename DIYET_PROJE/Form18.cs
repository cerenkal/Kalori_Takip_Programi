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
            foreach (var series in chartRapor.Series)
            {
                series.Points.Clear();
            }

            //Grafiğe değer ekleme
            chartRapor.Series["Makro"].Points.Add(oy1);
            chartRapor.Series["Makro"].Points.Add(oy2);
            chartRapor.Series["Makro"].Points.Add(oy3);


            //x ekseninde öğrenci isimlerini belirleme
            chartRapor.Series["Makro"].Points[0].AxisLabel = "Karbonhidrat";
            chartRapor.Series["Makro"].Points[1].AxisLabel = "Protein";
            chartRapor.Series["Makro"].Points[2].AxisLabel = "Yag";



            //Sütun renklerini belirleme
            chartRapor.Series["Makro"].Points[0].Color = Color.SkyBlue;
            chartRapor.Series["Makro"].Points[1].Color = Color.LightCoral;
            chartRapor.Series["Makro"].Points[2].Color = Color.Violet;
        }
    }
}
