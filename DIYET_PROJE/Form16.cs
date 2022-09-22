using DataAccess.ConcreteRepository;
using DataAccess.Context;
using Entities.Concrete;
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
    public partial class Form16 : Form
    {
        KaloriTakipDBContext kaloriTakipDBContext;
        SuVerisiRepository suVerisiRepository;
        public Form16()
        {
            InitializeComponent();
            kaloriTakipDBContext = new KaloriTakipDBContext();
            suVerisiRepository = new SuVerisiRepository(kaloriTakipDBContext);
        }

        public int n = 0;
        public int parca;

        //Sayfadaki bardak görsellerinin açılışta görünmemesi kodu
        private void Form16_Load_1(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            label5.Visible = false;
            pictureBox2.Visible = false;
            label3.Visible = false;
            pictureBox3.Visible = false;
            label4.Visible = false;
            pictureBox4.Visible = false;
            label6.Visible = false;
            pictureBox6.Visible = false;
            label7.Visible = false;
            pictureBox7.Visible = false;
            label8.Visible = false;
            pictureBox8.Visible = false;
            label9.Visible = false;
            pictureBox9.Visible = false;
            label10.Visible = false;
            pictureBox10.Visible = false;
            label11.Visible = false;
            pictureBox11.Visible = false;
            label12.Visible = false;


        }
        int toplamSu;
        private void btnSuHesapla_Click(object sender, EventArgs e)
        {
            //kiloya göre tüketilecek su miktarı hesaplama

            var gelen = kaloriTakipDBContext.Kullanicilar.Where(x => x.ID == Form5.gelenID).FirstOrDefault();

            SuVerisi sv = new SuVerisi();

            toplamSu = (int)(Convert.ToInt32(txtSuVerisiKilo.Text) * 0.35) * 100;
            parca = toplamSu / 10;
            lblSuHedefi.Text = $"{toplamSu} ml";

            sv.SuMiktari = n * parca;
            sv.TuketilenTarih = DateTime.Now;
            suVerisiRepository.Add(sv);

            gelen.SuVerisiID = sv.ID;
            kaloriTakipDBContext.SaveChanges();


        }

        private void btnSuEkle_Click_1(object sender, EventArgs e)
        {

            if (toplamSu >0 )
            {

                pictureBox1.Visible = true;
                label5.Visible = true;
                label5.Text = $"{parca} ml";
                n++;

                if (n == 2)
                {
                    pictureBox2.Visible = true;
                    label3.Visible = true;
                    label3.Text = $"{parca} ml";
                }

                if (n == 3)
                {
                    pictureBox3.Visible = true;
                    label4.Visible = true;
                    label4.Text = $"{parca} ml";
                }

                if (n == 4)
                {
                    pictureBox4.Visible = true;
                    label6.Visible = true;
                    label6.Text = $"{parca} ml";
                }

                if (n == 5)
                {
                    pictureBox6.Visible = true;
                    label7.Visible = true;
                    label7.Text = $"{parca} ml";
                }

                if (n == 6)
                {
                    pictureBox7.Visible = true;
                    label8.Visible = true;
                    label8.Text = $"{parca} ml";
                }

                if (n == 7)
                {
                    pictureBox8.Visible = true;
                    label9.Visible = true;
                    label9.Text = $"{parca} ml";
                }
                if (n == 8)
                {
                    pictureBox9.Visible = true;
                    label10.Visible = true;
                    label10.Text = $"{parca} ml";

                }
                if (n == 9)
                {
                    pictureBox10.Visible = true;
                    label11.Visible = true;
                    label11.Text = $"{parca} ml";

                }
                if (n == 10)
                {
                    pictureBox11.Visible = true;
                    label12.Visible = true;
                    label12.Text = $"{parca} ml";

                }
            }
            else
            {
                MessageBox.Show("Önce kilonuzu girerek hesaplama yapmalısınız");
            }

        }

     
       

        private void btnSuSil_Click(object sender, EventArgs e)
        {
            switch (n)
            {
                case 10:
                    pictureBox11.Visible = false;
                    label12.Visible = false;
                    n = 9;
                    break;
                case 9:
                    pictureBox10.Visible = false;
                    label11.Visible = false;
                    n = 8;
                    break;
                case 8:
                    pictureBox9.Visible = false;
                    label10.Visible = false;
                    n = 7;
                    break;
                case 7:
                    pictureBox8.Visible = false;
                    label9.Visible = false;
                    n = 6;
                    break;
                case 6:
                    pictureBox7.Visible = false;
                    label8.Visible = false;
                    n = 5;
                    break;
                case 5:
                    pictureBox6.Visible = false;
                    label7.Visible = false;
                    n = 4;
                    break;
                case 4:
                    pictureBox4.Visible = false;
                    label6.Visible = false;
                    n = 3;
                    break;
                case 3:
                    pictureBox3.Visible = false;
                    label4.Visible = false;
                    n = 2;
                    break;
                case 2:
                    pictureBox2.Visible = false;
                    label3.Visible = false;
                    n = 1;
                    break;
                case 1:
                    pictureBox1.Visible = false;
                    label5.Visible = false;
                    n = 0;
                    break;

            }
        }

        private void btnSuTakibiGeri_Click(object sender, EventArgs e)
        {
            Form8 frm8 = new Form8();
            frm8.Show();
            this.Hide();
           
        }
    }
}
