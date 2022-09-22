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
        KaloriTakipDBContext _kaloriTakipDBContext;
        public static float toplamKalori;
        public static float toplamCarb;
        public static float toplamYag;
        public static float toplamProtein;
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
            //Kullanıcıların tükettiği besinlere göre kalori değerlerinin hesaplanması

            lblKaloriKahvalti.Text = Form10.toplamKalori.ToString();
            lblKarbonhidratKahvalti.Text = Form10.toplamCarb.ToString();
            lblProteinKahvalti.Text = Form10.toplamProtein.ToString();
            lblYagKahvalti.Text = Form10.toplamYag.ToString();

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

            toplamKalori = Form10.toplamKalori + Form11.toplamKalori + Form12.toplamKalori + Form13.toplamKalori;
            toplamCarb = (Form10.toplamCarb + Form11.toplamCarb + Form12.toplamCarb + Form13.toplamCarb);
            toplamYag = (Form10.toplamYag + Form11.toplamYag + Form12.toplamYag + Form13.toplamYag);
            toplamProtein = (Form10.toplamProtein + Form11.toplamProtein + Form12.toplamProtein + Form13.toplamProtein);

            int kl;

            int sonrakiGirisHedefi = Convert.ToInt32(Form5.sonrakiGirisHedefi);
            int toplam = sonrakiGirisHedefi + Form14.egzeriszToplamKalori;
            double kalori = Convert.ToDouble(lblAlinanKalori.Text);
            int hedefNet = Convert.ToInt32(Form6.hedefNet);
            

            //ilk giriş yaptığında hesaplanan hedef ve giriş yapan kullanıcı hedef değiştirdiğinde çalışan kod
            if (Form6.hedefNet > 0)
            {
                if ((int)kalori <= hedefNet + Form14.egzeriszToplamKalori)
                {
                    if (Form14.egzeriszToplamKalori > 0) kl = (int)Form6.hedefNet + Form14.egzeriszToplamKalori;
                    else kl = (int)Form6.hedefNet;

                    prbGunlukKaloriHedef.Minimum = 0;
                    prbGunlukKaloriHedef.Maximum = kl;

                    if (kalori > 0) prbGunlukKaloriHedef.Value = kl - (int)kalori;
                    else prbGunlukKaloriHedef.Value = kl;


                }
                else
                {

                    if (Form14.egzeriszToplamKalori > 0)
                    { kl = (int)Form6.hedefNet + Form14.egzeriszToplamKalori; }
                    else
                    {
                        kl = (int)Form6.hedefNet;
                        prbGunlukKaloriHedef.Minimum = 0;
                        prbGunlukKaloriHedef.Maximum = kl;
                        prbGunlukKaloriHedef.Value = 0;
                        prbGunlukKaloriHedef.BackColor = Color.Red;
                    
                    }

                }

            }

            else //eski kullanıcının tekrardan giriş yaptığında son seçtiği hedef ve aktiviteye göre günlük hedef kalorinin hesaplanması
            {

                if (kalori <= toplam)
                { 
                    if (Form14.egzeriszToplamKalori > 0) kl = (int)Form5.sonrakiGirisHedefi + Form14.egzeriszToplamKalori;
                    else kl = (int)Form5.sonrakiGirisHedefi;

                    prbGunlukKaloriHedef.Minimum = 0;
                    prbGunlukKaloriHedef.Maximum = kl;

                    if (kalori > 0) 
                        prbGunlukKaloriHedef.Value = kl - (int)kalori;
                    else prbGunlukKaloriHedef.Value = kl;


                }
                else
                {
                    if (Form14.egzeriszToplamKalori > 0) kl = (int)Form5.sonrakiGirisHedefi + Form14.egzeriszToplamKalori;
                    else kl = (int)Form5.sonrakiGirisHedefi;
                    prbGunlukKaloriHedef.Minimum = 0;
                    prbGunlukKaloriHedef.Maximum = kl;
                    prbGunlukKaloriHedef.Value = 0;
                    prbGunlukKaloriHedef.BackColor = Color.Red;


                }
            }

            lblHedef.Text = kl.ToString();

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

        private void btnOglenEkle_Click(object sender, EventArgs e)
        {
            Form11 frm11 = new Form11();
            frm11.Show();
            this.Hide();
        }

        private void btnAperatifEkle_Click(object sender, EventArgs e)
        {
            Form13 frm13 = new Form13();
            frm13.Show();
            this.Hide();
        }
    }
}
