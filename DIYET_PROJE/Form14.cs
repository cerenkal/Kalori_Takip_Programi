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
    public partial class Form14 : Form
    {
        KaloriTakipDBContext _kaloriTakipDBContext;
        EgzersizVerisiRepository egzersizVerisiRepository;
        public static int egzeriszToplamKalori;
        List<EgzersizVerisi> egzersizListe;
        public Form14()
        {
            InitializeComponent();
            _kaloriTakipDBContext = new KaloriTakipDBContext();
            egzersizVerisiRepository = new EgzersizVerisiRepository(_kaloriTakipDBContext);
            egzersizListe = new List<EgzersizVerisi>();
        }

        
        private void Form14_Load(object sender, EventArgs e)
        {
            dgvEgzersizListe.DataSource = _kaloriTakipDBContext.EgzersizVerileri.Select(x => new { x.ID, x.Egzersiz, x.KaloriDegeri }).ToList();

            dgvEgzersizListe.Columns[0].Width = 30;
            dgvEgzersizListe.Columns[1].Width = 200;
            dgvEgzersizListe.Columns[2].Width = 200;


        }

        int secilenID;
        EgzersizVerisi eklenecekEgzersiz;
        Egzersiz gelenEgzersizAdi;
       
        private void dgvEgzersizListe_SelectionChanged(object sender, EventArgs e)
        {
            secilenID = Convert.ToInt32(dgvEgzersizListe.CurrentRow.Cells[0].Value);
            eklenecekEgzersiz = _kaloriTakipDBContext.EgzersizVerileri.Where(x => x.ID == secilenID).FirstOrDefault();
            gelenEgzersizAdi = _kaloriTakipDBContext.EgzersizVerileri.Where(x => x.ID == secilenID).Select(x => x.Egzersiz).FirstOrDefault();
        }

        int miktar;
        private void btnEgzersizEkleme_Click(object sender, EventArgs e)
        {
            bool sayiMi;
            int sayi;



            if (Fonksiyonlar.BosMu(this.Controls) == false)
            {
                do
                {
                    sayiMi = int.TryParse(txtEgzersizMiktar.Text, out sayi);



                    if (!sayiMi)
                    {
                        MessageBox.Show("Lütfen sadece sayısal değerler giriniz");
                        sayiMi = true;
                    }



                    else if (sayi < 0)
                    {
                        MessageBox.Show("Lütfen sadece pozitif sayılar giriniz");
                        sayiMi = true;
                    }
                    else
                    {
                        miktar = Convert.ToInt32(txtEgzersizMiktar.Text);
                        egzersizListe.Add(eklenecekEgzersiz);
                        dgvEgzersizKullanicininListesi.DataSource = null;
                        dgvEgzersizKullanicininListesi.DataSource = egzersizListe;
                        dgvEgzersizKullanicininListesi.Columns[0].Visible = false;
                        dgvEgzersizKullanicininListesi.Columns[1].Width = 120;
                        for (int i = 2; i < 10; i++)
                            dgvEgzersizKullanicininListesi.Columns[i].Visible = false;

                    }



                } while (!sayiMi);



            }



            else MessageBox.Show("Lütfen egzersiz sürenizi giriniz");

        }

        int silinecekID;
        EgzersizVerisi silinecekEgzersiz;
        Egzersiz isim;

        private void btnEgzersizSilme_Click(object sender, EventArgs e)
        {
            silinecekID = Convert.ToInt32(dgvEgzersizKullanicininListesi.CurrentRow.Cells[0].Value);
            silinecekEgzersiz = _kaloriTakipDBContext.EgzersizVerileri.Where(x => x.ID == silinecekID).FirstOrDefault();

            foreach (var item in egzersizListe)
            {
                if (item.Egzersiz == silinecekEgzersiz.Egzersiz)
                    isim = item.Egzersiz;
            }



            egzersizListe.Remove(silinecekEgzersiz);
            dgvEgzersizKullanicininListesi.DataSource = null;
            dgvEgzersizKullanicininListesi.DataSource = egzersizListe;
            dgvEgzersizKullanicininListesi.Columns[0].Visible = false;
            dgvEgzersizKullanicininListesi.Columns[1].Width = 120;
            for (int i = 2; i < 10; i++)
                dgvEgzersizKullanicininListesi.Columns[i].Visible = false;
        }

        private void btnEgzersiGeri_Click(object sender, EventArgs e)
        {
            foreach (var item in egzersizListe)
            {
                egzeriszToplamKalori += item.KaloriDegeri * miktar;
            }

            Form9 frm9 = new Form9();
            frm9.Show();
            this.Hide();

        }
    }
}
