using DataAccess.ConcreteRepository;
using DataAccess.Context;
using Entities.Concrete;
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
    public partial class Form7 : Form
    {

        KaloriTakipDBContext kaloriTakipDBContext;
        AktiviteBilgileriRepository aktiviteBilgileriRepository;
        Form6 frm6;

        public static double hedef = 0;
        public Form7()
        {
            kaloriTakipDBContext = new KaloriTakipDBContext();
            aktiviteBilgileriRepository = new AktiviteBilgileriRepository(kaloriTakipDBContext);
            InitializeComponent();
        }

        private void btnPekHareketliDegil_Click(object sender, EventArgs e)
        {


            if (Form5.frm7sayac > 0)
            {
                int gelenAktiviteID = (int)kaloriTakipDBContext.Kullanicilar.Where(x => x.AktiviteBilgileriID != null && x.ID == Form5.gelenID).Select(x => x.AktiviteBilgileriID).FirstOrDefault();
                var degisenKisi = kaloriTakipDBContext.Kullanicilar.Where(x => x.AktiviteBilgileriID == gelenAktiviteID).FirstOrDefault();
                AktiviteBilgileri ab2 = new AktiviteBilgileri();
                ab2.Aktivite = Aktivite.Pek_Hareketli_Degil;
                ab2.AktiviteKatSayi = ab2.AktiviteKatsayisiHesapla(Aktivite.Pek_Hareketli_Degil);
                aktiviteBilgileriRepository.Add(ab2);
                degisenKisi.AktiviteBilgileriID = ab2.ID;
            }

            else
            {
                AktiviteBilgileri ab = new AktiviteBilgileri();
                var gelen = kaloriTakipDBContext.Kullanicilar.Where(x => x.ID == Form5.gelenID).FirstOrDefault();
                ab.Aktivite = Aktivite.Pek_Hareketli_Degil;
                ab.AktiviteKatSayi = ab.AktiviteKatsayisiHesapla(Aktivite.Pek_Hareketli_Degil);
                aktiviteBilgileriRepository.Add(ab);
                gelen.AktiviteBilgileriID = ab.ID;
                Form5.frm7sayac++;

            }



            kaloriTakipDBContext.SaveChanges();
            hedef = 1300 * 1.2;

            frm6 = new Form6();
            frm6.Show();
            this.Hide();

        }


        private void btnAzHareketli_Click(object sender, EventArgs e)
        {
            if (Form5.frm7sayac > 0)
            {
                int gelenAktiviteID = (int)kaloriTakipDBContext.Kullanicilar.Where(x => x.AktiviteBilgileriID != null && x.ID == Form5.gelenID).Select(x => x.AktiviteBilgileriID).FirstOrDefault();
                var degisenKisi = kaloriTakipDBContext.Kullanicilar.Where(x => x.AktiviteBilgileriID == gelenAktiviteID).FirstOrDefault();
                AktiviteBilgileri ab2 = new AktiviteBilgileri();
                ab2.Aktivite = Aktivite.Az_Hareketli;
                ab2.AktiviteKatSayi = ab2.AktiviteKatsayisiHesapla(Aktivite.Az_Hareketli);
                aktiviteBilgileriRepository.Add(ab2);
                degisenKisi.AktiviteBilgileriID = ab2.ID;
            }

            else
            {
                AktiviteBilgileri ab = new AktiviteBilgileri();
                var gelen = kaloriTakipDBContext.Kullanicilar.Where(x => x.ID == Form5.gelenID).FirstOrDefault();
                ab.Aktivite = Aktivite.Az_Hareketli;
                ab.AktiviteKatSayi = ab.AktiviteKatsayisiHesapla(Aktivite.Az_Hareketli);
                aktiviteBilgileriRepository.Add(ab);
                gelen.AktiviteBilgileriID = ab.ID;
                Form5.frm7sayac++;

            }


            kaloriTakipDBContext.SaveChanges();
            hedef = 1300 * 1.375;

            frm6 = new Form6();
            frm6.Show();
            this.Hide();

        }

        private void btnAktif_Click(object sender, EventArgs e)
        {
            if (Form5.frm7sayac>0)
            {
                int gelenAktiviteID = (int)kaloriTakipDBContext.Kullanicilar.Where(x => x.AktiviteBilgileriID != null && x.ID == Form5.gelenID).Select(x => x.AktiviteBilgileriID).FirstOrDefault();
                var degisenKisi = kaloriTakipDBContext.Kullanicilar.Where(x => x.AktiviteBilgileriID == gelenAktiviteID).FirstOrDefault();
                AktiviteBilgileri ab2 = new AktiviteBilgileri();
                ab2.Aktivite = Aktivite.Aktif;
                ab2.AktiviteKatSayi = ab2.AktiviteKatsayisiHesapla(Aktivite.Aktif);
                aktiviteBilgileriRepository.Add(ab2);
                degisenKisi.AktiviteBilgileriID = ab2.ID;
            }

            else
            {
                AktiviteBilgileri ab = new AktiviteBilgileri();
                var gelen = kaloriTakipDBContext.Kullanicilar.Where(x => x.ID == Form5.gelenID).FirstOrDefault();
                ab.Aktivite = Aktivite.Aktif;
                ab.AktiviteKatSayi = ab.AktiviteKatsayisiHesapla(Aktivite.Aktif);
                aktiviteBilgileriRepository.Add(ab);
                gelen.AktiviteBilgileriID = ab.ID;
                Form5.frm7sayac ++;
            }

            
            kaloriTakipDBContext.SaveChanges();
            hedef = 1300 * 1.55;

            frm6 = new Form6();
            frm6.Show();
            this.Hide();
            ;
        }

        private void btnCokHareketli_Click(object sender, EventArgs e)
        {

            if (Form5.frm7sayac > 0)
            {
                int gelenAktiviteID = (int)kaloriTakipDBContext.Kullanicilar.Where(x => x.AktiviteBilgileriID != null && x.ID == Form5.gelenID).Select(x => x.AktiviteBilgileriID).FirstOrDefault();
                var degisenKisi = kaloriTakipDBContext.Kullanicilar.Where(x => x.AktiviteBilgileriID == gelenAktiviteID).FirstOrDefault();
                AktiviteBilgileri ab2 = new AktiviteBilgileri();
                ab2.Aktivite = Aktivite.Cok_Hareketli;
                ab2.AktiviteKatSayi = ab2.AktiviteKatsayisiHesapla(Aktivite.Cok_Hareketli);
                aktiviteBilgileriRepository.Add(ab2);
                degisenKisi.AktiviteBilgileriID = ab2.ID;
                Form5.frm7sayac++;
            }

            else
            {
                AktiviteBilgileri ab = new AktiviteBilgileri();
                var gelen = kaloriTakipDBContext.Kullanicilar.Where(x => x.ID == Form5.gelenID).FirstOrDefault();
                ab.Aktivite = Aktivite.Cok_Hareketli;
                ab.AktiviteKatSayi = ab.AktiviteKatsayisiHesapla(Aktivite.Cok_Hareketli);
                aktiviteBilgileriRepository.Add(ab);
                gelen.AktiviteBilgileriID = ab.ID;

            }
           
            kaloriTakipDBContext.SaveChanges();
            hedef = 1300 * 1.9;

            frm6 = new Form6();
            frm6.Show();
            this.Hide();

        }
    }
}
