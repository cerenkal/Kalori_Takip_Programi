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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        private void btnGirisYapForm2_Click(object sender, EventArgs e)
        {
            //Giriş sayfasına yönlendirir
            Form5 frm5 = new Form5();
            frm5.Show();
            this.Hide();
        }

        private void btnUyeOlForm2_Click(object sender, EventArgs e)
        {
           // Üye olma sayfasına yönlendirir
            Form4 frm4= new Form4();
            frm4.Show();
            this.Hide();
            
        }

        private void btnUyeOlmadanDevamEt_Click(object sender, EventArgs e)
        {
            //Üye olmadan gidilebilen sayfa(vücut analizi)
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }
    }
}
