namespace Basit_Malzeme_Kayıt
{
    partial class Patron_Giriş
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patron_Giriş));
            this.button1 = new System.Windows.Forms.Button();
            this.mskşifre1 = new System.Windows.Forms.MaskedTextBox();
            this.msktc1 = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnüyekayıt = new System.Windows.Forms.Button();
            this.btngirişyap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tomato;
            this.button1.Location = new System.Drawing.Point(443, 614);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 50);
            this.button1.TabIndex = 21;
            this.button1.Text = "Geri Git ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mskşifre1
            // 
            this.mskşifre1.Location = new System.Drawing.Point(237, 440);
            this.mskşifre1.Mask = "00000000000";
            this.mskşifre1.Name = "mskşifre1";
            this.mskşifre1.Size = new System.Drawing.Size(202, 42);
            this.mskşifre1.TabIndex = 20;
            this.mskşifre1.ValidatingType = typeof(int);
            // 
            // msktc1
            // 
            this.msktc1.Location = new System.Drawing.Point(237, 396);
            this.msktc1.Mask = "00000000000";
            this.msktc1.Name = "msktc1";
            this.msktc1.Size = new System.Drawing.Size(202, 42);
            this.msktc1.TabIndex = 19;
            this.msktc1.ValidatingType = typeof(int);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(97, 542);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(362, 36);
            this.label4.TabIndex = 18;
            this.label4.Text = "Kaydınız Yoksa Kayıt Olunuz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(443, 36);
            this.label3.TabIndex = 17;
            this.label3.Text = "Patron Giriş Paneline Hoş Geldiniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 440);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 36);
            this.label2.TabIndex = 16;
            this.label2.Text = "Şifre Giriniz:";
            // 
            // btnüyekayıt
            // 
            this.btnüyekayıt.BackColor = System.Drawing.Color.Yellow;
            this.btnüyekayıt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnüyekayıt.Location = new System.Drawing.Point(196, 581);
            this.btnüyekayıt.Name = "btnüyekayıt";
            this.btnüyekayıt.Size = new System.Drawing.Size(164, 73);
            this.btnüyekayıt.TabIndex = 15;
            this.btnüyekayıt.Text = "Patron Kayıt Butonu";
            this.btnüyekayıt.UseVisualStyleBackColor = false;
            this.btnüyekayıt.Click += new System.EventHandler(this.btnüyekayıt_Click);
            // 
            // btngirişyap
            // 
            this.btngirişyap.BackColor = System.Drawing.Color.SeaGreen;
            this.btngirişyap.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngirişyap.Location = new System.Drawing.Point(237, 482);
            this.btngirişyap.Name = "btngirişyap";
            this.btngirişyap.Size = new System.Drawing.Size(202, 47);
            this.btngirişyap.TabIndex = 14;
            this.btngirişyap.Text = "Giriş Yapınız";
            this.btngirişyap.UseVisualStyleBackColor = false;
            this.btngirişyap.Click += new System.EventHandler(this.btngirişyap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 36);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tc No Giriniz:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(539, 288);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Patron_Giriş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(536, 663);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mskşifre1);
            this.Controls.Add(this.msktc1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnüyekayıt);
            this.Controls.Add(this.btngirişyap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Patron_Giriş";
            this.Text = "Patron_Giriş";
            this.Load += new System.EventHandler(this.Patron_Giriş_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox mskşifre1;
        private System.Windows.Forms.MaskedTextBox msktc1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnüyekayıt;
        private System.Windows.Forms.Button btngirişyap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}