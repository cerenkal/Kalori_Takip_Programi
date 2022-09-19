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
        Form8 frm8;
        public Form7()
        {
            kaloriTakipDBContext = new KaloriTakipDBContext();
            aktiviteBilgileriRepository = new AktiviteBilgileriRepository(kaloriTakipDBContext);
            InitializeComponent();
        }

        private void btnPekHareketliDegil_Click(object sender, EventArgs e)
        {
            AktiviteBilgileri ab = new AktiviteBilgileri();
            var gelen = kaloriTakipDBContext.Kullanicilar.Where(x => x.ID == Form5.gelenID).FirstOrDefault();

            ab.Aktivite = Aktivite.Pek_Hareketli_Degil;
            ab.AktiviteKatSayi = ab.AktiviteKatsayisiHesapla(Aktivite.Pek_Hareketli_Degil);
            aktiviteBilgileriRepository.Add(ab);

            gelen.AktiviteBilgileriID = ab.ID;
            kaloriTakipDBContext.SaveChanges();

            frm8 = new Form8();
            frm8.Show();
            this.Hide();

        }


        private void btnAzHareketli_Click(object sender, EventArgs e)
        {
            AktiviteBilgileri ab = new AktiviteBilgileri();
            var gelen = kaloriTakipDBContext.Kullanicilar.Where(x => x.ID == Form5.gelenID).FirstOrDefault();

            ab.Aktivite = Aktivite.Az_Hareketli;
            ab.AktiviteKatSayi = ab.AktiviteKatsayisiHesapla(Aktivite.Az_Hareketli);
            aktiviteBilgileriRepository.Add(ab);

            gelen.AktiviteBilgileriID = ab.ID;
            kaloriTakipDBContext.SaveChanges();

            frm8 = new Form8();
            frm8.Show();
            this.Hide();
        }

        private void btnAktif_Click(object sender, EventArgs e)
        {
            AktiviteBilgileri ab = new AktiviteBilgileri();
            var gelen = kaloriTakipDBContext.Kullanicilar.Where(x => x.ID == Form5.gelenID).FirstOrDefault();

            ab.Aktivite = Aktivite.Aktif;
            ab.AktiviteKatSayi = ab.AktiviteKatsayisiHesapla(Aktivite.Aktif);
            aktiviteBilgileriRepository.Add(ab);

            gelen.AktiviteBilgileriID = ab.ID;
            kaloriTakipDBContext.SaveChanges();

            frm8 = new Form8();
            frm8.Show();
            this.Hide();
        }

        private void btnCokHareketli_Click(object sender, EventArgs e)
        {
            AktiviteBilgileri ab = new AktiviteBilgileri();
            var gelen = kaloriTakipDBContext.Kullanicilar.Where(x => x.ID == Form5.gelenID).FirstOrDefault();

            ab.Aktivite = Aktivite.Cok_Hareketli;
            ab.AktiviteKatSayi = ab.AktiviteKatsayisiHesapla(Aktivite.Cok_Hareketli);
            aktiviteBilgileriRepository.Add(ab);

            gelen.AktiviteBilgileriID = ab.ID;
            kaloriTakipDBContext.SaveChanges();

            frm8 = new Form8();
            frm8.Show();
            this.Hide();
        }
    }
}
