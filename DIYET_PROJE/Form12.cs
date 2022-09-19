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
    public partial class Form12 : Form
    {
        KaloriTakipDBContext _kaloriTakipDBContext;
        public static int tuketilenBesinID;
        public static int silinecekBesinID;
        public static float toplamKalori;
        public static float toplamCarb;
        public static float toplamYag;
        public static float toplamProtein;
        
        public static List<BesinBilgileri> tuketilenBesinListesi;
        public static List<Kullanici> Kullanicilar;
        public static List<Listeleme> Liste;
        public Form12()
        {
            InitializeComponent();
            _kaloriTakipDBContext = new KaloriTakipDBContext();
            tuketilenBesinListesi = new List<BesinBilgileri>();
            Kullanicilar = new List<Kullanici>();
            Liste = new List<Listeleme>();
        }

        private void txtArananUrunAksamYemegi_MouseClick(object sender, MouseEventArgs e)
        {
            txtArananUrunAksamYemegi.Text = String.Empty;
        }

        private void btnAksamAra_Click(object sender, EventArgs e)
        {

            dgvAksamListe.DataSource = _kaloriTakipDBContext.BesinBilgileri.Where(x => x.BesinAdi.Contains(txtArananUrunAksamYemegi.Text)).Select(x => new { x.ID, x.BesinAdi, x.OlcuBirimi, x.Kalori, x.Karbonhidrat, x.Protein, x.Yag, x.GramKarsiligi,x.ToplamKalori  }).ToList();

            dgvAksamListe.Columns[1].Width = 60;
            dgvAksamListe.Columns[2].Width = 40;
            dgvAksamListe.Columns[3].Width = 80;
            dgvAksamListe.Columns[4].Width = 50;
            dgvAksamListe.Columns[5].Width = 40;

        }



        private void dgvAksamListe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tuketilenBesinID = Convert.ToInt32(dgvAksamListe.CurrentRow.Cells[0].Value);

            var eklenecekBesin = _kaloriTakipDBContext.BesinBilgileri.Where(x => x.ID == tuketilenBesinID).FirstOrDefault();
            lblOlcu.Text = eklenecekBesin.OlcuBirimi.ToString();
            tuketilenBesinListesi.Add(eklenecekBesin);


        }

      

        private void btnEklemeAksamYemegi_Click(object sender, EventArgs e)
        {
            //dgvAksamKullanicininListesi.DataSource = null;
            //dgvAksamKullanicininListesi.Columns[0].Name = "Besin Adı";
            //dgvAksamKullanicininListesi.Columns[0].Width = 80;
            //dgvAksamKullanicininListesi.Columns[1].Name = "Toplam Kalori";
            //dgvAksamKullanicininListesi.Columns[1].Width = 50;

            //int miktar = Convert.ToInt32(txtAksamMiktar.Text);
            //int sayi = tuketilenBesinListesi.Count;


            //Liste.Clear();
            //Random rnd = new Random();

            //for (int i = 0; i < sayi; i++)
            //{
            //    Listeleme yeni = new Listeleme() { ToplamKalori = rnd.Next(1, 100), BesinAdi = rnd.Next(1, 100).ToString() };
            //    Liste.Add(yeni);
            //}

            //MessageBox.Show(sayi.ToString());


            //foreach (var item1 in tuketilenBesinListesi)
            //{
            //    foreach (var item in Liste)
            //    {

            //        if (sayi!=0)
            //        {
            //            item.BesinAdi = item1.BesinAdi;
            //            item.ToplamKalori = item1.Kalori * miktar;
            //            sayi--;
                      
            //        }
                    
                   
            //    }
            //}

            dgvAksamKullanicininListesi.DataSource = null;
            dgvAksamKullanicininListesi.DataSource = tuketilenBesinListesi;


            TuketilenBesin tb = new TuketilenBesin();
            tb.Ogun = Ogun.Aksam_Yemegi;
            tb.BesinBilgileri = tuketilenBesinListesi;
            //tb.Kullanicilar = Kullanicilar;

            _kaloriTakipDBContext.SaveChanges();

        }

        private void btnSilmeAksamYemegi_Click(object sender, EventArgs e)
        {
            tuketilenBesinListesi.Remove(silinecekBesin);
            MessageBox.Show(tuketilenBesinListesi.Count.ToString()) ;
            dgvAksamKullanicininListesi.DataSource = null;
            dgvAksamKullanicininListesi.DataSource = tuketilenBesinListesi;
        }

      public  BesinBilgileri silinecekBesin;

        private void dgvAksamKullanicininListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            silinecekBesinID = Convert.ToInt32(dgvAksamKullanicininListesi.CurrentRow.Cells[0].Value);
             silinecekBesin = _kaloriTakipDBContext.BesinBilgileri.Where(x => x.ID == silinecekBesinID).FirstOrDefault();
          


        }

        private void btnGeriAksamYemegi_Click(object sender, EventArgs e)
        {
            foreach (var item in tuketilenBesinListesi)
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
