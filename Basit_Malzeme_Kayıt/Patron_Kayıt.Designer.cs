namespace Basit_Malzeme_Kayıt
{
    partial class Patron_Kayıt
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
            this.mskşifre = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.txtdepartman = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mskşifre
            // 
            this.mskşifre.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskşifre.Location = new System.Drawing.Point(163, 363);
            this.mskşifre.Mask = "00000000000";
            this.mskşifre.Name = "mskşifre";
            this.mskşifre.Size = new System.Drawing.Size(167, 39);
            this.mskşifre.TabIndex = 27;
            this.mskşifre.ValidatingType = typeof(int);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(61, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(273, 35);
            this.label11.TabIndex = 26;
            this.label11.Text = "Patron Kayıt Paneli";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button4.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(163, 490);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(167, 37);
            this.button4.TabIndex = 25;
            this.button4.Text = "Geri dön";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SeaGreen;
            this.button3.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(163, 429);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(167, 37);
            this.button3.TabIndex = 24;
            this.button3.Text = "Kayıt";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // msktc
            // 
            this.msktc.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msktc.Location = new System.Drawing.Point(163, 296);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(167, 39);
            this.msktc.TabIndex = 23;
            this.msktc.ValidatingType = typeof(int);
            // 
            // txtdepartman
            // 
            this.txtdepartman.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdepartman.Location = new System.Drawing.Point(163, 233);
            this.txtdepartman.Name = "txtdepartman";
            this.txtdepartman.Size = new System.Drawing.Size(167, 39);
            this.txtdepartman.TabIndex = 22;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsoyad.Location = new System.Drawing.Point(163, 168);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(167, 39);
            this.txtsoyad.TabIndex = 21;
            // 
            // txtad
            // 
            this.txtad.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtad.Location = new System.Drawing.Point(163, 101);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(167, 39);
            this.txtad.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(78, 366);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 30);
            this.label10.TabIndex = 19;
            this.label10.Text = "Şifre:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(62, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 30);
            this.label9.TabIndex = 18;
            this.label9.Text = "Tc No:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 30);
            this.label8.TabIndex = 17;
            this.label8.Text = "Departman:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(62, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 30);
            this.label7.TabIndex = 16;
            this.label7.Text = "Soyad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(98, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 30);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ad:";
            // 
            // Patron_Kayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(355, 530);
            this.Controls.Add(this.mskşifre);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.msktc);
            this.Controls.Add(this.txtdepartman);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Patron_Kayıt";
            this.Text = "Patron_Kayıt";
            this.Load += new System.EventHandler(this.Patron_Kayıt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskşifre;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MaskedTextBox msktc;
        private System.Windows.Forms.TextBox txtdepartman;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}