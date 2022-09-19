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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void btnAksamEkle_Click(object sender, EventArgs e)
        {
            Form12 frm12 = new Form12();
            frm12.Show();
            this.Hide();

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            lblKaloriAksam.Text = Form12.toplamKalori.ToString();
            lblKarbonhidratAksam.Text = Form12.toplamCarb.ToString();
            lblProteinAksam.Text = Form12.toplamProtein.ToString();
            lblYagAksam.Text = Form12.toplamYag.ToString();
        }
    }
}
