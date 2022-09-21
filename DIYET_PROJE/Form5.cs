using DataAccess.ConcreteRepository;
using DataAccess.Context;
using Entities.Enums;
using Entities.Fonksiyonlar;
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
    public partial class Form5 : Form
    {


        private KaloriTakipDBContext kaloriTakipDBContext;
        public static Form7 frm7;
        public static Form8 frm8;
        public static int frm7sayac = 0;
        public static int frm6sayac = 0;
        public Form5()
        {
            InitializeComponent();
            kaloriTakipDBContext = new KaloriTakipDBContext();

        }

        public static int gelenID;

        private void btnGirisYapForm5_Click(object sender, EventArgs e)
        {
            if (Fonksiyonlar.BosMu(this.Controls) == false)
            {

                string ilk = kaloriTakipDBContext.Kullanicilar.Where(x => x.Mail == txtEmailGirisYap.Text.Trim() && x.KullaniciSifre == txtSifreGirisYap.Text.Trim()).Select(x => x.ModifiedBy).FirstOrDefault();

                if (ilk == txtEmailGirisYap.Text)
                {
                    gelenID = kaloriTakipDBContext.Kullanicilar.Where(x => x.Mail == txtEmailGirisYap.Text.Trim() && x.KullaniciSifre == txtSifreGirisYap.Text.Trim()).Select(x => x.ID).FirstOrDefault();

                    if (gelenID > 0)
                    {
                        var gelen = kaloriTakipDBContext.Kullanicilar.Where(x => x.Mail == txtEmailGirisYap.Text.Trim() && x.KullaniciSifre == txtSifreGirisYap.Text.Trim()).FirstOrDefault();

                        gelen.ModifiedBy = "eski kullanıcı";
                        kaloriTakipDBContext.SaveChanges();

                        frm7 = new Form7();
                        frm7.Show();
                        this.Hide();

                    }

                    else
                    {
                        MessageBox.Show("Kullanıcı adı veya sifreniz hatalı lütfen tekrar giriniz");

                        Fonksiyonlar.Temizle(this.Controls);

                    }


                }


                else
                {
                    gelenID = kaloriTakipDBContext.Kullanicilar.Where(x => x.Mail == txtEmailGirisYap.Text && x.KullaniciSifre == txtSifreGirisYap.Text).Select(x => x.ID).FirstOrDefault();


                    if (gelenID > 0)
                    {
                        int gelen = (int)kaloriTakipDBContext.Kullanicilar.Where(x => x.AktiviteBilgileriID != null && x.ID == Form5.gelenID).Select(x => x.AktiviteBilgileriID).FirstOrDefault();

                        Aktivite aktivite = kaloriTakipDBContext.AktiviteBilgileri.Where(x => x.ID == gelen).Select(x => x.Aktivite).FirstOrDefault();


                        if (aktivite == Aktivite.Pek_Hareketli_Degil) Form7.hedef = 1300 * 1.2;

                        else if (aktivite == Aktivite.Az_Hareketli) Form7.hedef = 1300 * 1.375;

                        else if (aktivite == Aktivite.Aktif) Form7.hedef = 1300 * 1.55;

                        else if (aktivite == Aktivite.Cok_Hareketli) Form7.hedef = 1300 * 1.9;


                        int gelen2 = (int)kaloriTakipDBContext.Kullanicilar.Where(x => x.KullniciHedefBilgileriID != null && x.ID == Form5.gelenID).Select(x => x.KullniciHedefBilgileriID).FirstOrDefault();

                        Hedef hedef = kaloriTakipDBContext.KullaniciHedefBilgileri.Where(x => x.ID == gelen).Select(x => x.Hedef).FirstOrDefault();

                        if (hedef== Hedef.Kilo_Almak) Form7.hedef = Form7.hedef + 200;

                        else if (hedef == Hedef.Kilo_Korumak) Form7.hedef = Form7.hedef + 0;

                        else if (hedef == Hedef.Kilo_Vermek) Form7.hedef = Form7.hedef - 200;


                        frm8 = new Form8();
                        frm8.Show();
                        this.Hide();

                    }

                    else
                    {
                        MessageBox.Show("Kullanıcı adı veya sifreniz hatalı lütfen tekrar giriniz");

                        Fonksiyonlar.Temizle(this.Controls);

                    }
                }
            }

            else MessageBox.Show("Giriş yapmak için lütfen gerekli bilgileri giriniz");
        }



        Form2 frm2;
        private void rjButton4_Click(object sender, EventArgs e)
        {
            frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }


    }
}
