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
    public partial class Form10 : Form
    {

        public static int tuketilenBesinID;
        public static int silinecekBesinID;
        public static float toplamKalori;
        public static float toplamCarb;
        public static float toplamYag;
        public static float toplamProtein;


        public static List<BesinBilgileri> tuketilenkkahvaltıListesi;
        KaloriTakipDBContext _kaloriTakipDBContext;
        TuketilenBesinRepository _tuketilenBesinRepository;
      

        public Form10()
        {
            InitializeComponent();
            _kaloriTakipDBContext = new KaloriTakipDBContext();
            _tuketilenBesinRepository = new TuketilenBesinRepository(_kaloriTakipDBContext);
            tuketilenkkahvaltıListesi = new List<BesinBilgileri>();
        }

        private void txtKahvalti_MouseClick(object sender, MouseEventArgs e)
        {
            txtKahvalti.Text = String.Empty;
        }

        private void btnKahvaltiAra_Click(object sender, EventArgs e)
        {
            dgvKahvaltiListe.DataSource = _kaloriTakipDBContext.BesinBilgileri.Where(x => x.BesinAdi.Contains(txtKahvalti.Text)).Select(x => new { x.ID, x.BesinAdi, x.OlcuBirimi, x.Kalori, x.Karbonhidrat, x.Protein, x.Yag, x.GramKarsiligi, x.ToplamKalori }).ToList();

            dgvKahvaltiListe.Columns[0].Width = 30;
            dgvKahvaltiListe.Columns[1].Width = 130;
            dgvKahvaltiListe.Columns[2].Width = 60;
            dgvKahvaltiListe.Columns[3].Width = 60;
            dgvKahvaltiListe.Columns[4].Width = 50;
            dgvKahvaltiListe.Columns[5].Width = 40;
            dgvKahvaltiListe.Columns[6].Width = 40;
            dgvKahvaltiListe.Columns[7].Width = 40;
            dgvKahvaltiListe.Columns[8].Width = 40; ;
        }

        BesinBilgileri eklenen;

        private void dgvKahvaltiListe_SelectionChanged(object sender, EventArgs e)
        {
            tuketilenBesinID = Convert.ToInt32(dgvKahvaltiListe.CurrentRow.Cells[0].Value);
            eklenen = _kaloriTakipDBContext.BesinBilgileri.Where(x => x.ID == tuketilenBesinID).FirstOrDefault();

            lblKahvaltıOlcu.Text = eklenen.OlcuBirimi.ToString();

        }

        int gelenTuketilenBesinID = 0;

        private void btnEkleKahvalti_Click(object sender, EventArgs e)
        {
            bool sayiMi;
            int sayi;

            if (Fonksiyonlar.BosMu(this.Controls) == false)
            {
                do
                {
                    sayiMi = int.TryParse(txtKahvaltiMiktar.Text, out sayi);

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

                        tuketilenkkahvaltıListesi.Add(eklenen);
                        dgvKahvaltiKullaniciListesi.DataSource = null;
                        dgvKahvaltiKullaniciListesi.DataSource = tuketilenkkahvaltıListesi;

                        dgvKahvaltiKullaniciListesi.Columns[0].Visible = false;
                        dgvKahvaltiKullaniciListesi.Columns[1].Width = 120;

                        for (int i = 2; i < 16; i++)
                        { dgvKahvaltiKullaniciListesi.Columns[i].Visible = false; }
                           

                        TuketilenBesin tb = new TuketilenBesin();
                        tb.Ogun = Ogun.Kahvalti;
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


        private void btnSilKahvalti_Click(object sender, EventArgs e)
        {
            silinecekBesinID = Convert.ToInt32(dgvKahvaltiKullaniciListesi.CurrentRow.Cells[0].Value);
            silinen = _kaloriTakipDBContext.BesinBilgileri.Where(x => x.ID == silinecekBesinID).FirstOrDefault();

            foreach (var item in tuketilenkkahvaltıListesi)
            {
                if (item.BesinAdi == silinen.BesinAdi)
                    isim = item.BesinAdi;
            }

            var yeni = _kaloriTakipDBContext.TuketilenBesinler.Where(x => x.BesinBilgileri.BesinAdi == isim).Select(x => x.ID).FirstOrDefault();
            var silinecek = _kaloriTakipDBContext.TuketilenBesinler.Where(x => x.ID == yeni).FirstOrDefault();

            silinecek.Ogun = Ogun.Kahvalti;
            silinecek.BesinBilgileriID = silinecekBesinID;
            silinecek.KullaniciID = Form5.gelenID;
            silinecek.TuketilenTarih = DateTime.Today;
            silinecek.Status = Status.Deleted;
            _kaloriTakipDBContext.SaveChanges();

            tuketilenkkahvaltıListesi.Remove(silinen);

            dgvKahvaltiKullaniciListesi.DataSource = null;
            dgvKahvaltiKullaniciListesi.DataSource = tuketilenkkahvaltıListesi;

            dgvKahvaltiKullaniciListesi.Columns[0].Visible = false;
            dgvKahvaltiKullaniciListesi.Columns[1].Width = 120;


            for (int i = 2; i < 16; i++)
            {
                dgvKahvaltiKullaniciListesi.Columns[i].Visible = false;
            }

        }

        private void btnGeriKahvaltiEkle_Click(object sender, EventArgs e)
        {
            foreach (var item in tuketilenkkahvaltıListesi)
            {
                toplamKalori = item.Kalori * Convert.ToInt32(txtKahvaltiMiktar.Text);
                toplamCarb = item.Karbonhidrat * Convert.ToInt32(txtKahvaltiMiktar.Text);
                toplamProtein = item.Protein * Convert.ToInt32(txtKahvaltiMiktar.Text);
                toplamYag = item.Yag * Convert.ToInt32(txtKahvaltiMiktar.Text);
            }

            Form9 frm9 = new Form9();
            frm9.Show();
            this.Hide();
        }

        
    }
}
