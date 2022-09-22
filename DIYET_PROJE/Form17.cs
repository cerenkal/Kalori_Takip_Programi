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
    public partial class Form17 : Form
    {
        private KaloriTakipDBContext _kaloriTakipDBContext;
        int secilenTarifID;
        int secilenMakaleID;


        public Form17()
        {
            InitializeComponent();
            _kaloriTakipDBContext = new KaloriTakipDBContext();
        }

        private void dgvTariflerListele_SelectionChanged(object sender, EventArgs e)
        {
            secilenTarifID = Convert.ToInt32(dgvTariflerListele.CurrentRow.Cells[0].Value);
            var secilenTarif = _kaloriTakipDBContext.Tarifler.Where(x => x.ID == secilenTarifID).Select(x => new {x.TarifAdi, x.Aciklamasi }).FirstOrDefault();

            secilenMakaleID = Convert.ToInt32(dgvTariflerListele.CurrentRow.Cells[0].Value);
            var secilenMakale = _kaloriTakipDBContext.Makaleler.Where(x => x.ID == secilenMakaleID).Select(x => new { x.MakaleAdi,x.Aciklamasi }).FirstOrDefault();


            if (rdbTarifler.Checked)
            {
                rtbTariflerVeMakalelerGoruntule.Text = string.Empty;
                rtbTariflerVeMakalelerGoruntule.Text =secilenTarif.TarifAdi.ToUpper()+ "\n\r"+secilenTarif.Aciklamasi;

                secilenTarifID = 0;
            }

            else
            {
                rtbTariflerVeMakalelerGoruntule.Text = string.Empty;
                rtbTariflerVeMakalelerGoruntule.Text = secilenMakale.MakaleAdi.ToUpper() + "\n\r"+secilenMakale.Aciklamasi;

                secilenMakaleID = 0;
            }

        }

     
        private void rbMakaleler_CheckedChanged(object sender, EventArgs e)
        {
            dgvTariflerListele.DataSource = null;

            dgvTariflerListele.DataSource = _kaloriTakipDBContext.Makaleler.Select(x => new { x.ID, x.MakaleAdi }).ToList();
            dgvTariflerListele.Columns[0].Width = 40;
            dgvTariflerListele.Columns[1].Width = 230;

        }

        private void rbTarifler_CheckedChanged(object sender, EventArgs e)
        {
            dgvTariflerListele.DataSource = null;

            dgvTariflerListele.DataSource = _kaloriTakipDBContext.Tarifler.Select(x => new { x.ID, x.TarifAdi }).ToList();
            dgvTariflerListele.Columns[0].Width = 40;
            dgvTariflerListele.Columns[1].Width = 230;

        }

        private void btnTarifVeMakaleGeri_Click(object sender, EventArgs e)
        {
            Form8 frm8 = new Form8();
            frm8.Show();
            this.Hide();
        }
    }
}
