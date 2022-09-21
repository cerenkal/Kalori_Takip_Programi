namespace DIYET_PROJE
{
    partial class Form15
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
            this.btnKacKaloriGeri = new DIYET_PROJE.RJButton();
            this.txtKacKoleriBesinGİr = new System.Windows.Forms.TextBox();
            this.dgvKacKolariBesinListele = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.lblKalori = new System.Windows.Forms.Label();
            this.lblKarbonhidrat = new System.Windows.Forms.Label();
            this.lblProtein = new System.Windows.Forms.Label();
            this.lblYag = new System.Windows.Forms.Label();
            this.btnKacKolariBesinAra = new DIYET_PROJE.RJButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnIncele = new DIYET_PROJE.RJButton();
            this.lblKacKaloriOlcu = new System.Windows.Forms.Label();
            this.txtKacKolariMiktar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKacKolariBesinListele)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(37, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(357, 18);
            this.label3.TabIndex = 36;
            this.label3.Text = "Kalorisini öğrenmek istediğiniz besinleri arayabilirsiniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(31, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 41);
            this.label2.TabIndex = 35;
            this.label2.Text = "Kaç Kalori?";
            // 
            // btnKacKaloriGeri
            // 
            this.btnKacKaloriGeri.BackColor = System.Drawing.Color.Transparent;
            this.btnKacKaloriGeri.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnKacKaloriGeri.BackgroundImage = global::DIYET_PROJE.Properties.Resources.Back_Button_PNG_Pic;
            this.btnKacKaloriGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKacKaloriGeri.BorderColor = System.Drawing.Color.LightCoral;
            this.btnKacKaloriGeri.BorderRadius = 0;
            this.btnKacKaloriGeri.BorderSize = 0;
            this.btnKacKaloriGeri.FlatAppearance.BorderSize = 0;
            this.btnKacKaloriGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKacKaloriGeri.ForeColor = System.Drawing.Color.Black;
            this.btnKacKaloriGeri.Location = new System.Drawing.Point(-1, 566);
            this.btnKacKaloriGeri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKacKaloriGeri.Name = "btnKacKaloriGeri";
            this.btnKacKaloriGeri.Size = new System.Drawing.Size(53, 49);
            this.btnKacKaloriGeri.TabIndex = 34;
            this.btnKacKaloriGeri.TextColor = System.Drawing.Color.Black;
            this.btnKacKaloriGeri.UseVisualStyleBackColor = false;
            // 
            // txtKacKoleriBesinGİr
            // 
            this.txtKacKoleriBesinGİr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKacKoleriBesinGİr.Location = new System.Drawing.Point(38, 201);
            this.txtKacKoleriBesinGİr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKacKoleriBesinGİr.Name = "txtKacKoleriBesinGİr";
            this.txtKacKoleriBesinGİr.Size = new System.Drawing.Size(256, 26);
            this.txtKacKoleriBesinGİr.TabIndex = 30;
            this.txtKacKoleriBesinGİr.Text = "Lütfen aradığınız ürünü giriniz";
            this.txtKacKoleriBesinGİr.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtKacKoleriBesinGİr_MouseClick);
            // 
            // dgvKacKolariBesinListele
            // 
            this.dgvKacKolariBesinListele.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvKacKolariBesinListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKacKolariBesinListele.Location = new System.Drawing.Point(38, 243);
            this.dgvKacKolariBesinListele.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvKacKolariBesinListele.Name = "dgvKacKolariBesinListele";
            this.dgvKacKolariBesinListele.RowHeadersWidth = 51;
            this.dgvKacKolariBesinListele.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKacKolariBesinListele.Size = new System.Drawing.Size(579, 169);
            this.dgvKacKolariBesinListele.TabIndex = 29;
            this.dgvKacKolariBesinListele.SelectionChanged += new System.EventHandler(this.dgvKacKolariBesinListele_SelectionChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightSalmon;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 48);
            this.label1.TabIndex = 28;
            this.label1.Text = "KALORİ BİLGİSİ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label23.Location = new System.Drawing.Point(653, 308);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(38, 21);
            this.label23.TabIndex = 62;
            this.label23.Text = "Yağ:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label24.Location = new System.Drawing.Point(653, 287);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(66, 21);
            this.label24.TabIndex = 61;
            this.label24.Text = "Protein:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label25.Location = new System.Drawing.Point(653, 266);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(107, 21);
            this.label25.TabIndex = 60;
            this.label25.Text = "Karbonhidrat:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label26.Location = new System.Drawing.Point(653, 245);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(55, 21);
            this.label26.TabIndex = 59;
            this.label26.Text = "Kalori:";
            // 
            // lblKalori
            // 
            this.lblKalori.AutoSize = true;
            this.lblKalori.BackColor = System.Drawing.Color.Transparent;
            this.lblKalori.Location = new System.Drawing.Point(809, 245);
            this.lblKalori.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKalori.Name = "lblKalori";
            this.lblKalori.Size = new System.Drawing.Size(61, 17);
            this.lblKalori.TabIndex = 63;
            this.lblKalori.Text = "390 kcal";
            // 
            // lblKarbonhidrat
            // 
            this.lblKarbonhidrat.AutoSize = true;
            this.lblKarbonhidrat.BackColor = System.Drawing.Color.Transparent;
            this.lblKarbonhidrat.Location = new System.Drawing.Point(809, 268);
            this.lblKarbonhidrat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKarbonhidrat.Name = "lblKarbonhidrat";
            this.lblKarbonhidrat.Size = new System.Drawing.Size(41, 17);
            this.lblKarbonhidrat.TabIndex = 64;
            this.lblKarbonhidrat.Text = "80 gr";
            // 
            // lblProtein
            // 
            this.lblProtein.AutoSize = true;
            this.lblProtein.BackColor = System.Drawing.Color.Transparent;
            this.lblProtein.Location = new System.Drawing.Point(809, 289);
            this.lblProtein.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProtein.Name = "lblProtein";
            this.lblProtein.Size = new System.Drawing.Size(41, 17);
            this.lblProtein.TabIndex = 65;
            this.lblProtein.Text = "30 gr";
            // 
            // lblYag
            // 
            this.lblYag.AutoSize = true;
            this.lblYag.BackColor = System.Drawing.Color.Transparent;
            this.lblYag.Location = new System.Drawing.Point(809, 313);
            this.lblYag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYag.Name = "lblYag";
            this.lblYag.Size = new System.Drawing.Size(41, 17);
            this.lblYag.TabIndex = 66;
            this.lblYag.Text = "15 gr";
            // 
            // btnKacKolariBesinAra
            // 
            this.btnKacKolariBesinAra.BackColor = System.Drawing.Color.Transparent;
            this.btnKacKolariBesinAra.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnKacKolariBesinAra.BackgroundImage = global::DIYET_PROJE.Properties.Resources.search_FILL0_wght400_GRAD0_opsz48__1_;
            this.btnKacKolariBesinAra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKacKolariBesinAra.BorderColor = System.Drawing.Color.LightCoral;
            this.btnKacKolariBesinAra.BorderRadius = 0;
            this.btnKacKolariBesinAra.BorderSize = 0;
            this.btnKacKolariBesinAra.FlatAppearance.BorderSize = 0;
            this.btnKacKolariBesinAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKacKolariBesinAra.ForeColor = System.Drawing.Color.Black;
            this.btnKacKolariBesinAra.Location = new System.Drawing.Point(311, 197);
            this.btnKacKolariBesinAra.Margin = new System.Windows.Forms.Padding(4);
            this.btnKacKolariBesinAra.Name = "btnKacKolariBesinAra";
            this.btnKacKolariBesinAra.Size = new System.Drawing.Size(37, 36);
            this.btnKacKolariBesinAra.TabIndex = 67;
            this.btnKacKolariBesinAra.TextColor = System.Drawing.Color.Black;
            this.btnKacKolariBesinAra.UseVisualStyleBackColor = false;
            this.btnKacKolariBesinAra.Click += new System.EventHandler(this.btnKacKolariBesinAra_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = global::DIYET_PROJE.Properties.Resources.womfit_logo;
            this.pictureBox2.Location = new System.Drawing.Point(888, 512);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(103, 103);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 68;
            this.pictureBox2.TabStop = false;
            // 
            // btnIncele
            // 
            this.btnIncele.BackColor = System.Drawing.Color.LightSalmon;
            this.btnIncele.BackgroundColor = System.Drawing.Color.LightSalmon;
            this.btnIncele.BorderColor = System.Drawing.Color.LightCoral;
            this.btnIncele.BorderRadius = 20;
            this.btnIncele.BorderSize = 0;
            this.btnIncele.FlatAppearance.BorderSize = 0;
            this.btnIncele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncele.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIncele.ForeColor = System.Drawing.Color.White;
            this.btnIncele.Location = new System.Drawing.Point(492, 416);
            this.btnIncele.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIncele.Name = "btnIncele";
            this.btnIncele.Size = new System.Drawing.Size(125, 37);
            this.btnIncele.TabIndex = 69;
            this.btnIncele.Text = "İncele";
            this.btnIncele.TextColor = System.Drawing.Color.White;
            this.btnIncele.UseVisualStyleBackColor = false;
            this.btnIncele.Click += new System.EventHandler(this.btnIncele_Click);
            // 
            // lblKacKaloriOlcu
            // 
            this.lblKacKaloriOlcu.AutoSize = true;
            this.lblKacKaloriOlcu.Location = new System.Drawing.Point(284, 427);
            this.lblKacKaloriOlcu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKacKaloriOlcu.Name = "lblKacKaloriOlcu";
            this.lblKacKaloriOlcu.Size = new System.Drawing.Size(40, 17);
            this.lblKacKaloriOlcu.TabIndex = 72;
            this.lblKacKaloriOlcu.Text = "gram";
            // 
            // txtKacKolariMiktar
            // 
            this.txtKacKolariMiktar.Location = new System.Drawing.Point(106, 421);
            this.txtKacKolariMiktar.Name = "txtKacKolariMiktar";
            this.txtKacKolariMiktar.Size = new System.Drawing.Size(157, 22);
            this.txtKacKolariMiktar.TabIndex = 71;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label5.Location = new System.Drawing.Point(36, 424);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 70;
            this.label5.Text = "Miktar : ";
            // 
            // Form15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DIYET_PROJE.Properties.Resources.WhatsApp_Image_2022_09_07_at_22_471;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1005, 629);
            this.Controls.Add(this.lblKacKaloriOlcu);
            this.Controls.Add(this.txtKacKolariMiktar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnIncele);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnKacKolariBesinAra);
            this.Controls.Add(this.lblYag);
            this.Controls.Add(this.lblProtein);
            this.Controls.Add(this.lblKarbonhidrat);
            this.Controls.Add(this.lblKalori);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnKacKaloriGeri);
            this.Controls.Add(this.txtKacKoleriBesinGİr);
            this.Controls.Add(this.dgvKacKolariBesinListele);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form15";
            this.Text = "Form15";
            this.Load += new System.EventHandler(this.Form15_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKacKolariBesinListele)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private RJButton btnKacKaloriGeri;
        private System.Windows.Forms.TextBox txtKacKoleriBesinGİr;
        private System.Windows.Forms.DataGridView dgvKacKolariBesinListele;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lblKalori;
        private System.Windows.Forms.Label lblKarbonhidrat;
        private System.Windows.Forms.Label lblProtein;
        private System.Windows.Forms.Label lblYag;
        private RJButton btnKacKolariBesinAra;
        private System.Windows.Forms.PictureBox pictureBox2;
        private RJButton btnIncele;
        private System.Windows.Forms.Label lblKacKaloriOlcu;
        private System.Windows.Forms.TextBox txtKacKolariMiktar;
        private System.Windows.Forms.Label label5;
    }
}