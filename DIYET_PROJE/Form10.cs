using DataAccess.ConcreteRepository;
using DataAccess.Context;
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
    public partial class Form10 : Form
    {

        private KaloriTakipDBContext _kaloriTakipDBContext;

        private BesinBilgileriRepository _besinBilgileriRepository;
        public Form10()
        {
            InitializeComponent();
            _kaloriTakipDBContext = new KaloriTakipDBContext();
            _besinBilgileriRepository = new BesinBilgileriRepository(_kaloriTakipDBContext);
        }

        


    

        private void Form10_Load(object sender, EventArgs e)
        {
           
           
        }

        private void txtKahvalti_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtKahvalti_MouseClick(object sender, MouseEventArgs e)
        {
            txtKahvalti.Text = String.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvKahvaltiListe.DataSource = _kaloriTakipDBContext.BesinBilgileri.Where(x => x.BesinAdi.Contains(txtKahvalti.Text)).Select(x => new { x.BesinAdi, x.OlcuBirimi, x.Kalori,x.Karbonhidrat,x.Protein,x.Yag,x.GramKarsiligi }).ToList();

            dgvKahvaltiListe.Columns[1].Width = 60;
            dgvKahvaltiListe.Columns[2].Width = 40;
            dgvKahvaltiListe.Columns[3].Width = 80;
            dgvKahvaltiListe.Columns[4].Width = 50;
            dgvKahvaltiListe.Columns[5].Width = 40;
        }

        private void dgvKahvaltiListe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
