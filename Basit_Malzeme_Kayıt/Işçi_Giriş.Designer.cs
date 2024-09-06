namespace Basit_Malzeme_Kayıt
{
    partial class Işçi_Giriş
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Işçi_Giriş));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btngirişyap = new System.Windows.Forms.Button();
            this.btnüyekayıt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.mskşifre = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(495, 288);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tc No Giriniz:";
            // 
            // btngirişyap
            // 
            this.btngirişyap.BackColor = System.Drawing.Color.SeaGreen;
            this.btngirişyap.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngirişyap.Location = new System.Drawing.Point(199, 489);
            this.btngirişyap.Name = "btngirişyap";
            this.btngirişyap.Size = new System.Drawing.Size(202, 47);
            this.btngirişyap.TabIndex = 2;
            this.btngirişyap.Text = "Giriş Yapınız";
            this.btngirişyap.UseVisualStyleBackColor = false;
            this.btngirişyap.Click += new System.EventHandler(this.btngirişyap_Click);
            // 
            // btnüyekayıt
            // 
            this.btnüyekayıt.BackColor = System.Drawing.Color.Yellow;
            this.btnüyekayıt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnüyekayıt.Location = new System.Drawing.Point(158, 588);
            this.btnüyekayıt.Name = "btnüyekayıt";
            this.btnüyekayıt.Size = new System.Drawing.Size(164, 73);
            this.btnüyekayıt.TabIndex = 4;
            this.btnüyekayıt.Text = "İşçi Kayıt Butonu";
            this.btnüyekayıt.UseVisualStyleBackColor = false;
            this.btnüyekayıt.Click += new System.EventHandler(this.btnüyekayıt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 447);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 36);
            this.label2.TabIndex = 6;
            this.label2.Text = "Şifre Giriniz:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(397, 36);
            this.label3.TabIndex = 7;
            this.label3.Text = "İşçi Giriş Paneline HoşGeldiniz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 549);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(362, 36);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kaydınız Yoksa Kayıt Olunuz";
            // 
            // msktc
            // 
            this.msktc.Location = new System.Drawing.Point(199, 403);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(202, 30);
            this.msktc.TabIndex = 9;
            this.msktc.ValidatingType = typeof(int);
            this.msktc.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.msktc_MaskInputRejected);
            // 
            // mskşifre
            // 
            this.mskşifre.Location = new System.Drawing.Point(199, 447);
            this.mskşifre.Mask = "00000000000";
            this.mskşifre.Name = "mskşifre";
            this.mskşifre.Size = new System.Drawing.Size(202, 30);
            this.mskşifre.TabIndex = 10;
            this.mskşifre.ValidatingType = typeof(int);
            this.mskşifre.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskşifre_MaskInputRejected);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tomato;
            this.button1.Location = new System.Drawing.Point(405, 621);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 50);
            this.button1.TabIndex = 11;
            this.button1.Text = "Geri Git ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Işçi_Giriş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(494, 672);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mskşifre);
            this.Controls.Add(this.msktc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnüyekayıt);
            this.Controls.Add(this.btngirişyap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Işçi_Giriş";
            this.Text = "Işçi_Giriş";
            this.Load += new System.EventHandler(this.Işçi_Giriş_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btngirişyap;
        private System.Windows.Forms.Button btnüyekayıt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox msktc;
        private System.Windows.Forms.MaskedTextBox mskşifre;
        private System.Windows.Forms.Button button1;
    }
}