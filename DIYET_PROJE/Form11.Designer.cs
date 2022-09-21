namespace DIYET_PROJE
{
    partial class Form11
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtArananUrunOgleYemegi = new System.Windows.Forms.TextBox();
            this.btnOgleYemegiGeri = new DIYET_PROJE.RJButton();
            this.btnOgleYemegiEkle = new DIYET_PROJE.RJButton();
            this.btnOgleYemegiSilme = new DIYET_PROJE.RJButton();
            this.dgvOgleYemegiKullaniciListesi = new System.Windows.Forms.DataGridView();
            this.dgvOgleYemegiListe = new System.Windows.Forms.DataGridView();
            this.btnOgleAra = new System.Windows.Forms.Button();
            this.txtOgleMiktar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblOgleYemegiOlcu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgleYemegiKullaniciListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgleYemegiListe)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(23, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(383, 18);
            this.label3.TabIndex = 36;
            this.label3.Text = "Lütfen öğlen yemeğinde tükettiğiniz tüm besinleri ekleyiniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 41);
            this.label2.TabIndex = 35;
            this.label2.Text = "Öğle Yemeği Ekle";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::DIYET_PROJE.Properties.Resources.womfit_logo;
            this.pictureBox1.Location = new System.Drawing.Point(813, 607);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightSalmon;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(659, 80);
            this.label1.TabIndex = 28;
            this.label1.Text = "ÖĞLE YEMEĞİ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtArananUrunOgleYemegi
            // 
            this.txtArananUrunOgleYemegi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtArananUrunOgleYemegi.Location = new System.Drawing.Point(19, 234);
            this.txtArananUrunOgleYemegi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtArananUrunOgleYemegi.Multiline = true;
            this.txtArananUrunOgleYemegi.Name = "txtArananUrunOgleYemegi";
            this.txtArananUrunOgleYemegi.Size = new System.Drawing.Size(611, 46);
            this.txtArananUrunOgleYemegi.TabIndex = 30;
            this.txtArananUrunOgleYemegi.Text = "Lütfen aradığınız ürünü giriniz";
            this.txtArananUrunOgleYemegi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtArananUrunOgleYemegi_MouseClick);
            // 
            // btnOgleYemegiGeri
            // 
            this.btnOgleYemegiGeri.BackColor = System.Drawing.Color.Transparent;
            this.btnOgleYemegiGeri.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnOgleYemegiGeri.BackgroundImage = global::DIYET_PROJE.Properties.Resources.Back_Button_PNG_Pic;
            this.btnOgleYemegiGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOgleYemegiGeri.BorderColor = System.Drawing.Color.LightCoral;
            this.btnOgleYemegiGeri.BorderRadius = 0;
            this.btnOgleYemegiGeri.BorderSize = 0;
            this.btnOgleYemegiGeri.FlatAppearance.BorderSize = 0;
            this.btnOgleYemegiGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOgleYemegiGeri.ForeColor = System.Drawing.Color.Black;
            this.btnOgleYemegiGeri.Location = new System.Drawing.Point(12, 662);
            this.btnOgleYemegiGeri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOgleYemegiGeri.Name = "btnOgleYemegiGeri";
            this.btnOgleYemegiGeri.Size = new System.Drawing.Size(53, 49);
            this.btnOgleYemegiGeri.TabIndex = 34;
            this.btnOgleYemegiGeri.TextColor = System.Drawing.Color.Black;
            this.btnOgleYemegiGeri.UseVisualStyleBackColor = false;
            this.btnOgleYemegiGeri.Click += new System.EventHandler(this.btnOgleYemegiGeri_Click);
            // 
            // btnOgleYemegiEkle
            // 
            this.btnOgleYemegiEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnOgleYemegiEkle.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnOgleYemegiEkle.BackgroundImage = global::DIYET_PROJE.Properties.Resources.add_FILL0_wght400_GRAD0_opsz481;
            this.btnOgleYemegiEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOgleYemegiEkle.BorderColor = System.Drawing.Color.LightCoral;
            this.btnOgleYemegiEkle.BorderRadius = 0;
            this.btnOgleYemegiEkle.BorderSize = 0;
            this.btnOgleYemegiEkle.FlatAppearance.BorderSize = 0;
            this.btnOgleYemegiEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOgleYemegiEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgleYemegiEkle.ForeColor = System.Drawing.Color.Black;
            this.btnOgleYemegiEkle.Location = new System.Drawing.Point(618, 542);
            this.btnOgleYemegiEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnOgleYemegiEkle.Name = "btnOgleYemegiEkle";
            this.btnOgleYemegiEkle.Size = new System.Drawing.Size(60, 55);
            this.btnOgleYemegiEkle.TabIndex = 37;
            this.btnOgleYemegiEkle.TextColor = System.Drawing.Color.Black;
            this.btnOgleYemegiEkle.UseVisualStyleBackColor = false;
            this.btnOgleYemegiEkle.Click += new System.EventHandler(this.btnOgleYemegiEkle_Click);
            // 
            // btnOgleYemegiSilme
            // 
            this.btnOgleYemegiSilme.BackColor = System.Drawing.Color.Transparent;
            this.btnOgleYemegiSilme.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnOgleYemegiSilme.BackgroundImage = global::DIYET_PROJE.Properties.Resources.remove_FILL0_wght400_GRAD0_opsz481;
            this.btnOgleYemegiSilme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOgleYemegiSilme.BorderColor = System.Drawing.Color.LightCoral;
            this.btnOgleYemegiSilme.BorderRadius = 0;
            this.btnOgleYemegiSilme.BorderSize = 0;
            this.btnOgleYemegiSilme.FlatAppearance.BorderSize = 0;
            this.btnOgleYemegiSilme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOgleYemegiSilme.ForeColor = System.Drawing.Color.Black;
            this.btnOgleYemegiSilme.Location = new System.Drawing.Point(856, 546);
            this.btnOgleYemegiSilme.Margin = new System.Windows.Forms.Padding(4);
            this.btnOgleYemegiSilme.Name = "btnOgleYemegiSilme";
            this.btnOgleYemegiSilme.Size = new System.Drawing.Size(60, 55);
            this.btnOgleYemegiSilme.TabIndex = 38;
            this.btnOgleYemegiSilme.TextColor = System.Drawing.Color.Black;
            this.btnOgleYemegiSilme.UseVisualStyleBackColor = false;
            this.btnOgleYemegiSilme.Click += new System.EventHandler(this.btnOgleYemegiSilme_Click);
            // 
            // dgvOgleYemegiKullaniciListesi
            // 
            this.dgvOgleYemegiKullaniciListesi.BackgroundColor = System.Drawing.Color.White;
            this.dgvOgleYemegiKullaniciListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOgleYemegiKullaniciListesi.Location = new System.Drawing.Point(688, 288);
            this.dgvOgleYemegiKullaniciListesi.Margin = new System.Windows.Forms.Padding(4);
            this.dgvOgleYemegiKullaniciListesi.Name = "dgvOgleYemegiKullaniciListesi";
            this.dgvOgleYemegiKullaniciListesi.RowHeadersWidth = 51;
            this.dgvOgleYemegiKullaniciListesi.Size = new System.Drawing.Size(228, 250);
            this.dgvOgleYemegiKullaniciListesi.TabIndex = 41;
            // 
            // dgvOgleYemegiListe
            // 
            this.dgvOgleYemegiListe.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvOgleYemegiListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOgleYemegiListe.Location = new System.Drawing.Point(19, 288);
            this.dgvOgleYemegiListe.Margin = new System.Windows.Forms.Padding(4);
            this.dgvOgleYemegiListe.Name = "dgvOgleYemegiListe";
            this.dgvOgleYemegiListe.RowHeadersWidth = 51;
            this.dgvOgleYemegiListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOgleYemegiListe.Size = new System.Drawing.Size(661, 246);
            this.dgvOgleYemegiListe.TabIndex = 40;
            this.dgvOgleYemegiListe.SelectionChanged += new System.EventHandler(this.dgvOgleYemegiListe_SelectionChanged);
            // 
            // btnOgleAra
            // 
            this.btnOgleAra.BackColor = System.Drawing.Color.Transparent;
            this.btnOgleAra.BackgroundImage = global::DIYET_PROJE.Properties.Resources.search_FILL0_wght400_GRAD0_opsz48__1_;
            this.btnOgleAra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOgleAra.Location = new System.Drawing.Point(631, 234);
            this.btnOgleAra.Margin = new System.Windows.Forms.Padding(4);
            this.btnOgleAra.Name = "btnOgleAra";
            this.btnOgleAra.Size = new System.Drawing.Size(49, 47);
            this.btnOgleAra.TabIndex = 44;
            this.btnOgleAra.UseVisualStyleBackColor = false;
            this.btnOgleAra.Click += new System.EventHandler(this.btnOgleAra_Click);
            // 
            // txtOgleMiktar
            // 
            this.txtOgleMiktar.Location = new System.Drawing.Point(109, 558);
            this.txtOgleMiktar.Margin = new System.Windows.Forms.Padding(4);
            this.txtOgleMiktar.Name = "txtOgleMiktar";
            this.txtOgleMiktar.Size = new System.Drawing.Size(208, 22);
            this.txtOgleMiktar.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(16, 555);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 25);
            this.label5.TabIndex = 45;
            this.label5.Text = "Miktar : ";
            // 
            // lblOgleYemegiOlcu
            // 
            this.lblOgleYemegiOlcu.AutoSize = true;
            this.lblOgleYemegiOlcu.BackColor = System.Drawing.Color.Transparent;
            this.lblOgleYemegiOlcu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblOgleYemegiOlcu.Location = new System.Drawing.Point(333, 558);
            this.lblOgleYemegiOlcu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOgleYemegiOlcu.Name = "lblOgleYemegiOlcu";
            this.lblOgleYemegiOlcu.Size = new System.Drawing.Size(56, 25);
            this.lblOgleYemegiOlcu.TabIndex = 53;
            this.lblOgleYemegiOlcu.Text = "gram";
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DIYET_PROJE.Properties.Resources.WhatsApp_Image_2022_09_07_at_22_471;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(929, 722);
            this.Controls.Add(this.lblOgleYemegiOlcu);
            this.Controls.Add(this.txtOgleMiktar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnOgleAra);
            this.Controls.Add(this.dgvOgleYemegiKullaniciListesi);
            this.Controls.Add(this.dgvOgleYemegiListe);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOgleYemegiSilme);
            this.Controls.Add(this.btnOgleYemegiEkle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOgleYemegiGeri);
            this.Controls.Add(this.txtArananUrunOgleYemegi);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form11";
            this.Text = "Form11";
            this.Load += new System.EventHandler(this.Form11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgleYemegiKullaniciListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgleYemegiListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtArananUrunOgleYemegi;
        private RJButton btnOgleYemegiGeri;
        private RJButton btnOgleYemegiEkle;
        private RJButton btnOgleYemegiSilme;
        private System.Windows.Forms.DataGridView dgvOgleYemegiKullaniciListesi;
        private System.Windows.Forms.DataGridView dgvOgleYemegiListe;
        private System.Windows.Forms.Button btnOgleAra;
        private System.Windows.Forms.TextBox txtOgleMiktar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblOgleYemegiOlcu;
    }
}