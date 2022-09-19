using DataAccess.ConcreteRepository;
using DataAccess.Context;
using Entities.Concrete;
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
    public partial class Form4 : Form
    {
        KaloriTakipDBContext _kaloriTakipDBContext;
        KullaniciRepository kullaniciRepository;

        public static Form5 frm5;
        public static List<Kullanici> kullanici;
        



        public static Kullanici yeniKullanici;
        public Form4()
        {
            InitializeComponent();
            kullanici = new List<Kullanici>();
            _kaloriTakipDBContext = new KaloriTakipDBContext();
            kullaniciRepository = new KullaniciRepository(_kaloriTakipDBContext);

        }



        private void btnUyeOlForm4_Click(object sender, EventArgs e)
        {

       
            if (Fonksiyonlar.BosMu(this.Controls) == false)
            {
                Status gelen = _kaloriTakipDBContext.Kullanicilar.Where(x => x.Mail == txtEmailUyeOl.Text).Select(x => x.Status).FirstOrDefault();

                if (gelen == Status.Active)
                {
                    MessageBox.Show("Bu mail adresi sistemimize kayıtlıdır.");
                    Fonksiyonlar.Temizle(this.Controls);    
                }

              
                else
                {
                    yeniKullanici = new Kullanici();

                    yeniKullanici.KullaniciAdi = txtAdUyeOl.Text.Trim(); ;
                    yeniKullanici.KullaniciSoyadi = txtSoyadUyeOl.Text.Trim(); ;
                    yeniKullanici.KullaniciSifre = txtSifreUyeOl.Text.Trim(); ;
                    yeniKullanici.KullaniciSifreTekrari = txtSifreTekrar.Text.Trim(); ;
                    yeniKullanici.Mail = txtEmailUyeOl.Text.Trim(); 
                    yeniKullanici.ModifiedBy = txtEmailUyeOl.Text.Trim(); 
                    yeniKullanici.sifreBelirle(yeniKullanici.KullaniciSifre).Trim(); 


                    if (yeniKullanici.KullaniciSifre != String.Empty)
                    {
                        kullanici.Add(yeniKullanici);
                        Fonksiyonlar.Temizle(this.Controls);
                        //_kaloriTakipDBContext.Kullanicilar.Add(yeniKullanici);
                        //_kaloriTakipDBContext.SaveChanges();

                        kullaniciRepository.Add(yeniKullanici);

                        frm5 = new Form5();
                        frm5.Show();
                        this.Hide();

                    }


                    else
                    {
                        MessageBox.Show("Lütfen belirtilen kriterlerde şifre girşi yaapınız");
                        Fonksiyonlar.Temizle(this.Controls);
                    }

                }

            }

            else MessageBox.Show("Üye Kayıt için gerekli olan bilgiler boş geçilemez");





        }

        private void btnGeriUyeOl_Click(object sender, EventArgs e)
        {
           Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
