namespace DIYET_PROJE
{
    partial class Form10
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
            this.txtKahvalti = new System.Windows.Forms.TextBox();
            this.dgvKahvaltiListe = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvKahvaltiKullaniciListesi = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnGeriKahvaltiEkle = new DIYET_PROJE.RJButton();
            this.btnSilKahvalti = new DIYET_PROJE.RJButton();
            this.btnEkleKahvalti = new DIYET_PROJE.RJButton();
            this.btnAnasayfaKahvalti = new DIYET_PROJE.RJButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKahvaltiListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKahvaltiKullaniciListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKahvalti
            // 
            this.txtKahvalti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKahvalti.Location = new System.Drawing.Point(22, 134);
            this.txtKahvalti.Name = "txtKahvalti";
            this.txtKahvalti.Size = new System.Drawing.Size(293, 26);
            this.txtKahvalti.TabIndex = 21;
            this.txtKahvalti.Text = "Lütfen aradığınız ürünü giriniz";
            this.txtKahvalti.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtKahvalti_MouseClick);
            this.txtKahvalti.TextChanged += new System.EventHandler(this.txtKahvalti_TextChanged);
            // 
            // dgvKahvaltiListe
            // 
            this.dgvKahvaltiListe.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvKahvaltiListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKahvaltiListe.Location = new System.Drawing.Point(12, 166);
            this.dgvKahvaltiListe.Name = "dgvKahvaltiListe";
            this.dgvKahvaltiListe.RowHeadersWidth = 50;
            this.dgvKahvaltiListe.Size = new System.Drawing.Size(496, 200);
            this.dgvKahvaltiListe.TabIndex = 20;
            this.dgvKahvaltiListe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKahvaltiListe_CellContentClick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightSalmon;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 48);
            this.label1.TabIndex = 19;
            this.label1.Text = "KAHVALTI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(17, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 41);
            this.label2.TabIndex = 26;
            this.label2.Text = "Kahvaltı Ekle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(23, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(356, 18);
            this.label3.TabIndex = 27;
            this.label3.Text = "Lütfen kahvaltınızda tükettiğiniz tüm besinleri ekleyiniz";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::DIYET_PROJE.Properties.Resources.womfit_logo;
            this.pictureBox1.Location = new System.Drawing.Point(900, 526);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // dgvKahvaltiKullaniciListesi
            // 
            this.dgvKahvaltiKullaniciListesi.BackgroundColor = System.Drawing.Color.White;
            this.dgvKahvaltiKullaniciListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKahvaltiKullaniciListesi.Location = new System.Drawing.Point(515, 166);
            this.dgvKahvaltiKullaniciListesi.Name = "dgvKahvaltiKullaniciListesi";
            this.dgvKahvaltiKullaniciListesi.RowHeadersWidth = 51;
            this.dgvKahvaltiKullaniciListesi.Size = new System.Drawing.Size(496, 200);
            this.dgvKahvaltiKullaniciListesi.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(246, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 40;
            this.label5.Text = "Miktar";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(311, 382);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 22);
            this.textBox1.TabIndex = 42;
            // 
            // btnGeriKahvaltiEkle
            // 
            this.btnGeriKahvaltiEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnGeriKahvaltiEkle.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnGeriKahvaltiEkle.BackgroundImage = global::DIYET_PROJE.Properties.Resources.Back_Button_PNG_Pic;
            this.btnGeriKahvaltiEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGeriKahvaltiEkle.BorderColor = System.Drawing.Color.LightCoral;
            this.btnGeriKahvaltiEkle.BorderRadius = 0;
            this.btnGeriKahvaltiEkle.BorderSize = 0;
            this.btnGeriKahvaltiEkle.FlatAppearance.BorderSize = 0;
            this.btnGeriKahvaltiEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeriKahvaltiEkle.ForeColor = System.Drawing.Color.Black;
            this.btnGeriKahvaltiEkle.Location = new System.Drawing.Point(44, 434);
            this.btnGeriKahvaltiEkle.Name = "btnGeriKahvaltiEkle";
            this.btnGeriKahvaltiEkle.Size = new System.Drawing.Size(45, 45);
            this.btnGeriKahvaltiEkle.TabIndex = 25;
            this.btnGeriKahvaltiEkle.TextColor = System.Drawing.Color.Black;
            this.btnGeriKahvaltiEkle.UseVisualStyleBackColor = false;
            // 
            // btnSilKahvalti
            // 
            this.btnSilKahvalti.BackColor = System.Drawing.Color.Transparent;
            this.btnSilKahvalti.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnSilKahvalti.BackgroundImage = global::DIYET_PROJE.Properties.Resources.remove_FILL0_wght400_GRAD0_opsz481;
            this.btnSilKahvalti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSilKahvalti.BorderColor = System.Drawing.Color.LightCoral;
            this.btnSilKahvalti.BorderRadius = 0;
            this.btnSilKahvalti.BorderSize = 0;
            this.btnSilKahvalti.FlatAppearance.BorderSize = 0;
            this.btnSilKahvalti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSilKahvalti.ForeColor = System.Drawing.Color.Black;
            this.btnSilKahvalti.Location = new System.Drawing.Point(839, 553);
            this.btnSilKahvalti.Name = "btnSilKahvalti";
            this.btnSilKahvalti.Size = new System.Drawing.Size(45, 45);
            this.btnSilKahvalti.TabIndex = 24;
            this.btnSilKahvalti.TextColor = System.Drawing.Color.Black;
            this.btnSilKahvalti.UseVisualStyleBackColor = false;
            // 
            // btnEkleKahvalti
            // 
            this.btnEkleKahvalti.BackColor = System.Drawing.Color.Transparent;
            this.btnEkleKahvalti.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnEkleKahvalti.BackgroundImage = global::DIYET_PROJE.Properties.Resources.add_FILL0_wght400_GRAD0_opsz481;
            this.btnEkleKahvalti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEkleKahvalti.BorderColor = System.Drawing.Color.LightCoral;
            this.btnEkleKahvalti.BorderRadius = 0;
            this.btnEkleKahvalti.BorderSize = 0;
            this.btnEkleKahvalti.FlatAppearance.BorderSize = 0;
            this.btnEkleKahvalti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkleKahvalti.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkleKahvalti.ForeColor = System.Drawing.Color.Black;
            this.btnEkleKahvalti.Location = new System.Drawing.Point(788, 553);
            this.btnEkleKahvalti.Name = "btnEkleKahvalti";
            this.btnEkleKahvalti.Size = new System.Drawing.Size(45, 45);
            this.btnEkleKahvalti.TabIndex = 23;
            this.btnEkleKahvalti.TextColor = System.Drawing.Color.Black;
            this.btnEkleKahvalti.UseVisualStyleBackColor = false;
            // 
            // btnAnasayfaKahvalti
            // 
            this.btnAnasayfaKahvalti.BackColor = System.Drawing.Color.Transparent;
            this.btnAnasayfaKahvalti.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnAnasayfaKahvalti.BackgroundImage = global::DIYET_PROJE.Properties.Resources._171532;
            this.btnAnasayfaKahvalti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnasayfaKahvalti.BorderColor = System.Drawing.Color.LightCoral;
            this.btnAnasayfaKahvalti.BorderRadius = 0;
            this.btnAnasayfaKahvalti.BorderSize = 0;
            this.btnAnasayfaKahvalti.FlatAppearance.BorderSize = 0;
            this.btnAnasayfaKahvalti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnasayfaKahvalti.ForeColor = System.Drawing.Color.Black;
            this.btnAnasayfaKahvalti.Location = new System.Drawing.Point(104, 436);
            this.btnAnasayfaKahvalti.Name = "btnAnasayfaKahvalti";
            this.btnAnasayfaKahvalti.Size = new System.Drawing.Size(40, 40);
            this.btnAnasayfaKahvalti.TabIndex = 22;
            this.btnAnasayfaKahvalti.TextColor = System.Drawing.Color.Black;
            this.btnAnasayfaKahvalti.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(321, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 43;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form10
            // 
            this.BackgroundImage = global::DIYET_PROJE.Properties.Resources.WhatsApp_Image_2022_09_07_at_22_471;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1004, 621);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvKahvaltiKullaniciListesi);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGeriKahvaltiEkle);
            this.Controls.Add(this.btnSilKahvalti);
            this.Controls.Add(this.btnEkleKahvalti);
            this.Controls.Add(this.btnAnasayfaKahvalti);
            this.Controls.Add(this.txtKahvalti);
            this.Controls.Add(this.dgvKahvaltiListe);
            this.Controls.Add(this.label1);
            this.Name = "Form10";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKahvaltiListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKahvaltiKullaniciListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJButton btnGeriKahvaltiEkle;
        private RJButton btnSilKahvalti;
        private RJButton btnEkleKahvalti;
        private RJButton btnAnasayfaKahvalti;
        private System.Windows.Forms.TextBox txtKahvalti;
        private System.Windows.Forms.DataGridView dgvKahvaltiListe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvKahvaltiKullaniciListesi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}