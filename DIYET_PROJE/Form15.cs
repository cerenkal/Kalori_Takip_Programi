using DataAccess.Context;
using Entities.Concrete;
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
    public partial class Form15 : Form
    {
        KaloriTakipDBContext _kaloriTakipDBContext;
        int secilenID;
        List<BesinBilgileri> secilenBesin;

        public Form15()
        {
            InitializeComponent();
            _kaloriTakipDBContext = new KaloriTakipDBContext();
            secilenBesin = new List<BesinBilgileri>();
        }

        private void txtKacKoleriBesinGİr_MouseClick(object sender, MouseEventArgs e)
        {
            txtKacKoleriBesinGİr.Text = string.Empty;
        }

        private void btnKacKolariBesinAra_Click(object sender, EventArgs e)
        {
            dgvKacKolariBesinListele.DataSource = _kaloriTakipDBContext.BesinBilgileri.Where(x => x.BesinAdi.Contains(txtKacKoleriBesinGİr.Text)).Select(x => new { x.ID, x.BesinAdi, x.OlcuBirimi, x.Kalori, x.Karbonhidrat, x.Protein, x.Yag, x.GramKarsiligi, x.ToplamKalori }).ToList();
        }

        private void dgvKacKolariBesinListele_SelectionChanged(object sender, EventArgs e)
        {
            secilenID = Convert.ToInt32(dgvKacKolariBesinListele.CurrentRow.Cells[0].Value);
            secilenBesin = _kaloriTakipDBContext.BesinBilgileri.Where(x => x.ID == secilenID).ToList();
            foreach (var item in secilenBesin)
            {
                lblKacKaloriOlcu.Text = item.OlcuBirimi.ToString();
            }

        }

        private void btnIncele_Click(object sender, EventArgs e)
        {
            bool sayiMi;
            int sayi;


            if (Fonksiyonlar.BosMu(this.Controls) == false)
            {

                do
                {
                    sayiMi = int.TryParse(txtKacKolariMiktar.Text, out sayi);

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
                        int miktar = Convert.ToInt32(txtKacKolariMiktar.Text);

                        foreach (var item in secilenBesin)
                        {
                            lblKalori.Text = (item.Kalori * miktar).ToString();
                            lblKarbonhidrat.Text = (item.Karbonhidrat * miktar).ToString();
                            lblProtein.Text = (item.Protein * miktar).ToString();
                            lblYag.Text = (item.Yag * miktar).ToString();
                        }
                    }

                } while (!sayiMi);
            }

           
        }

        private void Form15_Load(object sender, EventArgs e)
        {

        }
    }
}
