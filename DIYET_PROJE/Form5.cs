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
        public static int frm7sayac = 0;
        public static int frm6sayac = 0;
        public Form5()
        {
            InitializeComponent();
            kaloriTakipDBContext = new KaloriTakipDBContext();
        }

        public static int gelenID;
        public static double sonrakiGirisHedefi = 0;

        private void btnGirisYapForm5_Click(object sender, EventArgs e)
        {
            if (Fonksiyonlar.BosMu(this.Controls) == false)
            {
                string ilk = kaloriTakipDBContext.Kullanicilar.Where(x => x.Mail == txtEmailGirisYap.Text.Trim() && x.KullaniciSifre == txtSifreGirisYap.Text.Trim()).Select(x => x.ModifiedBy).FirstOrDefault();

                //kullanıcının ilk girişi mi yoksa daha sonraki girişi mi kontrolü yapılır
                if (ilk == txtEmailGirisYap.Text)  
                {
                    //ilk giriş
                    gelenID = kaloriTakipDBContext.Kullanicilar.Where(x => x.Mail == txtEmailGirisYap.Text.Trim() && x.KullaniciSifre == txtSifreGirisYap.Text.Trim()).Select(x => x.ID).FirstOrDefault();

                    if (gelenID > 0)
                    {
                        var gelen = kaloriTakipDBContext.Kullanicilar.Where(x => x.Mail == txtEmailGirisYap.Text.Trim() && x.KullaniciSifre == txtSifreGirisYap.Text.Trim()).FirstOrDefault();

                        gelen.ModifiedBy = "eski kullanıcı"; kaloriTakipDBContext.SaveChanges();

                        Form7 frm7 = new Form7(); 
                        frm7.Show(); 
                        this.Hide();

                    }

                    else
                    {
                        MessageBox.Show("Kullanıcı adı veya şifreniz hatalı lütfen tekrar giriniz");
                        Fonksiyonlar.Temizle(this.Controls);
                    }

                }

                else
                {
                    //eski kullanıcı
                    gelenID = kaloriTakipDBContext.Kullanicilar.Where(x => x.Mail == txtEmailGirisYap.Text && x.KullaniciSifre == txtSifreGirisYap.Text).Select(x => x.ID).FirstOrDefault();

                    if (gelenID > 0)
                    {
                        //eski kullanıcının günlük kalori hedefi hesaplanıyor
                        int gelen = (int)kaloriTakipDBContext.Kullanicilar.Where(x => x.AktiviteBilgileriID != null && x.ID == Form5.gelenID).Select(x => x.AktiviteBilgileriID).FirstOrDefault();

                        Aktivite aktivite = kaloriTakipDBContext.AktiviteBilgileri.Where(x => x.ID == gelen).Select(x => x.Aktivite).FirstOrDefault();

                        if (aktivite == Aktivite.Pek_Hareketli_Degil) sonrakiGirisHedefi = 1300 * 1.2;

                        else if (aktivite == Aktivite.Az_Hareketli) sonrakiGirisHedefi = 1300 * 1.375;

                        else if (aktivite == Aktivite.Aktif) sonrakiGirisHedefi = 1300 * 1.55;

                        else if (aktivite == Aktivite.Cok_Hareketli) sonrakiGirisHedefi = 1300 * 1.9;

                        int gelen2 = (int)kaloriTakipDBContext.Kullanicilar.Where(x => x.KullniciHedefBilgileriID != null && x.ID == Form5.gelenID).Select(x => x.KullniciHedefBilgileriID).FirstOrDefault();

                        Hedef hedef = kaloriTakipDBContext.KullaniciHedefBilgileri.Where(x => x.ID == gelen).Select(x => x.Hedef).FirstOrDefault();

                        if (hedef == Hedef.Kilo_Almak) sonrakiGirisHedefi += 200;


                        else if (hedef == Hedef.Kilo_Vermek) sonrakiGirisHedefi -= 200;

                        Form8 frm8 = new Form8(); 
                        frm8.Show(); this.Hide();

                    }

                    else
                    {
                        MessageBox.Show("Kullanıcı adı veya şifreniz hatalı lütfen tekrar giriniz");

                        Fonksiyonlar.Temizle(this.Controls);

                    }
                }
            }

            else MessageBox.Show("Giriş yapmak için lütfen gerekli bilgileri giriniz");


        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }


    }
}
