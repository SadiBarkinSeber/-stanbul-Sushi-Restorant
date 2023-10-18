namespace İstanbul_Restorant
{
	partial class SiparisIslemleriEkrani
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbMenu = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbBuyuk = new System.Windows.Forms.RadioButton();
            this.rbOrta = new System.Windows.Forms.RadioButton();
            this.rbKucuk = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.numAdet = new System.Windows.Forms.NumericUpDown();
            this.btnSiparisEkle = new System.Windows.Forms.Button();
            this.lbSiparis = new System.Windows.Forms.ListBox();
            this.btnSiparisOnayla = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblToplamFiyat = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menü Seçiniz";
            // 
            // cbMenu
            // 
            this.cbMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMenu.FormattingEnabled = true;
            this.cbMenu.Location = new System.Drawing.Point(19, 225);
            this.cbMenu.Name = "cbMenu";
            this.cbMenu.Size = new System.Drawing.Size(220, 28);
            this.cbMenu.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rbBuyuk);
            this.groupBox1.Controls.Add(this.rbOrta);
            this.groupBox1.Controls.Add(this.rbKucuk);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(17, 464);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 91);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Boyutu Seçiniz";
            // 
            // rbBuyuk
            // 
            this.rbBuyuk.AutoSize = true;
            this.rbBuyuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBuyuk.Location = new System.Drawing.Point(144, 37);
            this.rbBuyuk.Name = "rbBuyuk";
            this.rbBuyuk.Size = new System.Drawing.Size(71, 24);
            this.rbBuyuk.TabIndex = 2;
            this.rbBuyuk.TabStop = true;
            this.rbBuyuk.Text = "Büyük";
            this.rbBuyuk.UseVisualStyleBackColor = true;
            // 
            // rbOrta
            // 
            this.rbOrta.AutoSize = true;
            this.rbOrta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOrta.Location = new System.Drawing.Point(82, 37);
            this.rbOrta.Name = "rbOrta";
            this.rbOrta.Size = new System.Drawing.Size(58, 24);
            this.rbOrta.TabIndex = 1;
            this.rbOrta.TabStop = true;
            this.rbOrta.Text = "Orta";
            this.rbOrta.UseVisualStyleBackColor = true;
            // 
            // rbKucuk
            // 
            this.rbKucuk.AutoSize = true;
            this.rbKucuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbKucuk.Location = new System.Drawing.Point(7, 37);
            this.rbKucuk.Name = "rbKucuk";
            this.rbKucuk.Size = new System.Drawing.Size(71, 24);
            this.rbKucuk.TabIndex = 0;
            this.rbKucuk.TabStop = true;
            this.rbKucuk.Text = "Küçük";
            this.rbKucuk.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 585);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Adet :";
            // 
            // numAdet
            // 
            this.numAdet.BackColor = System.Drawing.Color.WhiteSmoke;
            this.numAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numAdet.Location = new System.Drawing.Point(70, 583);
            this.numAdet.Name = "numAdet";
            this.numAdet.Size = new System.Drawing.Size(163, 26);
            this.numAdet.TabIndex = 9;
            // 
            // btnSiparisEkle
            // 
            this.btnSiparisEkle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSiparisEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiparisEkle.Location = new System.Drawing.Point(34, 637);
            this.btnSiparisEkle.Name = "btnSiparisEkle";
            this.btnSiparisEkle.Size = new System.Drawing.Size(165, 31);
            this.btnSiparisEkle.TabIndex = 10;
            this.btnSiparisEkle.Text = "Sipariş Ekle";
            this.btnSiparisEkle.UseVisualStyleBackColor = false;
            this.btnSiparisEkle.Click += new System.EventHandler(this.btnSiparisEkle_Click);
            // 
            // lbSiparis
            // 
            this.lbSiparis.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbSiparis.FormattingEnabled = true;
            this.lbSiparis.Location = new System.Drawing.Point(279, 194);
            this.lbSiparis.Name = "lbSiparis";
            this.lbSiparis.Size = new System.Drawing.Size(595, 433);
            this.lbSiparis.TabIndex = 12;
            // 
            // btnSiparisOnayla
            // 
            this.btnSiparisOnayla.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSiparisOnayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiparisOnayla.Location = new System.Drawing.Point(709, 644);
            this.btnSiparisOnayla.Name = "btnSiparisOnayla";
            this.btnSiparisOnayla.Size = new System.Drawing.Size(165, 31);
            this.btnSiparisOnayla.TabIndex = 13;
            this.btnSiparisOnayla.Text = "Sipariş Onayla";
            this.btnSiparisOnayla.UseVisualStyleBackColor = false;
            this.btnSiparisOnayla.Click += new System.EventHandler(this.btnSiparisOnayla_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(276, 644);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Toplam :";
            // 
            // lblToplamFiyat
            // 
            this.lblToplamFiyat.AutoSize = true;
            this.lblToplamFiyat.BackColor = System.Drawing.Color.Transparent;
            this.lblToplamFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToplamFiyat.ForeColor = System.Drawing.Color.Red;
            this.lblToplamFiyat.Location = new System.Drawing.Point(356, 644);
            this.lblToplamFiyat.Name = "lblToplamFiyat";
            this.lblToplamFiyat.Size = new System.Drawing.Size(0, 18);
            this.lblToplamFiyat.TabIndex = 15;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(17, 299);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(222, 146);
            this.flowLayoutPanel1.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = "Ekstra Malzeme Seçiniz";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Comic Sans MS", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(303, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(390, 56);
            this.textBox1.TabIndex = 22;
            this.textBox1.Text = "İSTANBUL SUSHİ";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::İstanbul_Restorant.Properties.Resources._94ef67d133ef15f63d2ceda31be011da;
            this.pictureBox5.Location = new System.Drawing.Point(35, -4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(197, 178);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 21;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(906, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SiparisIslemleriEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::İstanbul_Restorant.Properties.Resources.istockphoto_903089974_612x612;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(904, 710);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblToplamFiyat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSiparisOnayla);
            this.Controls.Add(this.lbSiparis);
            this.Controls.Add(this.btnSiparisEkle);
            this.Controls.Add(this.numAdet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SiparisIslemleriEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SiparisIslemleri";
            this.Load += new System.EventHandler(this.SiparisIslemleriEkrani_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbMenu;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rbBuyuk;
		private System.Windows.Forms.RadioButton rbOrta;
		private System.Windows.Forms.RadioButton rbKucuk;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown numAdet;
		private System.Windows.Forms.Button btnSiparisEkle;
		private System.Windows.Forms.ListBox lbSiparis;
		private System.Windows.Forms.Button btnSiparisOnayla;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblToplamFiyat;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox textBox1;
    }
}