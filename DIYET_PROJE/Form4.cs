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
            // textler boş geçilememe kontrolü
            if (Fonksiyonlar.BosMu(this.Controls) == false)
            {
               //kullanıcının mail adresine göre üye olup olmadığı kontrol ediliyor. Aynı mail adresiyle kayıt yapmaya izin verilmiyor
                Status gelen = _kaloriTakipDBContext.Kullanicilar.Where(x => x.Mail == txtEmailUyeOl.Text).Select(x => x.Status).FirstOrDefault();

                if (gelen == Status.Active)
                {
                    MessageBox.Show("Bu mail adresi sistemimize kayıtlıdır.");
                    Fonksiyonlar.Temizle(this.Controls);    
                }

              
                else
                {
                    //yeni kullanıcı kayıt alanı
                    yeniKullanici = new Kullanici();

                    yeniKullanici.KullaniciAdi = txtAdUyeOl.Text.Trim(); ;
                    yeniKullanici.KullaniciSoyadi = txtSoyadUyeOl.Text.Trim(); ;
                    yeniKullanici.KullaniciSifre = txtSifreUyeOl.Text.Trim(); ;
                    yeniKullanici.KullaniciSifreTekrari = txtSifreTekrar.Text.Trim(); ;
                    yeniKullanici.Mail = txtEmailUyeOl.Text.Trim(); 
                    yeniKullanici.ModifiedBy = txtEmailUyeOl.Text.Trim(); 
                    yeniKullanici.sifreBelirle(yeniKullanici.KullaniciSifre).Trim(); 

                    //şifrenin doğru olduğu durumunda çalışan kod
                    if (yeniKullanici.KullaniciSifre != String.Empty)
                    {
                        kullanici.Add(yeniKullanici);
                        Fonksiyonlar.Temizle(this.Controls);
                        _kaloriTakipDBContext.Kullanicilar.Add(yeniKullanici);
                        _kaloriTakipDBContext.SaveChanges();

                        frm5 = new Form5();
                        frm5.Show();
                        this.Hide();

                    }

                    //şifrenin hatalı olduğu durumda çalışan kod
                    else
                    {
                        MessageBox.Show("Lütfen belirtilen kriterlerde şifre girişi yapınız");
                        txtSifreUyeOl.Clear();
                        txtSifreTekrar.Clear();
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
    }
}
