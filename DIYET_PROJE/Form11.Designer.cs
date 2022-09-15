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
            this.btnOgleYemegiAnasayfa = new DIYET_PROJE.RJButton();
            this.btnOgleYemegiGeri = new DIYET_PROJE.RJButton();
            this.btnOgleYemegiEkle = new DIYET_PROJE.RJButton();
            this.btnOgleYemegiSilme = new DIYET_PROJE.RJButton();
            this.dgvOgleYemegiKullaniciListesi = new System.Windows.Forms.DataGridView();
            this.dgvOgleYemegiListe = new System.Windows.Forms.DataGridView();
            this.btnOgleAra = new System.Windows.Forms.Button();
            this.txtOgleMiktar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
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
            this.label3.Location = new System.Drawing.Point(17, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(324, 15);
            this.label3.TabIndex = 36;
            this.label3.Text = "Lütfen öğlen yemeğinde tükettiğiniz tüm besinleri ekleyiniz";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 33);
            this.label2.TabIndex = 35;
            this.label2.Text = "Öğle Yemeği Ekle";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::DIYET_PROJE.Properties.Resources.womfit_logo;
            this.pictureBox1.Location = new System.Drawing.Point(936, 526);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightSalmon;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(494, 65);
            this.label1.TabIndex = 28;
            this.label1.Text = "ÖĞLE YEMEĞİ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtArananUrunOgleYemegi
            // 
            this.txtArananUrunOgleYemegi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtArananUrunOgleYemegi.Location = new System.Drawing.Point(14, 190);
            this.txtArananUrunOgleYemegi.Margin = new System.Windows.Forms.Padding(2);
            this.txtArananUrunOgleYemegi.Multiline = true;
            this.txtArananUrunOgleYemegi.Name = "txtArananUrunOgleYemegi";
            this.txtArananUrunOgleYemegi.Size = new System.Drawing.Size(459, 38);
            this.txtArananUrunOgleYemegi.TabIndex = 30;
            this.txtArananUrunOgleYemegi.Text = "Lütfen aradığınız ürünü giriniz";
            // 
            // btnOgleYemegiAnasayfa
            // 
            this.btnOgleYemegiAnasayfa.BackColor = System.Drawing.Color.Transparent;
            this.btnOgleYemegiAnasayfa.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnOgleYemegiAnasayfa.BackgroundImage = global::DIYET_PROJE.Properties.Resources._171532;
            this.btnOgleYemegiAnasayfa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOgleYemegiAnasayfa.BorderColor = System.Drawing.Color.LightCoral;
            this.btnOgleYemegiAnasayfa.BorderRadius = 0;
            this.btnOgleYemegiAnasayfa.BorderSize = 0;
            this.btnOgleYemegiAnasayfa.FlatAppearance.BorderSize = 0;
            this.btnOgleYemegiAnasayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOgleYemegiAnasayfa.ForeColor = System.Drawing.Color.Black;
            this.btnOgleYemegiAnasayfa.Location = new System.Drawing.Point(82, 549);
            this.btnOgleYemegiAnasayfa.Margin = new System.Windows.Forms.Padding(2);
            this.btnOgleYemegiAnasayfa.Name = "btnOgleYemegiAnasayfa";
            this.btnOgleYemegiAnasayfa.Size = new System.Drawing.Size(35, 35);
            this.btnOgleYemegiAnasayfa.TabIndex = 31;
            this.btnOgleYemegiAnasayfa.TextColor = System.Drawing.Color.Black;
            this.btnOgleYemegiAnasayfa.UseVisualStyleBackColor = false;
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
            this.btnOgleYemegiGeri.Location = new System.Drawing.Point(28, 549);
            this.btnOgleYemegiGeri.Margin = new System.Windows.Forms.Padding(2);
            this.btnOgleYemegiGeri.Name = "btnOgleYemegiGeri";
            this.btnOgleYemegiGeri.Size = new System.Drawing.Size(40, 40);
            this.btnOgleYemegiGeri.TabIndex = 34;
            this.btnOgleYemegiGeri.TextColor = System.Drawing.Color.Black;
            this.btnOgleYemegiGeri.UseVisualStyleBackColor = false;
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
            this.btnOgleYemegiEkle.Location = new System.Drawing.Point(428, 440);
            this.btnOgleYemegiEkle.Name = "btnOgleYemegiEkle";
            this.btnOgleYemegiEkle.Size = new System.Drawing.Size(45, 45);
            this.btnOgleYemegiEkle.TabIndex = 37;
            this.btnOgleYemegiEkle.TextColor = System.Drawing.Color.Black;
            this.btnOgleYemegiEkle.UseVisualStyleBackColor = false;
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
            this.btnOgleYemegiSilme.Location = new System.Drawing.Point(888, 440);
            this.btnOgleYemegiSilme.Name = "btnOgleYemegiSilme";
            this.btnOgleYemegiSilme.Size = new System.Drawing.Size(45, 45);
            this.btnOgleYemegiSilme.TabIndex = 38;
            this.btnOgleYemegiSilme.TextColor = System.Drawing.Color.Black;
            this.btnOgleYemegiSilme.UseVisualStyleBackColor = false;
            // 
            // dgvOgleYemegiKullaniciListesi
            // 
            this.dgvOgleYemegiKullaniciListesi.BackgroundColor = System.Drawing.Color.White;
            this.dgvOgleYemegiKullaniciListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOgleYemegiKullaniciListesi.Location = new System.Drawing.Point(516, 234);
            this.dgvOgleYemegiKullaniciListesi.Name = "dgvOgleYemegiKullaniciListesi";
            this.dgvOgleYemegiKullaniciListesi.Size = new System.Drawing.Size(496, 200);
            this.dgvOgleYemegiKullaniciListesi.TabIndex = 41;
            // 
            // dgvOgleYemegiListe
            // 
            this.dgvOgleYemegiListe.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvOgleYemegiListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOgleYemegiListe.Location = new System.Drawing.Point(14, 234);
            this.dgvOgleYemegiListe.Name = "dgvOgleYemegiListe";
            this.dgvOgleYemegiListe.RowHeadersWidth = 51;
            this.dgvOgleYemegiListe.Size = new System.Drawing.Size(496, 200);
            this.dgvOgleYemegiListe.TabIndex = 40;
            // 
            // btnOgleAra
            // 
            this.btnOgleAra.BackColor = System.Drawing.Color.Transparent;
            this.btnOgleAra.BackgroundImage = global::DIYET_PROJE.Properties.Resources.search_FILL0_wght400_GRAD0_opsz48__1_;
            this.btnOgleAra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOgleAra.Location = new System.Drawing.Point(473, 190);
            this.btnOgleAra.Name = "btnOgleAra";
            this.btnOgleAra.Size = new System.Drawing.Size(37, 38);
            this.btnOgleAra.TabIndex = 44;
            this.btnOgleAra.UseVisualStyleBackColor = false;
            // 
            // txtOgleMiktar
            // 
            this.txtOgleMiktar.Location = new System.Drawing.Point(163, 453);
            this.txtOgleMiktar.Name = "txtOgleMiktar";
            this.txtOgleMiktar.Size = new System.Drawing.Size(157, 20);
            this.txtOgleMiktar.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(93, 451);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 45;
            this.label5.Text = "Miktar : ";
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DIYET_PROJE.Properties.Resources.WhatsApp_Image_2022_09_07_at_22_471;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 621);
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
            this.Controls.Add(this.btnOgleYemegiAnasayfa);
            this.Controls.Add(this.txtArananUrunOgleYemegi);
            this.Controls.Add(this.label1);
            this.Name = "Form11";
            this.Text = "Form11";
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
        private RJButton btnOgleYemegiAnasayfa;
        private RJButton btnOgleYemegiGeri;
        private RJButton btnOgleYemegiEkle;
        private RJButton btnOgleYemegiSilme;
        private System.Windows.Forms.DataGridView dgvOgleYemegiKullaniciListesi;
        private System.Windows.Forms.DataGridView dgvOgleYemegiListe;
        private System.Windows.Forms.Button btnOgleAra;
        private System.Windows.Forms.TextBox txtOgleMiktar;
        private System.Windows.Forms.Label label5;
    }
}