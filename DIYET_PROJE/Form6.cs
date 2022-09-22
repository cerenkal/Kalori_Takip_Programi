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
    public partial class Form6 : Form
    {
        KaloriTakipDBContext kaloriTakipDBContext;
        KullaniciHedefBilgileriRepository kullaniciHedefBilgileriRepository;
        public static double hedefNet=0;

        public Form6()
        {
            InitializeComponent();
            kaloriTakipDBContext = new KaloriTakipDBContext();
            kullaniciHedefBilgileriRepository = new KullaniciHedefBilgileriRepository(kaloriTakipDBContext);
        }

        public static int gelenHedefID;
        private void btnKiloAlmakIstıyorum_Click(object sender, EventArgs e)
        {
            //sayacın 0 büyük olma durumunda eski kullanıcı hedefini değiştiriyor, else durumunda kayıt esnasında hedef belirleniyor
            if (Form5.frm6sayac > 0)
            {
                int gelenHedefID = (int)kaloriTakipDBContext.Kullanicilar.Where(x => x.KullniciHedefBilgileriID != null && x.ID == Form5.gelenID).Select(x => x.KullniciHedefBilgileriID).FirstOrDefault();
                var degisenKisi = kaloriTakipDBContext.Kullanicilar.Where(x => x.KullniciHedefBilgileriID == gelenHedefID).FirstOrDefault();
                KullniciHedefBilgileri kh2 = new KullniciHedefBilgileri();
                kh2.Hedef = Hedef.Kilo_Almak;
                kh2.HedefKatSayi = kh2.KatSayiDon(Hedef.Kilo_Almak);
                kullaniciHedefBilgileriRepository.Add(kh2);
                degisenKisi.KullniciHedefBilgileriID = kh2.ID;
            }


            else
            {
                KullniciHedefBilgileri kh = new KullniciHedefBilgileri();
                var gelen = kaloriTakipDBContext.Kullanicilar.Where(x => x.ID == Form5.gelenID).FirstOrDefault();
                kh.Hedef = Hedef.Kilo_Almak;
                kh.HedefKatSayi = kh.KatSayiDon(Hedef.Kilo_Almak);
                kullaniciHedefBilgileriRepository.Add(kh);
                gelen.KullniciHedefBilgileriID = kh.ID;
                gelenHedefID = kh.ID;
                Form5.frm6sayac++;
            }

            kaloriTakipDBContext.SaveChanges();
            hedefNet = Form7.hedef + 200;

            Form8 frm8 = new Form8();
            frm8.Show();
            this.Hide();

        }

        private void btnKilomuKorumakIstiyorum_Click(object sender, EventArgs e)
        {
            if (Form5.frm6sayac > 0)
            {
                int gelenHedefID = (int)kaloriTakipDBContext.Kullanicilar.Where(x => x.KullniciHedefBilgileriID != null && x.ID == Form5.gelenID).Select(x => x.KullniciHedefBilgileriID).FirstOrDefault();
                var degisenKisi = kaloriTakipDBContext.Kullanicilar.Where(x => x.KullniciHedefBilgileriID == gelenHedefID).FirstOrDefault();
                KullniciHedefBilgileri kh2 = new KullniciHedefBilgileri();
                kh2.Hedef = Hedef.Kilo_Korumak;
                kh2.HedefKatSayi = kh2.KatSayiDon(Hedef.Kilo_Korumak);
                kullaniciHedefBilgileriRepository.Add(kh2);
                degisenKisi.KullniciHedefBilgileriID = kh2.ID;
            }



            else
            {
                KullniciHedefBilgileri kh = new KullniciHedefBilgileri();
                var gelen = kaloriTakipDBContext.Kullanicilar.Where(x => x.ID == Form5.gelenID).FirstOrDefault();
                kh.Hedef = Hedef.Kilo_Korumak;
                kh.HedefKatSayi = kh.KatSayiDon(Hedef.Kilo_Korumak);
                kullaniciHedefBilgileriRepository.Add(kh);
                gelen.KullniciHedefBilgileriID = kh.ID;
                gelenHedefID = kh.ID;
                Form5.frm6sayac++;
            }


            hedefNet = Form7.hedef + 0;
            kaloriTakipDBContext.SaveChanges();

            Form8 frm8 = new Form8();
            frm8.Show();
            this.Hide();

        }

        private void btnKiloVermekIstiyorum_Click(object sender, EventArgs e)
        {
            if (Form5.frm6sayac > 0)
            {
                int gelenHedefID = (int)kaloriTakipDBContext.Kullanicilar.Where(x => x.KullniciHedefBilgileriID != null && x.ID == Form5.gelenID).Select(x => x.KullniciHedefBilgileriID).FirstOrDefault();
                var degisenKisi = kaloriTakipDBContext.Kullanicilar.Where(x => x.KullniciHedefBilgileriID == gelenHedefID).FirstOrDefault();
                KullniciHedefBilgileri kh2 = new KullniciHedefBilgileri();
                kh2.Hedef = Hedef.Kilo_Vermek;
                kh2.HedefKatSayi = kh2.KatSayiDon(Hedef.Kilo_Vermek);
                kullaniciHedefBilgileriRepository.Add(kh2);
                degisenKisi.KullniciHedefBilgileriID = kh2.ID;
            }


            else
            {
                KullniciHedefBilgileri kh = new KullniciHedefBilgileri();
                var gelen = kaloriTakipDBContext.Kullanicilar.Where(x => x.ID == Form5.gelenID).FirstOrDefault();
                kh.Hedef = Hedef.Kilo_Vermek;
                kh.HedefKatSayi = kh.KatSayiDon(Hedef.Kilo_Vermek);
                kullaniciHedefBilgileriRepository.Add(kh);
                gelen.KullniciHedefBilgileriID = kh.ID;
                gelenHedefID = kh.ID;
                Form5.frm6sayac++;
            }

            kaloriTakipDBContext.SaveChanges();
            hedefNet = Form7.hedef - 200;

            Form8 frm8 = new Form8();
            frm8.Show();
            this.Hide();
        }
    }
}
