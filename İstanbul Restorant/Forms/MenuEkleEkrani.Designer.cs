namespace İstanbul_Restorant
{
	partial class MenuEkleEkrani
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMenuAdi = new System.Windows.Forms.TextBox();
            this.nudMenuFiyat = new System.Windows.Forms.NumericUpDown();
            this.btnMenuEkle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudMenuFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(300, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menü Ekleme Ekranı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(247, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(236, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fiyat";
            // 
            // txtMenuAdi
            // 
            this.txtMenuAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMenuAdi.Location = new System.Drawing.Point(286, 156);
            this.txtMenuAdi.Name = "txtMenuAdi";
            this.txtMenuAdi.Size = new System.Drawing.Size(204, 26);
            this.txtMenuAdi.TabIndex = 3;
            // 
            // nudMenuFiyat
            // 
            this.nudMenuFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMenuFiyat.Location = new System.Drawing.Point(286, 194);
            this.nudMenuFiyat.Name = "nudMenuFiyat";
            this.nudMenuFiyat.Size = new System.Drawing.Size(204, 26);
            this.nudMenuFiyat.TabIndex = 4;
            // 
            // btnMenuEkle
            // 
            this.btnMenuEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuEkle.Location = new System.Drawing.Point(303, 247);
            this.btnMenuEkle.Name = "btnMenuEkle";
            this.btnMenuEkle.Size = new System.Drawing.Size(117, 31);
            this.btnMenuEkle.TabIndex = 5;
            this.btnMenuEkle.Text = "Ekle";
            this.btnMenuEkle.UseVisualStyleBackColor = true;
            this.btnMenuEkle.Click += new System.EventHandler(this.btnMenuEkle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::İstanbul_Restorant.Properties.Resources.pexels_marcos_kohler_17178435;
            this.pictureBox1.Location = new System.Drawing.Point(12, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 376);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // MenuEkleEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::İstanbul_Restorant.Properties.Resources.istockphoto_903089974_612x612;
            this.ClientSize = new System.Drawing.Size(540, 377);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnMenuEkle);
            this.Controls.Add(this.nudMenuFiyat);
            this.Controls.Add(this.txtMenuAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuEkleEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MenuEkle";
            ((System.ComponentModel.ISupportInitialize)(this.nudMenuFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtMenuAdi;
		private System.Windows.Forms.NumericUpDown nudMenuFiyat;
		private System.Windows.Forms.Button btnMenuEkle;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}