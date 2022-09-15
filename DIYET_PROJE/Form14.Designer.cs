namespace DIYET_PROJE
{
    partial class Form14
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
            this.txtEgzersiz = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnEgzersizSilme = new DIYET_PROJE.RJButton();
            this.btnEgzersizEkleme = new DIYET_PROJE.RJButton();
            this.btnEgzersiGeri = new DIYET_PROJE.RJButton();
            this.btnEgzersiAnasayfa = new DIYET_PROJE.RJButton();
            this.dgvEgzersizKullanicininListesi = new System.Windows.Forms.DataGridView();
            this.dgvEgzersizListe = new System.Windows.Forms.DataGridView();
            this.btnEgzersizAra = new System.Windows.Forms.Button();
            this.txtEgzersizMiktar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEgzersizKullanicininListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEgzersizListe)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(27, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 15);
            this.label3.TabIndex = 36;
            this.label3.Text = "Lütfen gün içinde yaptığınız egzersizleri ekleyiniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(22, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 33);
            this.label2.TabIndex = 35;
            this.label2.Text = "Egzersiz Ekle";
            // 
            // txtEgzersiz
            // 
            this.txtEgzersiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEgzersiz.Location = new System.Drawing.Point(11, 159);
            this.txtEgzersiz.Margin = new System.Windows.Forms.Padding(2);
            this.txtEgzersiz.Multiline = true;
            this.txtEgzersiz.Name = "txtEgzersiz";
            this.txtEgzersiz.Size = new System.Drawing.Size(459, 38);
            this.txtEgzersiz.TabIndex = 30;
            this.txtEgzersiz.Text = "Lütfen aradığınız egzersizi girin";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightSalmon;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(497, 61);
            this.label1.TabIndex = 28;
            this.label1.Text = "EGZERSİZLER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = global::DIYET_PROJE.Properties.Resources.womfit_logo;
            this.pictureBox2.Location = new System.Drawing.Point(936, 526);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(77, 84);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 44;
            this.pictureBox2.TabStop = false;
            // 
            // btnEgzersizSilme
            // 
            this.btnEgzersizSilme.BackColor = System.Drawing.Color.Transparent;
            this.btnEgzersizSilme.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnEgzersizSilme.BackgroundImage = global::DIYET_PROJE.Properties.Resources.remove_FILL0_wght400_GRAD0_opsz481;
            this.btnEgzersizSilme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEgzersizSilme.BorderColor = System.Drawing.Color.LightCoral;
            this.btnEgzersizSilme.BorderRadius = 0;
            this.btnEgzersizSilme.BorderSize = 0;
            this.btnEgzersizSilme.FlatAppearance.BorderSize = 0;
            this.btnEgzersizSilme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEgzersizSilme.ForeColor = System.Drawing.Color.Black;
            this.btnEgzersizSilme.Location = new System.Drawing.Point(903, 409);
            this.btnEgzersizSilme.Name = "btnEgzersizSilme";
            this.btnEgzersizSilme.Size = new System.Drawing.Size(45, 45);
            this.btnEgzersizSilme.TabIndex = 48;
            this.btnEgzersizSilme.TextColor = System.Drawing.Color.Black;
            this.btnEgzersizSilme.UseVisualStyleBackColor = false;
            // 
            // btnEgzersizEkleme
            // 
            this.btnEgzersizEkleme.BackColor = System.Drawing.Color.Transparent;
            this.btnEgzersizEkleme.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnEgzersizEkleme.BackgroundImage = global::DIYET_PROJE.Properties.Resources.add_FILL0_wght400_GRAD0_opsz481;
            this.btnEgzersizEkleme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEgzersizEkleme.BorderColor = System.Drawing.Color.LightCoral;
            this.btnEgzersizEkleme.BorderRadius = 0;
            this.btnEgzersizEkleme.BorderSize = 0;
            this.btnEgzersizEkleme.FlatAppearance.BorderSize = 0;
            this.btnEgzersizEkleme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEgzersizEkleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEgzersizEkleme.ForeColor = System.Drawing.Color.Black;
            this.btnEgzersizEkleme.Location = new System.Drawing.Point(429, 409);
            this.btnEgzersizEkleme.Name = "btnEgzersizEkleme";
            this.btnEgzersizEkleme.Size = new System.Drawing.Size(45, 45);
            this.btnEgzersizEkleme.TabIndex = 47;
            this.btnEgzersizEkleme.TextColor = System.Drawing.Color.Black;
            this.btnEgzersizEkleme.UseVisualStyleBackColor = false;
            // 
            // btnEgzersiGeri
            // 
            this.btnEgzersiGeri.BackColor = System.Drawing.Color.Transparent;
            this.btnEgzersiGeri.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnEgzersiGeri.BackgroundImage = global::DIYET_PROJE.Properties.Resources.Back_Button_PNG_Pic;
            this.btnEgzersiGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEgzersiGeri.BorderColor = System.Drawing.Color.LightCoral;
            this.btnEgzersiGeri.BorderRadius = 0;
            this.btnEgzersiGeri.BorderSize = 0;
            this.btnEgzersiGeri.FlatAppearance.BorderSize = 0;
            this.btnEgzersiGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEgzersiGeri.ForeColor = System.Drawing.Color.Black;
            this.btnEgzersiGeri.Location = new System.Drawing.Point(26, 547);
            this.btnEgzersiGeri.Margin = new System.Windows.Forms.Padding(2);
            this.btnEgzersiGeri.Name = "btnEgzersiGeri";
            this.btnEgzersiGeri.Size = new System.Drawing.Size(37, 41);
            this.btnEgzersiGeri.TabIndex = 46;
            this.btnEgzersiGeri.TextColor = System.Drawing.Color.Black;
            this.btnEgzersiGeri.UseVisualStyleBackColor = false;
            // 
            // btnEgzersiAnasayfa
            // 
            this.btnEgzersiAnasayfa.BackColor = System.Drawing.Color.Transparent;
            this.btnEgzersiAnasayfa.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnEgzersiAnasayfa.BackgroundImage = global::DIYET_PROJE.Properties.Resources._171532;
            this.btnEgzersiAnasayfa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEgzersiAnasayfa.BorderColor = System.Drawing.Color.LightCoral;
            this.btnEgzersiAnasayfa.BorderRadius = 0;
            this.btnEgzersiAnasayfa.BorderSize = 0;
            this.btnEgzersiAnasayfa.FlatAppearance.BorderSize = 0;
            this.btnEgzersiAnasayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEgzersiAnasayfa.ForeColor = System.Drawing.Color.Black;
            this.btnEgzersiAnasayfa.Location = new System.Drawing.Point(85, 547);
            this.btnEgzersiAnasayfa.Margin = new System.Windows.Forms.Padding(2);
            this.btnEgzersiAnasayfa.Name = "btnEgzersiAnasayfa";
            this.btnEgzersiAnasayfa.Size = new System.Drawing.Size(32, 36);
            this.btnEgzersiAnasayfa.TabIndex = 45;
            this.btnEgzersiAnasayfa.TextColor = System.Drawing.Color.Black;
            this.btnEgzersiAnasayfa.UseVisualStyleBackColor = false;
            // 
            // dgvEgzersizKullanicininListesi
            // 
            this.dgvEgzersizKullanicininListesi.BackgroundColor = System.Drawing.Color.White;
            this.dgvEgzersizKullanicininListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEgzersizKullanicininListesi.Location = new System.Drawing.Point(517, 203);
            this.dgvEgzersizKullanicininListesi.Name = "dgvEgzersizKullanicininListesi";
            this.dgvEgzersizKullanicininListesi.Size = new System.Drawing.Size(496, 200);
            this.dgvEgzersizKullanicininListesi.TabIndex = 50;
            // 
            // dgvEgzersizListe
            // 
            this.dgvEgzersizListe.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvEgzersizListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEgzersizListe.Location = new System.Drawing.Point(12, 203);
            this.dgvEgzersizListe.Name = "dgvEgzersizListe";
            this.dgvEgzersizListe.RowHeadersWidth = 51;
            this.dgvEgzersizListe.Size = new System.Drawing.Size(496, 200);
            this.dgvEgzersizListe.TabIndex = 49;
            // 
            // btnEgzersizAra
            // 
            this.btnEgzersizAra.BackColor = System.Drawing.Color.Transparent;
            this.btnEgzersizAra.BackgroundImage = global::DIYET_PROJE.Properties.Resources.search_FILL0_wght400_GRAD0_opsz48__1_;
            this.btnEgzersizAra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEgzersizAra.Location = new System.Drawing.Point(471, 159);
            this.btnEgzersizAra.Name = "btnEgzersizAra";
            this.btnEgzersizAra.Size = new System.Drawing.Size(37, 38);
            this.btnEgzersizAra.TabIndex = 51;
            this.btnEgzersizAra.UseVisualStyleBackColor = false;
            // 
            // txtEgzersizMiktar
            // 
            this.txtEgzersizMiktar.Location = new System.Drawing.Point(203, 420);
            this.txtEgzersizMiktar.Name = "txtEgzersizMiktar";
            this.txtEgzersizMiktar.Size = new System.Drawing.Size(157, 20);
            this.txtEgzersizMiktar.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(133, 420);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 52;
            this.label5.Text = "Miktar : ";
            // 
            // Form14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DIYET_PROJE.Properties.Resources.WhatsApp_Image_2022_09_07_at_22_471;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 621);
            this.Controls.Add(this.txtEgzersizMiktar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEgzersizAra);
            this.Controls.Add(this.dgvEgzersizKullanicininListesi);
            this.Controls.Add(this.dgvEgzersizListe);
            this.Controls.Add(this.btnEgzersizSilme);
            this.Controls.Add(this.btnEgzersizEkleme);
            this.Controls.Add(this.btnEgzersiGeri);
            this.Controls.Add(this.btnEgzersiAnasayfa);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEgzersiz);
            this.Controls.Add(this.label1);
            this.Name = "Form14";
            this.Text = "Form14";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEgzersizKullanicininListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEgzersizListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEgzersiz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private RJButton btnEgzersizSilme;
        private RJButton btnEgzersizEkleme;
        private RJButton btnEgzersiGeri;
        private RJButton btnEgzersiAnasayfa;
        private System.Windows.Forms.DataGridView dgvEgzersizKullanicininListesi;
        private System.Windows.Forms.DataGridView dgvEgzersizListe;
        private System.Windows.Forms.Button btnEgzersizAra;
        private System.Windows.Forms.TextBox txtEgzersizMiktar;
        private System.Windows.Forms.Label label5;
    }
}