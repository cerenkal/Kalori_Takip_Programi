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
    public partial class Form12 : Form
    {
        public static int tuketilenBesinID;
        public static int silinecekBesinID;
        public static float toplamKalori;
        public static float toplamCarb;
        public static float toplamYag;
        public static float toplamProtein;


        public static List<BesinBilgileri> tuketilenAksamYemegiListesi;
        KaloriTakipDBContext _kaloriTakipDBContext;
        TuketilenBesinRepository _tuketilenBesinRepository;

        public Form12()
        {
            InitializeComponent();
            _kaloriTakipDBContext = new KaloriTakipDBContext();
            _tuketilenBesinRepository = new TuketilenBesinRepository(_kaloriTakipDBContext);
            tuketilenAksamYemegiListesi = new List<BesinBilgileri>();

        }

      
        private void txtArananUrunAksamYemegi_MouseClick(object sender, MouseEventArgs e)
        {
            txtArananUrunAksamYemegi.Text = string.Empty;
        }

        private void btnAksamAra_Click(object sender, EventArgs e)
        {
            dgvAksamListe.DataSource = _kaloriTakipDBContext.BesinBilgileri.Where(x => x.BesinAdi.Contains(txtArananUrunAksamYemegi.Text)).Select(x => new { x.ID, x.BesinAdi, x.OlcuBirimi, x.Kalori, x.Karbonhidrat, x.Protein, x.Yag, x.GramKarsiligi, x.ToplamKalori }).ToList();


            dgvAksamListe.Columns[0].Width = 30;
            dgvAksamListe.Columns[2].Width = 130;
            dgvAksamListe.Columns[2].Width = 60;
            dgvAksamListe.Columns[3].Width = 60;
            dgvAksamListe.Columns[4].Width = 50;
            dgvAksamListe.Columns[5].Width = 40;
            dgvAksamListe.Columns[6].Width = 40;
            dgvAksamListe.Columns[7].Width = 40;
            dgvAksamListe.Columns[8].Width = 40;
        }

        BesinBilgileri eklenen;
        private void dgvAksamListe_SelectionChanged(object sender, EventArgs e)
        {
            tuketilenBesinID = Convert.ToInt32(dgvAksamListe.CurrentRow.Cells[0].Value);
            eklenen = _kaloriTakipDBContext.BesinBilgileri.Where(x => x.ID == tuketilenBesinID).FirstOrDefault();

            lblOlcu.Text = eklenen.OlcuBirimi.ToString();
        }

        private void btnEklemeAksamYemegi_Click(object sender, EventArgs e)
        {
            bool sayiMi;
            int sayi;

            if (Fonksiyonlar.BosMu(this.Controls) == false)
            {
                do
                {
                    sayiMi = int.TryParse(txtAksamMiktar.Text, out sayi);

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

                        tuketilenAksamYemegiListesi.Add(eklenen);
                        dgvAksamKullanicininListesi.DataSource = null;
                        dgvAksamKullanicininListesi.DataSource = tuketilenAksamYemegiListesi;

                        dgvAksamKullanicininListesi.Columns[0].Visible = false;
                        dgvAksamKullanicininListesi.Columns[1].Width = 120;


                        for (int i = 2; i < 16; i++)
                        {
                            dgvAksamKullanicininListesi.Columns[i].Visible = false;
                        }

                        TuketilenBesin tb = new TuketilenBesin();
                        tb.Ogun = Ogun.Aksam_Yemegi;
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

        private void btnSilmeAksamYemegi_Click(object sender, EventArgs e)
        {
            silinecekBesinID = Convert.ToInt32(dgvAksamKullanicininListesi.CurrentRow.Cells[0].Value);
            silinen = _kaloriTakipDBContext.BesinBilgileri.Where(x => x.ID == silinecekBesinID).FirstOrDefault();

            foreach (var item in tuketilenAksamYemegiListesi)
            {
                if (item.BesinAdi == silinen.BesinAdi)
                    isim = item.BesinAdi;
            }

            var yeni = _kaloriTakipDBContext.TuketilenBesinler.Where(x => x.BesinBilgileri.BesinAdi == isim).Select(x => x.ID).FirstOrDefault();
            var silinecek = _kaloriTakipDBContext.TuketilenBesinler.Where(x => x.ID == yeni).FirstOrDefault();

            silinecek.Ogun = Ogun.Aksam_Yemegi;
            silinecek.BesinBilgileriID = silinecekBesinID;
            silinecek.KullaniciID = Form5.gelenID;
            silinecek.TuketilenTarih = DateTime.Today;
            silinecek.Status = Status.Deleted;
            _kaloriTakipDBContext.SaveChanges();

            tuketilenAksamYemegiListesi.Remove(silinen);

            dgvAksamKullanicininListesi.DataSource = null;
            dgvAksamKullanicininListesi.DataSource = tuketilenAksamYemegiListesi;

            dgvAksamKullanicininListesi.Columns[0].Visible = false;
            dgvAksamKullanicininListesi.Columns[1].Width = 120;


            for (int i = 2; i < 16; i++)
            {
                dgvAksamKullanicininListesi.Columns[i].Visible = false;
            }

        }

        private void btnGeriAksamYemegi_Click(object sender, EventArgs e)
        {
            foreach (var item in tuketilenAksamYemegiListesi)
            {
                toplamKalori += item.Kalori * Convert.ToInt32(txtAksamMiktar.Text);
                toplamCarb += item.Karbonhidrat * Convert.ToInt32(txtAksamMiktar.Text);
                toplamProtein += item.Protein * Convert.ToInt32(txtAksamMiktar.Text);
                toplamYag += item.Yag * Convert.ToInt32(txtAksamMiktar.Text);
            }

            Form9 frm9 = new Form9();
            frm9.Show();
            this.Hide();
        }
    }
}
