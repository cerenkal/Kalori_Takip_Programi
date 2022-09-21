namespace DIYET_PROJE
{
    partial class Form12
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
            this.txtArananUrunAksamYemegi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dgvAksamKullanicininListesi = new System.Windows.Forms.DataGridView();
            this.dgvAksamListe = new System.Windows.Forms.DataGridView();
            this.btnAksamAra = new System.Windows.Forms.Button();
            this.txtAksamMiktar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblOlcu = new System.Windows.Forms.Label();
            this.btnSilmeAksamYemegi = new DIYET_PROJE.RJButton();
            this.btnEklemeAksamYemegi = new DIYET_PROJE.RJButton();
            this.btnGeriAksamYemegi = new DIYET_PROJE.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAksamKullanicininListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAksamListe)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(23, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(424, 21);
            this.label3.TabIndex = 36;
            this.label3.Text = "Lütfen akşam yemeğinde tükettiğiniz tüm besinleri ekleyiniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 41);
            this.label2.TabIndex = 35;
            this.label2.Text = "Akşam Yemeği Ekle";
            // 
            // txtArananUrunAksamYemegi
            // 
            this.txtArananUrunAksamYemegi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtArananUrunAksamYemegi.Location = new System.Drawing.Point(152, 196);
            this.txtArananUrunAksamYemegi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtArananUrunAksamYemegi.Multiline = true;
            this.txtArananUrunAksamYemegi.Name = "txtArananUrunAksamYemegi";
            this.txtArananUrunAksamYemegi.Size = new System.Drawing.Size(460, 34);
            this.txtArananUrunAksamYemegi.TabIndex = 30;
            this.txtArananUrunAksamYemegi.Text = "Lütfen aradığınız ürünü giriniz";
            this.txtArananUrunAksamYemegi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtArananUrunAksamYemegi_MouseClick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightSalmon;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(151, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 65);
            this.label1.TabIndex = 28;
            this.label1.Text = "AKŞAM YEMEĞİ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = global::DIYET_PROJE.Properties.Resources.womfit_logo;
            this.pictureBox2.Location = new System.Drawing.Point(909, 507);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(103, 103);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            // 
            // dgvAksamKullanicininListesi
            // 
            this.dgvAksamKullanicininListesi.BackgroundColor = System.Drawing.Color.White;
            this.dgvAksamKullanicininListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAksamKullanicininListesi.Location = new System.Drawing.Point(659, 240);
            this.dgvAksamKullanicininListesi.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAksamKullanicininListesi.Name = "dgvAksamKullanicininListesi";
            this.dgvAksamKullanicininListesi.RowHeadersWidth = 51;
            this.dgvAksamKullanicininListesi.Size = new System.Drawing.Size(228, 200);
            this.dgvAksamKullanicininListesi.TabIndex = 47;
            // 
            // dgvAksamListe
            // 
            this.dgvAksamListe.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvAksamListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAksamListe.Location = new System.Drawing.Point(155, 240);
            this.dgvAksamListe.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAksamListe.Name = "dgvAksamListe";
            this.dgvAksamListe.RowHeadersWidth = 51;
            this.dgvAksamListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAksamListe.Size = new System.Drawing.Size(496, 200);
            this.dgvAksamListe.TabIndex = 46;
            this.dgvAksamListe.SelectionChanged += new System.EventHandler(this.dgvAksamListe_SelectionChanged);
            // 
            // btnAksamAra
            // 
            this.btnAksamAra.BackColor = System.Drawing.Color.Transparent;
            this.btnAksamAra.BackgroundImage = global::DIYET_PROJE.Properties.Resources.search_FILL0_wght400_GRAD0_opsz48__1_;
            this.btnAksamAra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAksamAra.Location = new System.Drawing.Point(614, 196);
            this.btnAksamAra.Margin = new System.Windows.Forms.Padding(4);
            this.btnAksamAra.Name = "btnAksamAra";
            this.btnAksamAra.Size = new System.Drawing.Size(37, 34);
            this.btnAksamAra.TabIndex = 48;
            this.btnAksamAra.UseVisualStyleBackColor = false;
            this.btnAksamAra.Click += new System.EventHandler(this.btnAksamAra_Click);
            // 
            // txtAksamMiktar
            // 
            this.txtAksamMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAksamMiktar.Location = new System.Drawing.Point(225, 452);
            this.txtAksamMiktar.Margin = new System.Windows.Forms.Padding(4);
            this.txtAksamMiktar.Name = "txtAksamMiktar";
            this.txtAksamMiktar.Size = new System.Drawing.Size(60, 30);
            this.txtAksamMiktar.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(150, 456);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 25);
            this.label5.TabIndex = 49;
            this.label5.Text = "Miktar : ";
            // 
            // lblOlcu
            // 
            this.lblOlcu.AutoSize = true;
            this.lblOlcu.BackColor = System.Drawing.Color.Transparent;
            this.lblOlcu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblOlcu.Location = new System.Drawing.Point(290, 456);
            this.lblOlcu.Name = "lblOlcu";
            this.lblOlcu.Size = new System.Drawing.Size(56, 25);
            this.lblOlcu.TabIndex = 51;
            this.lblOlcu.Text = "gram";
            // 
            // btnSilmeAksamYemegi
            // 
            this.btnSilmeAksamYemegi.BackColor = System.Drawing.Color.Transparent;
            this.btnSilmeAksamYemegi.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnSilmeAksamYemegi.BackgroundImage = global::DIYET_PROJE.Properties.Resources.remove_FILL0_wght400_GRAD0_opsz481;
            this.btnSilmeAksamYemegi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSilmeAksamYemegi.BorderColor = System.Drawing.Color.LightCoral;
            this.btnSilmeAksamYemegi.BorderRadius = 0;
            this.btnSilmeAksamYemegi.BorderSize = 0;
            this.btnSilmeAksamYemegi.FlatAppearance.BorderSize = 0;
            this.btnSilmeAksamYemegi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSilmeAksamYemegi.ForeColor = System.Drawing.Color.Black;
            this.btnSilmeAksamYemegi.Location = new System.Drawing.Point(827, 444);
            this.btnSilmeAksamYemegi.Margin = new System.Windows.Forms.Padding(4);
            this.btnSilmeAksamYemegi.Name = "btnSilmeAksamYemegi";
            this.btnSilmeAksamYemegi.Size = new System.Drawing.Size(60, 55);
            this.btnSilmeAksamYemegi.TabIndex = 45;
            this.btnSilmeAksamYemegi.TextColor = System.Drawing.Color.Black;
            this.btnSilmeAksamYemegi.UseVisualStyleBackColor = false;
            this.btnSilmeAksamYemegi.Click += new System.EventHandler(this.btnSilmeAksamYemegi_Click);
            // 
            // btnEklemeAksamYemegi
            // 
            this.btnEklemeAksamYemegi.BackColor = System.Drawing.Color.Transparent;
            this.btnEklemeAksamYemegi.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnEklemeAksamYemegi.BackgroundImage = global::DIYET_PROJE.Properties.Resources.add_FILL0_wght400_GRAD0_opsz481;
            this.btnEklemeAksamYemegi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEklemeAksamYemegi.BorderColor = System.Drawing.Color.LightCoral;
            this.btnEklemeAksamYemegi.BorderRadius = 0;
            this.btnEklemeAksamYemegi.BorderSize = 0;
            this.btnEklemeAksamYemegi.FlatAppearance.BorderSize = 0;
            this.btnEklemeAksamYemegi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEklemeAksamYemegi.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEklemeAksamYemegi.ForeColor = System.Drawing.Color.Black;
            this.btnEklemeAksamYemegi.Location = new System.Drawing.Point(587, 444);
            this.btnEklemeAksamYemegi.Margin = new System.Windows.Forms.Padding(4);
            this.btnEklemeAksamYemegi.Name = "btnEklemeAksamYemegi";
            this.btnEklemeAksamYemegi.Size = new System.Drawing.Size(60, 55);
            this.btnEklemeAksamYemegi.TabIndex = 44;
            this.btnEklemeAksamYemegi.TextColor = System.Drawing.Color.Black;
            this.btnEklemeAksamYemegi.UseVisualStyleBackColor = false;
            this.btnEklemeAksamYemegi.Click += new System.EventHandler(this.btnEklemeAksamYemegi_Click);
            // 
            // btnGeriAksamYemegi
            // 
            this.btnGeriAksamYemegi.BackColor = System.Drawing.Color.Transparent;
            this.btnGeriAksamYemegi.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnGeriAksamYemegi.BackgroundImage = global::DIYET_PROJE.Properties.Resources.Back_Button_PNG_Pic;
            this.btnGeriAksamYemegi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGeriAksamYemegi.BorderColor = System.Drawing.Color.LightCoral;
            this.btnGeriAksamYemegi.BorderRadius = 0;
            this.btnGeriAksamYemegi.BorderSize = 0;
            this.btnGeriAksamYemegi.FlatAppearance.BorderSize = 0;
            this.btnGeriAksamYemegi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeriAksamYemegi.ForeColor = System.Drawing.Color.Black;
            this.btnGeriAksamYemegi.Location = new System.Drawing.Point(27, 538);
            this.btnGeriAksamYemegi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGeriAksamYemegi.Name = "btnGeriAksamYemegi";
            this.btnGeriAksamYemegi.Size = new System.Drawing.Size(53, 49);
            this.btnGeriAksamYemegi.TabIndex = 43;
            this.btnGeriAksamYemegi.TextColor = System.Drawing.Color.Black;
            this.btnGeriAksamYemegi.UseVisualStyleBackColor = false;
            this.btnGeriAksamYemegi.Click += new System.EventHandler(this.btnGeriAksamYemegi_Click);
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DIYET_PROJE.Properties.Resources.WhatsApp_Image_2022_09_07_at_22_471;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 621);
            this.Controls.Add(this.lblOlcu);
            this.Controls.Add(this.txtAksamMiktar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAksamAra);
            this.Controls.Add(this.dgvAksamKullanicininListesi);
            this.Controls.Add(this.dgvAksamListe);
            this.Controls.Add(this.btnSilmeAksamYemegi);
            this.Controls.Add(this.btnEklemeAksamYemegi);
            this.Controls.Add(this.btnGeriAksamYemegi);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtArananUrunAksamYemegi);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form12";
            this.Text = "Form12";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAksamKullanicininListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAksamListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtArananUrunAksamYemegi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private RJButton btnSilmeAksamYemegi;
        private RJButton btnEklemeAksamYemegi;
        private RJButton btnGeriAksamYemegi;
        private System.Windows.Forms.DataGridView dgvAksamKullanicininListesi;
        private System.Windows.Forms.DataGridView dgvAksamListe;
        private System.Windows.Forms.Button btnAksamAra;
        private System.Windows.Forms.TextBox txtAksamMiktar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblOlcu;
    }
}