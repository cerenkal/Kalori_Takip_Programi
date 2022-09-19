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
        public static Form5 frm5;
        private void btnGirisYapForm2_Click(object sender, EventArgs e)
        {
            
            frm5 = new Form5();
            frm5.Show();
            this.Hide();
        }

        public static Form4 frm4;

        private void btnUyeOlForm2_Click(object sender, EventArgs e)
        {
           
            frm4= new Form4();
            frm4.Show();
            this.Hide();
            
        }

 
       
        public static Form3 frm3;
        private void btnUyeOlmadanDevamEt_Click(object sender, EventArgs e)
        {
            frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }
    }
}
