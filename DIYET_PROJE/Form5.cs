using DataAccess.ConcreteRepository;
using DataAccess.Context;
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
        public static Form6 frm6;
        public static Form8 frm8;
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

                    MessageBox.Show(gelenID.ToString());

                    if (gelenID > 0)
                    {
                        var gelen = kaloriTakipDBContext.Kullanicilar.Where(x => x.Mail == txtEmailGirisYap.Text.Trim() && x.KullaniciSifre == txtSifreGirisYap.Text.Trim()).FirstOrDefault();

                        gelen.ModifiedBy = "eski kullanıcı";
                        kaloriTakipDBContext.SaveChanges();

                        frm6 = new Form6();
                        frm6.Show();
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
            frm2= new Form2();
            frm2.Show();
            this.Hide();
        }

      
    }
}
