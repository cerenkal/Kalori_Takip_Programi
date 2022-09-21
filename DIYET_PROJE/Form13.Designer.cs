namespace DIYET_PROJE
{
    partial class Form13
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAperatifAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAperatifSilme = new DIYET_PROJE.RJButton();
            this.btnAperatifEkleme = new DIYET_PROJE.RJButton();
            this.btnAperitifGeri = new DIYET_PROJE.RJButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dgvAperatifKullanicininListesi = new System.Windows.Forms.DataGridView();
            this.dgvAperatifListe = new System.Windows.Forms.DataGridView();
            this.btnAperatifAra = new System.Windows.Forms.Button();
            this.txtAperatifMiktar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAperatifOlcu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAperatifKullanicininListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAperatifListe)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(27, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(446, 18);
            this.label3.TabIndex = 36;
            this.label3.Text = "Lütfen ara öğün ve aperatif olarak tükettiğiniz tüm besinleri ekleyiniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(21, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 41);
            this.label2.TabIndex = 35;
            this.label2.Text = "Aperatif Ekle";
            // 
            // txtAperatifAra
            // 
            this.txtAperatifAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAperatifAra.Location = new System.Drawing.Point(15, 220);
            this.txtAperatifAra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAperatifAra.Multiline = true;
            this.txtAperatifAra.Name = "txtAperatifAra";
            this.txtAperatifAra.Size = new System.Drawing.Size(611, 46);
            this.txtAperatifAra.TabIndex = 30;
            this.txtAperatifAra.Text = "Lütfen aradığınız ürünü giriniz";
            this.txtAperatifAra.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tstAperatifAra_MouseClick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightSalmon;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(663, 76);
            this.label1.TabIndex = 28;
            this.label1.Text = "APERATİFLER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAperatifSilme
            // 
            this.btnAperatifSilme.BackColor = System.Drawing.Color.Transparent;
            this.btnAperatifSilme.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnAperatifSilme.BackgroundImage = global::DIYET_PROJE.Properties.Resources.remove_FILL0_wght400_GRAD0_opsz481;
            this.btnAperatifSilme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAperatifSilme.BorderColor = System.Drawing.Color.LightCoral;
            this.btnAperatifSilme.BorderRadius = 0;
            this.btnAperatifSilme.BorderSize = 0;
            this.btnAperatifSilme.FlatAppearance.BorderSize = 0;
            this.btnAperatifSilme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAperatifSilme.ForeColor = System.Drawing.Color.Black;
            this.btnAperatifSilme.Location = new System.Drawing.Point(841, 524);
            this.btnAperatifSilme.Margin = new System.Windows.Forms.Padding(4);
            this.btnAperatifSilme.Name = "btnAperatifSilme";
            this.btnAperatifSilme.Size = new System.Drawing.Size(60, 55);
            this.btnAperatifSilme.TabIndex = 42;
            this.btnAperatifSilme.TextColor = System.Drawing.Color.Black;
            this.btnAperatifSilme.UseVisualStyleBackColor = false;
            this.btnAperatifSilme.Click += new System.EventHandler(this.btnAperatifSilme_Click);
            // 
            // btnAperatifEkleme
            // 
            this.btnAperatifEkleme.BackColor = System.Drawing.Color.Transparent;
            this.btnAperatifEkleme.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnAperatifEkleme.BackgroundImage = global::DIYET_PROJE.Properties.Resources.add_FILL0_wght400_GRAD0_opsz481;
            this.btnAperatifEkleme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAperatifEkleme.BorderColor = System.Drawing.Color.LightCoral;
            this.btnAperatifEkleme.BorderRadius = 0;
            this.btnAperatifEkleme.BorderSize = 0;
            this.btnAperatifEkleme.FlatAppearance.BorderSize = 0;
            this.btnAperatifEkleme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAperatifEkleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAperatifEkleme.ForeColor = System.Drawing.Color.Black;
            this.btnAperatifEkleme.Location = new System.Drawing.Point(617, 525);
            this.btnAperatifEkleme.Margin = new System.Windows.Forms.Padding(4);
            this.btnAperatifEkleme.Name = "btnAperatifEkleme";
            this.btnAperatifEkleme.Size = new System.Drawing.Size(60, 55);
            this.btnAperatifEkleme.TabIndex = 41;
            this.btnAperatifEkleme.TextColor = System.Drawing.Color.Black;
            this.btnAperatifEkleme.UseVisualStyleBackColor = false;
            this.btnAperatifEkleme.Click += new System.EventHandler(this.btnAperatifEkleme_Click);
            // 
            // btnAperitifGeri
            // 
            this.btnAperitifGeri.BackColor = System.Drawing.Color.Transparent;
            this.btnAperitifGeri.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnAperitifGeri.BackgroundImage = global::DIYET_PROJE.Properties.Resources.Back_Button_PNG_Pic;
            this.btnAperitifGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAperitifGeri.BorderColor = System.Drawing.Color.LightCoral;
            this.btnAperitifGeri.BorderRadius = 0;
            this.btnAperitifGeri.BorderSize = 0;
            this.btnAperitifGeri.FlatAppearance.BorderSize = 0;
            this.btnAperitifGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAperitifGeri.ForeColor = System.Drawing.Color.Black;
            this.btnAperitifGeri.Location = new System.Drawing.Point(19, 661);
            this.btnAperitifGeri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAperitifGeri.Name = "btnAperitifGeri";
            this.btnAperitifGeri.Size = new System.Drawing.Size(53, 49);
            this.btnAperitifGeri.TabIndex = 40;
            this.btnAperitifGeri.TextColor = System.Drawing.Color.Black;
            this.btnAperitifGeri.UseVisualStyleBackColor = false;
            this.btnAperitifGeri.Click += new System.EventHandler(this.btnAperitifGeri_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = global::DIYET_PROJE.Properties.Resources.womfit_logo;
            this.pictureBox2.Location = new System.Drawing.Point(798, 619);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(103, 103);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 43;
            this.pictureBox2.TabStop = false;
            // 
            // dgvAperatifKullanicininListesi
            // 
            this.dgvAperatifKullanicininListesi.BackgroundColor = System.Drawing.Color.White;
            this.dgvAperatifKullanicininListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAperatifKullanicininListesi.Location = new System.Drawing.Point(685, 281);
            this.dgvAperatifKullanicininListesi.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAperatifKullanicininListesi.Name = "dgvAperatifKullanicininListesi";
            this.dgvAperatifKullanicininListesi.RowHeadersWidth = 51;
            this.dgvAperatifKullanicininListesi.Size = new System.Drawing.Size(216, 236);
            this.dgvAperatifKullanicininListesi.TabIndex = 45;
            // 
            // dgvAperatifListe
            // 
            this.dgvAperatifListe.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvAperatifListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAperatifListe.Location = new System.Drawing.Point(16, 271);
            this.dgvAperatifListe.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAperatifListe.Name = "dgvAperatifListe";
            this.dgvAperatifListe.RowHeadersWidth = 51;
            this.dgvAperatifListe.Size = new System.Drawing.Size(661, 246);
            this.dgvAperatifListe.TabIndex = 44;
            this.dgvAperatifListe.SelectionChanged += new System.EventHandler(this.dgvAperatifListe_SelectionChanged);
            // 
            // btnAperatifAra
            // 
            this.btnAperatifAra.BackColor = System.Drawing.Color.Transparent;
            this.btnAperatifAra.BackgroundImage = global::DIYET_PROJE.Properties.Resources.search_FILL0_wght400_GRAD0_opsz48__1_;
            this.btnAperatifAra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAperatifAra.Location = new System.Drawing.Point(628, 220);
            this.btnAperatifAra.Margin = new System.Windows.Forms.Padding(4);
            this.btnAperatifAra.Name = "btnAperatifAra";
            this.btnAperatifAra.Size = new System.Drawing.Size(49, 47);
            this.btnAperatifAra.TabIndex = 49;
            this.btnAperatifAra.UseVisualStyleBackColor = false;
            this.btnAperatifAra.Click += new System.EventHandler(this.btnAperatifAra_Click);
            // 
            // txtAperatifMiktar
            // 
            this.txtAperatifMiktar.Location = new System.Drawing.Point(113, 540);
            this.txtAperatifMiktar.Margin = new System.Windows.Forms.Padding(4);
            this.txtAperatifMiktar.Name = "txtAperatifMiktar";
            this.txtAperatifMiktar.Size = new System.Drawing.Size(208, 22);
            this.txtAperatifMiktar.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(20, 540);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 25);
            this.label5.TabIndex = 50;
            this.label5.Text = "Miktar : ";
            // 
            // lblAperatifOlcu
            // 
            this.lblAperatifOlcu.AutoSize = true;
            this.lblAperatifOlcu.BackColor = System.Drawing.Color.Transparent;
            this.lblAperatifOlcu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblAperatifOlcu.Location = new System.Drawing.Point(344, 536);
            this.lblAperatifOlcu.Name = "lblAperatifOlcu";
            this.lblAperatifOlcu.Size = new System.Drawing.Size(56, 25);
            this.lblAperatifOlcu.TabIndex = 52;
            this.lblAperatifOlcu.Text = "gram";
            // 
            // Form13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DIYET_PROJE.Properties.Resources.WhatsApp_Image_2022_09_07_at_22_47_37;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(913, 738);
            this.Controls.Add(this.lblAperatifOlcu);
            this.Controls.Add(this.txtAperatifMiktar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAperatifAra);
            this.Controls.Add(this.dgvAperatifKullanicininListesi);
            this.Controls.Add(this.dgvAperatifListe);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnAperatifSilme);
            this.Controls.Add(this.btnAperatifEkleme);
            this.Controls.Add(this.btnAperitifGeri);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAperatifAra);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form13";
            this.Text = "Form13";
            this.Load += new System.EventHandler(this.Form13_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAperatifKullanicininListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAperatifListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAperatifAra;
        private System.Windows.Forms.Label label1;
        private RJButton btnAperatifSilme;
        private RJButton btnAperatifEkleme;
        private RJButton btnAperitifGeri;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dgvAperatifKullanicininListesi;
        private System.Windows.Forms.DataGridView dgvAperatifListe;
        private System.Windows.Forms.Button btnAperatifAra;
        private System.Windows.Forms.TextBox txtAperatifMiktar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAperatifOlcu;
    }
}