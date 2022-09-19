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
        KullaniciRepository kullaniciRepository;
        Form7 frm7;
        public Form6()
        {
            InitializeComponent();
            kaloriTakipDBContext = new KaloriTakipDBContext();
            kullaniciHedefBilgileriRepository = new KullaniciHedefBilgileriRepository(kaloriTakipDBContext);
            kullaniciRepository = new KullaniciRepository(kaloriTakipDBContext);
        }


        private void btnKiloAlmakIstıyorum_Click(object sender, EventArgs e)
        {
            KullniciHedefBilgileri kh = new KullniciHedefBilgileri();

            var gelen = kaloriTakipDBContext.Kullanicilar.Where(x => x.ID == Form5.gelenID).FirstOrDefault();

            kh.Hedef = Hedef.Kilo_Almak;
            kh.HedefKatSayi = kh.KatSayiDon(Hedef.Kilo_Almak);             
            kullaniciHedefBilgileriRepository.Add(kh);
            gelen.KullniciHedefBilgileriID = kh.ID;

            kaloriTakipDBContext.SaveChanges();

            frm7 = new Form7();
            frm7.Show();
            this.Hide();


        }

        private void btnKilomuKorumakIstiyorum_Click(object sender, EventArgs e)
        {
            KullniciHedefBilgileri kh = new KullniciHedefBilgileri();

            var gelen = kaloriTakipDBContext.Kullanicilar.Where(x => x.ID == Form5.gelenID).FirstOrDefault();

            kh.Hedef = Hedef.Kilo_Korumak;
            kh.HedefKatSayi = kh.KatSayiDon(Hedef.Kilo_Korumak);
            kullaniciHedefBilgileriRepository.Add(kh);
            gelen.KullniciHedefBilgileriID = kh.ID;

            kaloriTakipDBContext.SaveChanges();

            frm7 = new Form7();
            frm7.Show();
            this.Hide();
        }

        private void btnKiloVermekIstiyorum_Click(object sender, EventArgs e)
        {
            KullniciHedefBilgileri kh = new KullniciHedefBilgileri();

            var gelen = kaloriTakipDBContext.Kullanicilar.Where(x => x.ID == Form5.gelenID).FirstOrDefault();

            kh.Hedef = Hedef.Kilo_Vermek;
            kh.HedefKatSayi = kh.KatSayiDon(Hedef.Kilo_Vermek);
            kullaniciHedefBilgileriRepository.Add(kh);
            gelen.KullniciHedefBilgileriID = kh.ID;

            kaloriTakipDBContext.SaveChanges();

            frm7 = new Form7();
            frm7.Show();
            this.Hide();
        }
    }
}
