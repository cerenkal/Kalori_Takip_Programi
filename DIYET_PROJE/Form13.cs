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
    public partial class Form13 : Form
    {

        public static int tuketilenBesinID;
        public static int silinecekBesinID;
        public static float toplamKalori;
        public static float toplamCarb;
        public static float toplamYag;
        public static float toplamProtein;


        public static List<BesinBilgileri> tuketilenAperatifYemegiListesi;
        KaloriTakipDBContext _kaloriTakipDBContext;
        TuketilenBesinRepository _tuketilenBesinRepository;

        public Form13()
        {
            InitializeComponent();
            _kaloriTakipDBContext = new KaloriTakipDBContext();
            _tuketilenBesinRepository = new TuketilenBesinRepository(_kaloriTakipDBContext);
            tuketilenAperatifYemegiListesi = new List<BesinBilgileri>();
        }

        private void tstAperatifAra_MouseClick(object sender, MouseEventArgs e)
        {
            txtAperatifAra.Text = string.Empty;
        }

        private void btnAperatifAra_Click(object sender, EventArgs e)
        {
            dgvAperatifListe.DataSource = _kaloriTakipDBContext.BesinBilgileri.Where(x => x.BesinAdi.Contains(txtAperatifAra.Text)).Select(x => new { x.ID, x.BesinAdi, x.OlcuBirimi, x.Kalori, x.Karbonhidrat, x.Protein, x.Yag, x.GramKarsiligi, x.ToplamKalori }).ToList();


            dgvAperatifListe.Columns[0].Width = 30;
            dgvAperatifListe.Columns[2].Width = 130;
            dgvAperatifListe.Columns[2].Width = 60;
            dgvAperatifListe.Columns[3].Width = 60;
            dgvAperatifListe.Columns[4].Width = 50;
            dgvAperatifListe.Columns[5].Width = 40;
            dgvAperatifListe.Columns[6].Width = 40;
            dgvAperatifListe.Columns[7].Width = 40;
            dgvAperatifListe.Columns[8].Width = 40;
        }

        BesinBilgileri eklenen;
        private void dgvAperatifListe_SelectionChanged(object sender, EventArgs e)
        {
            tuketilenBesinID = Convert.ToInt32(dgvAperatifListe.CurrentRow.Cells[0].Value);
            eklenen = _kaloriTakipDBContext.BesinBilgileri.Where(x => x.ID == tuketilenBesinID).FirstOrDefault();

            lblAperatifOlcu.Text = eklenen.OlcuBirimi.ToString();
        }

        int gelenTuketilenBesinID = 0;
        private void btnAperatifEkleme_Click(object sender, EventArgs e)
        {
            bool sayiMi;
            int sayi;

            if (Fonksiyonlar.BosMu(this.Controls) == false)
            {
                do
                {
                    sayiMi = int.TryParse(txtAperatifMiktar.Text, out sayi);

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

                        tuketilenAperatifYemegiListesi.Add(eklenen);
                        dgvAperatifKullanicininListesi.DataSource = null;
                        dgvAperatifKullanicininListesi.DataSource = tuketilenAperatifYemegiListesi;

                        dgvAperatifKullanicininListesi.Columns[0].Visible = false;
                        dgvAperatifKullanicininListesi.Columns[1].Width = 120;


                        for (int i = 2; i < 16; i++)
                        {
                            dgvAperatifKullanicininListesi.Columns[i].Visible = false;
                        }

                        TuketilenBesin tb = new TuketilenBesin();
                        tb.Ogun = Ogun.Aperatif;
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

        private void btnAperatifSilme_Click(object sender, EventArgs e)
        {
            silinecekBesinID = Convert.ToInt32(dgvAperatifKullanicininListesi.CurrentRow.Cells[0].Value);
            silinen = _kaloriTakipDBContext.BesinBilgileri.Where(x => x.ID == silinecekBesinID).FirstOrDefault();

            foreach (var item in tuketilenAperatifYemegiListesi)
            {
                if (item.BesinAdi == silinen.BesinAdi)
                    isim = item.BesinAdi;
            }

            var yeni = _kaloriTakipDBContext.TuketilenBesinler.Where(x => x.BesinBilgileri.BesinAdi == isim).Select(x => x.ID).FirstOrDefault();
            var silinecek = _kaloriTakipDBContext.TuketilenBesinler.Where(x => x.ID == yeni).FirstOrDefault();

            silinecek.Ogun = Ogun.Aperatif;
            silinecek.BesinBilgileriID = silinecekBesinID;
            silinecek.KullaniciID = Form5.gelenID;
            silinecek.TuketilenTarih = DateTime.Today;
            silinecek.Status = Status.Deleted;
            _kaloriTakipDBContext.SaveChanges();

            tuketilenAperatifYemegiListesi.Remove(silinen);

            dgvAperatifKullanicininListesi.DataSource = null;
            dgvAperatifKullanicininListesi.DataSource = tuketilenAperatifYemegiListesi;

            dgvAperatifKullanicininListesi.Columns[0].Visible = false;
            dgvAperatifKullanicininListesi.Columns[1].Width = 120;


            for (int i = 2; i < 16; i++)
            {
                dgvAperatifKullanicininListesi.Columns[i].Visible = false;
            }

        }

        private void btnAperitifGeri_Click(object sender, EventArgs e)
        {
            foreach (var item in tuketilenAperatifYemegiListesi)
            {
                toplamKalori = item.Kalori * Convert.ToInt32(txtAperatifMiktar.Text);
                toplamCarb = item.Karbonhidrat * Convert.ToInt32(txtAperatifMiktar.Text);
                toplamProtein = item.Protein * Convert.ToInt32(txtAperatifMiktar.Text);
                toplamYag = item.Yag * Convert.ToInt32(txtAperatifMiktar.Text);
            }

            Form9 frm9 = new Form9();
            frm9.Show();
            this.Hide();
        }

    }
}
