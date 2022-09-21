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
    public partial class Form11 : Form
    {


        public static int tuketilenBesinID;
        public static int silinecekBesinID;
        public static float toplamKalori;
        public static float toplamCarb;
        public static float toplamYag;
        public static float toplamProtein;


        public static List<BesinBilgileri> tuketilenOgkeYemegiListesi;
        KaloriTakipDBContext _kaloriTakipDBContext;
        TuketilenBesinRepository _tuketilenBesinRepository;

        public Form11()
        {
            InitializeComponent();
            _kaloriTakipDBContext = new KaloriTakipDBContext();
            tuketilenOgkeYemegiListesi = new List<BesinBilgileri>();
            _tuketilenBesinRepository = new TuketilenBesinRepository(_kaloriTakipDBContext);
        }

        
        private void txtArananUrunOgleYemegi_MouseClick(object sender, MouseEventArgs e)
        {
            txtArananUrunOgleYemegi.Text = string.Empty;
        }

        private void btnOgleAra_Click(object sender, EventArgs e)
        {
            dgvOgleYemegiListe.DataSource = _kaloriTakipDBContext.BesinBilgileri.Where(x => x.BesinAdi.Contains(txtArananUrunOgleYemegi.Text)).Select(x => new { x.ID, x.BesinAdi, x.OlcuBirimi, x.Kalori, x.Karbonhidrat, x.Protein, x.Yag, x.GramKarsiligi, x.ToplamKalori }).ToList();


            dgvOgleYemegiListe.Columns[0].Width = 30;
            dgvOgleYemegiListe.Columns[1].Width = 130;
            dgvOgleYemegiListe.Columns[2].Width = 60;
            dgvOgleYemegiListe.Columns[3].Width = 60;
            dgvOgleYemegiListe.Columns[4].Width = 50;
            dgvOgleYemegiListe.Columns[5].Width = 40;
            dgvOgleYemegiListe.Columns[6].Width = 40;
            dgvOgleYemegiListe.Columns[7].Width = 40;
            dgvOgleYemegiListe.Columns[8].Width = 40;
        }

        BesinBilgileri eklenen;
        private void dgvOgleYemegiListe_SelectionChanged(object sender, EventArgs e)
        {
            tuketilenBesinID = Convert.ToInt32(dgvOgleYemegiListe.CurrentRow.Cells[0].Value);
            eklenen = _kaloriTakipDBContext.BesinBilgileri.Where(x => x.ID == tuketilenBesinID).FirstOrDefault();

            lblOgleYemegiOlcu.Text = eklenen.OlcuBirimi.ToString();

        }

        int gelenTuketilenBesinID = 0;
        private void btnOgleYemegiEkle_Click(object sender, EventArgs e)
        {
            bool sayiMi;
            int sayi;

            if (Fonksiyonlar.BosMu(this.Controls) == false)
            {
                do
                {
                    sayiMi = int.TryParse(txtOgleMiktar.Text, out sayi);

                    if (!sayiMi)
                    {
                        MessageBox.Show("Lutfen sadece sayısal degerler giriniz");
                        sayiMi = true;
                    }

                    else if (sayi < 0)
                    {

                        MessageBox.Show("Lutfen sadece pozitif sayılar giriniz");
                        sayiMi = true;
                    }
                    else
                    {

                        tuketilenOgkeYemegiListesi.Add(eklenen);
                        dgvOgleYemegiKullaniciListesi.DataSource = null;
                        dgvOgleYemegiKullaniciListesi.DataSource = tuketilenOgkeYemegiListesi;

                        dgvOgleYemegiKullaniciListesi.Columns[0].Visible = false;
                        dgvOgleYemegiKullaniciListesi.Columns[1].Width = 120;


                        for (int i = 2; i < 16; i++)
                        {
                            dgvOgleYemegiKullaniciListesi.Columns[i].Visible = false;
                        }

                        TuketilenBesin tb = new TuketilenBesin();
                        tb.Ogun = Ogun.Ogle_Yemegi;
                        tb.BesinBilgileriID = tuketilenBesinID;
                        tb.KullaniciID = Form5.gelenID;
                        tb.TuketilenTarih = DateTime.Today;
                        _tuketilenBesinRepository.Add(tb);

                    }

                } while (!sayiMi);


            }

            else
            {
                MessageBox.Show("Lütfen secilen besin için miktar giriniz");
            }
        }

        BesinBilgileri silinen;
        string isim = string.Empty;

        private void btnOgleYemegiSilme_Click(object sender, EventArgs e)
        {
            silinecekBesinID = Convert.ToInt32(dgvOgleYemegiKullaniciListesi.CurrentRow.Cells[0].Value);
            silinen = _kaloriTakipDBContext.BesinBilgileri.Where(x => x.ID == silinecekBesinID).FirstOrDefault();

            foreach (var item in tuketilenOgkeYemegiListesi)
            {
                if (item.BesinAdi == silinen.BesinAdi)
                    isim = item.BesinAdi;
            }

            var yeni = _kaloriTakipDBContext.TuketilenBesinler.Where(x => x.BesinBilgileri.BesinAdi == isim).Select(x => x.ID).FirstOrDefault();
            var silinecek = _kaloriTakipDBContext.TuketilenBesinler.Where(x => x.ID == yeni).FirstOrDefault();

            silinecek.Ogun = Ogun.Ogle_Yemegi;
            silinecek.BesinBilgileriID = silinecekBesinID;
            silinecek.KullaniciID = Form5.gelenID;
            silinecek.TuketilenTarih = DateTime.Today;
            silinecek.Status = Status.Deleted;
            _kaloriTakipDBContext.SaveChanges();

            tuketilenOgkeYemegiListesi.Remove(silinen);

            dgvOgleYemegiKullaniciListesi.DataSource = null;
            dgvOgleYemegiKullaniciListesi.DataSource = tuketilenOgkeYemegiListesi;

            dgvOgleYemegiKullaniciListesi.Columns[0].Visible = false;
            dgvOgleYemegiKullaniciListesi.Columns[1].Width = 120;


            for (int i = 2; i < 16; i++)
            {
                dgvOgleYemegiKullaniciListesi.Columns[i].Visible = false;
            }
        }

        private void btnOgleYemegiGeri_Click(object sender, EventArgs e)
        {

            foreach (var item in tuketilenOgkeYemegiListesi)
            {
                toplamKalori = item.Kalori * Convert.ToInt32(txtOgleMiktar.Text);
                toplamCarb = item.Karbonhidrat * Convert.ToInt32(txtOgleMiktar.Text);
                toplamProtein = item.Protein * Convert.ToInt32(txtOgleMiktar.Text);
                toplamYag = item.Yag * Convert.ToInt32(txtOgleMiktar.Text);
            }

            Form9 frm9 = new Form9();
            frm9.Show();
            this.Hide();
        }

       
    }
}
