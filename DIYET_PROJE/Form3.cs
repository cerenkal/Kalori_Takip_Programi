using DataAccess.ConcreteRepository;
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
    public partial class Form3 : Form
    {
        KaloriTakipDBContext kaloriTakipDBContext;
        VucutAnaliziRepository vucutAnaliziRepository;
        public static int kilo;
        public Form3()
        {
            InitializeComponent();
            kaloriTakipDBContext = new KaloriTakipDBContext();
            vucutAnaliziRepository = new VucutAnaliziRepository(kaloriTakipDBContext);

        }



        private void btnHesaplaVucutAnalizi_Click(object sender, EventArgs e)
        {
            // textler boş geçilememe kontrolü
            if (Fonksiyonlar.BosMu(this.Controls) == false)
            {
                double boy = Convert.ToInt32(txtBoy.Text);
                double boy2 = (double) boy / 100;
                kilo = Convert.ToInt32(txtKilo.Text);
                int basenC = Convert.ToInt32(txtBasenCevresi.Text);
                int belC = Convert.ToInt32(txtBelCevresi.Text);
                int boyunC = Convert.ToInt32(txtBoyunCevresi.Text);
                int yas = Convert.ToInt32(txtYas.Text);

                // kullanıcı üye mi değil mi kontrolü yapıyoruz
                if (Form5.gelenID > 0)
                {
                    //üye kullanıcının vücut analizi hesaplama yeri
                    var gelen = kaloriTakipDBContext.Kullanicilar.Where(x => x.ID == Form5.gelenID).FirstOrDefault();

                    //Vücut Kitle indeksi hesabı
                    VucutAnalizi va = new VucutAnalizi();
                    va.VKI = (int)(kilo / (boy2 * boy2));

                    if (va.VKI <= 18) lblVKI.Text = $"{va.VKI} - Zayıf ";
                    else if (va.VKI > 18 && va.VKI <= 24) lblVKI.Text = $"{va.VKI} - Normal Kilolu ";
                    else if (va.VKI > 24 && va.VKI <= 29) lblVKI.Text = $"{va.VKI} - Fazla Kilolu ";
                    else if (va.VKI > 29 && va.VKI <= 35) lblVKI.Text = $"{va.VKI} - 1.Derece Obezite ";
                    else if (va.VKI > 35 && va.VKI <= 45) lblVKI.Text = $"{va.VKI} - 2.Derece Obezite ";
                    else if (va.VKI > 45) lblVKI.Text = $"{va.VKI} - 3.Derece Obezite(Morbid Obezite)";

                     //Vücut yağ oranı hesabı
                    va.VYO = (float)((163.205 * Math.Log10(belC + basenC - boyunC) - 97.684 * Math.Log10(boy) - 78.387) / 2.1);
                    int VYO2 = (int)va.VYO;
                    if (VYO2 <= 21) lblVYO.Text = $"{VYO2} - Atletik Vucüt ";
                    else if (VYO2 > 21 && VYO2 <= 24) lblVYO.Text = $"{VYO2} - Form Vucüt ";
                    else if (VYO2 > 24 && VYO2 <= 31) lblVYO.Text = $"{VYO2} - Ortalama Vucüt ";
                    else if (VYO2 > 31) lblVYO.Text = $"{VYO2} - Obez ";


                    //Bazal metabolizma hızı hesabı
                    va.BMH = (float)(665.1 + (9.56 * kilo) + (1.85 * boy) - (4.68 * yas));
                    lblBMH.Text = $"{va.BMH}";
                    vucutAnaliziRepository.Add(va);

                    //dbye kaydetme
                    gelen.VucutAnaliziID = va.ID;
                    kaloriTakipDBContext.SaveChanges();
                }


                else
                {
                    //üye olmayan kullanıcı Vücut analizi hesabı detaylar yukarıdaki ile aynı
                    int VKI = (int)(kilo / (boy2 * boy2));

                    if (VKI <= 18) lblVKI.Text = $"{VKI} - Zayıf ";
                    else if (VKI > 18 && VKI <= 24) lblVKI.Text = $"{VKI} - Normal Kilolu ";
                    else if (VKI > 24 && VKI <= 29) lblVKI.Text = $"{VKI} - Fazla Kilolu ";
                    else if (VKI > 29 && VKI <= 35) lblVKI.Text = $"{VKI} - 1.Derece Obezite ";
                    else if (VKI > 35 && VKI <= 45) lblVKI.Text = $"{VKI} - 2.Derece Obezite ";
                    else if (VKI > 45) lblVKI.Text = $"{VKI} - 3.Derece Obezite(Morbid Obezite)";


                    float VYO = (float)((163.205 * Math.Log10(belC + basenC - boyunC) - 97.684 * Math.Log10(boy) - 78.387) / 2.2);
                    int VYO1 = (int)VYO;
                    if (VYO1 <= 21) lblVYO.Text = $"{VYO1} - Atletik Vucüt ";
                    else if (VYO1 > 21 && VYO1<= 24) lblVYO.Text = $"{VYO1} - Form Vucüt ";
                    else if (VYO1 > 24 && VYO1 < 31) lblVYO.Text = $"{VYO1} - Ortalama Vucüt ";
                    else if (VYO1 >= 31) lblVYO.Text = $"{VYO1} - Obez ";

                    float BMH = (float)(665.1 + (9.56 * kilo) + (1.85 * boy) - (4.68 * yas));
                    lblBMH.Text = $"{BMH}";

                }
            }

            else MessageBox.Show("Vucüt Analizi için gerekli olan bilgiler boş geçilemez");



        }

        private void btnGeriVucutAnalizi_Click(object sender, EventArgs e)
        {
            var gelen = kaloriTakipDBContext.Kullanicilar.Where(x => x.ID == Form5.gelenID).FirstOrDefault();

            if (Form5.gelenID >0)
            {
                //eğer kullanıcı girişiyle vücut analizi yapıldıysa anasayfaya yönlendirilir
                Form8 frm8 = new Form8();
                frm8.Show();
                this.Hide();
            }

            else
            {
              // eğer üye olmayan kullanıcı ise ana giriş sayfasına yönlendirilir
                Form2 frm2 = new Form2();
                frm2.Show();
                this.Hide();
            }

           
        }
    }
}
