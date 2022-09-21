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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtKahvalti = new System.Windows.Forms.TextBox();
            this.dgvKahvaltiListe = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKahvaltiMiktar = new System.Windows.Forms.TextBox();
            this.btnGeriKahvaltiEkle = new DIYET_PROJE.RJButton();
            this.btnSilKahvalti = new DIYET_PROJE.RJButton();
            this.btnEkleKahvalti = new DIYET_PROJE.RJButton();
            this.btnKahvaltiAra = new System.Windows.Forms.Button();
            this.lblKahvaltıOlcu = new System.Windows.Forms.Label();
            this.dgvKahvaltiKullaniciListesi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKahvaltiListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKahvaltiKullaniciListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKahvalti
            // 
            this.txtKahvalti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKahvalti.Location = new System.Drawing.Point(172, 191);
            this.txtKahvalti.Multiline = true;
            this.txtKahvalti.Name = "txtKahvalti";
            this.txtKahvalti.Size = new System.Drawing.Size(459, 34);
            this.txtKahvalti.TabIndex = 21;
            this.txtKahvalti.Text = "Lütfen aradığınız ürünü giriniz";
            this.txtKahvalti.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtKahvalti_MouseClick);
            // 
            // dgvKahvaltiListe
            // 
            this.dgvKahvaltiListe.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKahvaltiListe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKahvaltiListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKahvaltiListe.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvKahvaltiListe.Location = new System.Drawing.Point(172, 231);
            this.dgvKahvaltiListe.Name = "dgvKahvaltiListe";
            this.dgvKahvaltiListe.RowHeadersWidth = 50;
            this.dgvKahvaltiListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKahvaltiListe.Size = new System.Drawing.Size(496, 200);
            this.dgvKahvaltiListe.TabIndex = 20;
            this.dgvKahvaltiListe.SelectionChanged += new System.EventHandler(this.dgvKahvaltiListe_SelectionChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightSalmon;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(172, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 65);
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
            this.label2.Location = new System.Drawing.Point(14, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 41);
            this.label2.TabIndex = 26;
            this.label2.Text = "Kahvaltı Ekle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(17, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(391, 21);
            this.label3.TabIndex = 27;
            this.label3.Text = "Lütfen kahvaltınızda tükettiğiniz tüm besinleri ekleyiniz";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::DIYET_PROJE.Properties.Resources.womfit_logo;
            this.pictureBox1.Location = new System.Drawing.Point(901, 510);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(171, 444);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 25);
            this.label5.TabIndex = 40;
            this.label5.Text = "Miktar : ";
            // 
            // txtKahvaltiMiktar
            // 
            this.txtKahvaltiMiktar.Location = new System.Drawing.Point(234, 441);
            this.txtKahvaltiMiktar.Name = "txtKahvaltiMiktar";
            this.txtKahvaltiMiktar.Size = new System.Drawing.Size(64, 30);
            this.txtKahvaltiMiktar.TabIndex = 42;
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
            this.btnGeriKahvaltiEkle.Location = new System.Drawing.Point(21, 546);
            this.btnGeriKahvaltiEkle.Name = "btnGeriKahvaltiEkle";
            this.btnGeriKahvaltiEkle.Size = new System.Drawing.Size(50, 51);
            this.btnGeriKahvaltiEkle.TabIndex = 25;
            this.btnGeriKahvaltiEkle.TextColor = System.Drawing.Color.Black;
            this.btnGeriKahvaltiEkle.UseVisualStyleBackColor = false;
            this.btnGeriKahvaltiEkle.Click += new System.EventHandler(this.btnGeriKahvaltiEkle_Click);
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
            this.btnSilKahvalti.Location = new System.Drawing.Point(857, 435);
            this.btnSilKahvalti.Name = "btnSilKahvalti";
            this.btnSilKahvalti.Size = new System.Drawing.Size(45, 45);
            this.btnSilKahvalti.TabIndex = 24;
            this.btnSilKahvalti.TextColor = System.Drawing.Color.Black;
            this.btnSilKahvalti.UseVisualStyleBackColor = false;
            this.btnSilKahvalti.Click += new System.EventHandler(this.btnSilKahvalti_Click);
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
            this.btnEkleKahvalti.Location = new System.Drawing.Point(614, 435);
            this.btnEkleKahvalti.Name = "btnEkleKahvalti";
            this.btnEkleKahvalti.Size = new System.Drawing.Size(45, 45);
            this.btnEkleKahvalti.TabIndex = 23;
            this.btnEkleKahvalti.TextColor = System.Drawing.Color.Black;
            this.btnEkleKahvalti.UseVisualStyleBackColor = false;
            this.btnEkleKahvalti.Click += new System.EventHandler(this.btnEkleKahvalti_Click);
            // 
            // btnKahvaltiAra
            // 
            this.btnKahvaltiAra.BackColor = System.Drawing.Color.Transparent;
            this.btnKahvaltiAra.BackgroundImage = global::DIYET_PROJE.Properties.Resources.search_FILL0_wght400_GRAD0_opsz48__1_;
            this.btnKahvaltiAra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKahvaltiAra.Location = new System.Drawing.Point(631, 191);
            this.btnKahvaltiAra.Name = "btnKahvaltiAra";
            this.btnKahvaltiAra.Size = new System.Drawing.Size(37, 34);
            this.btnKahvaltiAra.TabIndex = 43;
            this.btnKahvaltiAra.UseVisualStyleBackColor = false;
            this.btnKahvaltiAra.Click += new System.EventHandler(this.btnKahvaltiAra_Click);
            // 
            // lblKahvaltıOlcu
            // 
            this.lblKahvaltıOlcu.AutoSize = true;
            this.lblKahvaltıOlcu.BackColor = System.Drawing.Color.Transparent;
            this.lblKahvaltıOlcu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKahvaltıOlcu.Location = new System.Drawing.Point(302, 445);
            this.lblKahvaltıOlcu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKahvaltıOlcu.Name = "lblKahvaltıOlcu";
            this.lblKahvaltıOlcu.Size = new System.Drawing.Size(56, 25);
            this.lblKahvaltıOlcu.TabIndex = 52;
            this.lblKahvaltıOlcu.Text = "gram";
            // 
            // dgvKahvaltiKullaniciListesi
            // 
            this.dgvKahvaltiKullaniciListesi.BackgroundColor = System.Drawing.Color.White;
            this.dgvKahvaltiKullaniciListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKahvaltiKullaniciListesi.Location = new System.Drawing.Point(674, 231);
            this.dgvKahvaltiKullaniciListesi.Name = "dgvKahvaltiKullaniciListesi";
            this.dgvKahvaltiKullaniciListesi.RowHeadersWidth = 51;
            this.dgvKahvaltiKullaniciListesi.Size = new System.Drawing.Size(228, 200);
            this.dgvKahvaltiKullaniciListesi.TabIndex = 38;
            // 
            // Form10
            // 
            this.BackgroundImage = global::DIYET_PROJE.Properties.Resources.WhatsApp_Image_2022_09_07_at_22_471;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 621);
            this.Controls.Add(this.lblKahvaltıOlcu);
            this.Controls.Add(this.btnKahvaltiAra);
            this.Controls.Add(this.txtKahvaltiMiktar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvKahvaltiKullaniciListesi);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGeriKahvaltiEkle);
            this.Controls.Add(this.btnSilKahvalti);
            this.Controls.Add(this.btnEkleKahvalti);
            this.Controls.Add(this.txtKahvalti);
            this.Controls.Add(this.dgvKahvaltiListe);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form10";
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
        private System.Windows.Forms.TextBox txtKahvalti;
        private System.Windows.Forms.DataGridView dgvKahvaltiListe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKahvaltiMiktar;
        private System.Windows.Forms.Button btnKahvaltiAra;
        private System.Windows.Forms.Label lblKahvaltıOlcu;
        private System.Windows.Forms.DataGridView dgvKahvaltiKullaniciListesi;
    }
}