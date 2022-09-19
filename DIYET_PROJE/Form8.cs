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
    }
}
