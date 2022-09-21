using DataAccess.Context;
using Entities.Enums;
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
    public partial class Form9 : Form
    {
        public static Form9 frm9;
        KaloriTakipDBContext _kaloriTakipDBContext;
        public Form9()
        {
            InitializeComponent();

            _kaloriTakipDBContext = new KaloriTakipDBContext();
        }


        private void btnAksamEkle_Click(object sender, EventArgs e)
        {
            Form12 frm12 = new Form12();
            frm12.Show();
            this.Hide();

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            lblKaloriKahvalti.Text = Form10.toplamKalori.ToString();
            lblKarbonhidratKahvalti.Text = Form10.toplamCarb.ToString();
            lblProteinKahvalti.Text = Form10.toplamProtein.ToString();
            lblYagOglen.Text = Form10.toplamKalori.ToString();

            lblKaloriOglen.Text = Form11.toplamKalori.ToString();
            lblKarbonhidratOglen.Text = Form11.toplamCarb.ToString();
            lblProteinOglen.Text = Form11.toplamProtein.ToString();
            lblYagOglen.Text = Form11.toplamYag.ToString();

            lblKaloriAksam.Text = Form12.toplamKalori.ToString();
            lblKarbonhidratAksam.Text = Form12.toplamCarb.ToString();
            lblProteinAksam.Text = Form12.toplamProtein.ToString();
            lblYagAksam.Text = Form12.toplamYag.ToString();

            lblKaloriAperatif.Text = Form13.toplamKalori.ToString();
            lblKarbonhidratAperatif.Text = Form13.toplamCarb.ToString();
            lblProteinAperatif.Text = Form13.toplamProtein.ToString();
            lblYagAperatif.Text = Form13.toplamProtein.ToString();


            lblEgzersizKalori.Text = Form14.egzeriszToplamKalori.ToString();

            lblAlinanKalori.Text = (Form10.toplamKalori + Form11.toplamKalori + Form12.toplamKalori + Form13.toplamKalori).ToString();
            lblYakilanKalori.Text = Form14.egzeriszToplamKalori.ToString();


            var kl = 0;

            if (Form14.egzeriszToplamKalori>0)
            {
                kl = (int)Form7.hedef + Form14.egzeriszToplamKalori;
            }

            else
            {
                kl = (int)Form7.hedef;
            }
       

            lblHedef.Text = kl.ToString();

           
            prbGunlukKaloriHedef.Minimum = 0;
            prbGunlukKaloriHedef.Maximum = kl;

            if (Convert.ToInt32(lblAlinanKalori.Text)>0)
            {
              
                prbGunlukKaloriHedef.Value = kl - Convert.ToInt32(lblAlinanKalori.Text);


            }
            else
            {
              
                prbGunlukKaloriHedef.Value = kl;
            }
       
              


        }

        private void btnEgzersizEkle_Click(object sender, EventArgs e)
        {
            Form14 frm14 = new Form14();
            frm14.Show();
            this.Hide();

        }

        private void btnKahvaltiEkle_Click(object sender, EventArgs e)
        {
            Form10 frm10 = new Form10();
            frm10.Show();
            this.Hide();
        }

        private void btnGeriOgunEkle_Click(object sender, EventArgs e)
        {
            Form8 frm8 = new Form8();
            frm8.Show();
            this.Hide();
        }
    }
}
