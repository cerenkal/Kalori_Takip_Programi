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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        Form16 frm16;
        private void btnAnasayfaSuTakibi_Click(object sender, EventArgs e)
        {
            frm16 = new Form16();
            frm16.Show();
            this.Hide();
        }

        Form3 frm3;
        private void btnAnasayfaVucutAnalizi_Click(object sender, EventArgs e)
        {

            frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }

        private void btnAnasayfaKaloriTakibi_Click(object sender, EventArgs e)
        {
            Form9 frm9 = new Form9();
            frm9.Show();
            this.Hide();

        }

        Form9 frm9 = new Form9();

        private void btnAnasayfaHedefler_Click(object sender, EventArgs e)
        {
            Fonksiyonlar.TemizleLable(frm9.Controls);
            Form7 frm7 = new Form7();
            frm7.Show();
            this.Hide();
        }

        private void btnAnasayfaKacKalori_Click(object sender, EventArgs e)
        {
            Form15 frm15 = new Form15();
            frm15.Show();
            this.Hide();
        }

        private void btnAnasayfaRaporlar_Click(object sender, EventArgs e)
        {
            Form18 frm18 = new Form18();
            frm18.Show();
            this.Hide();
        }

        private void btnAnasayfaPratikTariflerVeEgzersizler_Click(object sender, EventArgs e)
        {
            Form17 frm17 = new Form17();
            frm17.Show();
            this.Hide();
        }
    }
}
