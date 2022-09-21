﻿using System;
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

      

        private void rjButton1_Click(object sender, EventArgs e)
        {
            float oy1, oy2, oy3;
            oy1 = Form9.toplamCarb;
            oy2 = Form9.toplamProtein;
            oy3 = Form9.toplamYag;

            //oy1 = 60;
            //oy2 = 90;
            //oy3 = 120;


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

            lblRaporKalori.Text = Form9.toplamKalori.ToString();
            lblRaporKarbonhidrat.Text =  Form9.toplamCarb.ToString();
            lblRaporProtein.Text =   Form9.toplamProtein.ToString();
            lblRaporYag.Text =  Form9.toplamYag.ToString();
        }

        private void btnRaporGeri_Click(object sender, EventArgs e)
        {
            Form8 frm8 = new Form8();
            frm8.Show();
            this.Hide();
        }
    }
}
