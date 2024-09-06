namespace Basit_Malzeme_Kayıt
{
    partial class Işçi_Manipule
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.lbltc = new System.Windows.Forms.Label();
            this.lblşifre = new System.Windows.Forms.Label();
            this.btnlistele = new System.Windows.Forms.Button();
            this.btnGetir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtıd = new System.Windows.Forms.TextBox();
            this.btnrütbe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtrütbe = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button9 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblmkod = new System.Windows.Forms.Label();
            this.lblad = new System.Windows.Forms.Label();
            this.lblfiyat = new System.Windows.Forms.Label();
            this.lblyilliksatiş = new System.Windows.Forms.Label();
            this.lblminstok = new System.Windows.Forms.Label();
            this.lbltsüresi = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(1, 255);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1198, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Veriler";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1192, 421);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(1, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Geri Dön";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbltc
            // 
            this.lbltc.AutoSize = true;
            this.lbltc.Location = new System.Drawing.Point(112, 8);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(663, 25);
            this.lbltc.TabIndex = 2;
            this.lbltc.Text = "Hangi rütbe neleri görebilir onların listesi ve rütbelerin gördüklerini değiştirm" +
    "e";
            this.lbltc.Visible = false;
            // 
            // lblşifre
            // 
            this.lblşifre.AutoSize = true;
            this.lblşifre.Location = new System.Drawing.Point(12, 213);
            this.lblşifre.Name = "lblşifre";
            this.lblşifre.Size = new System.Drawing.Size(180, 25);
            this.lblşifre.TabIndex = 3;
            this.lblşifre.Text = "Veri Görmeyi sınırla";
            this.lblşifre.Visible = false;
            this.lblşifre.Click += new System.EventHandler(this.lbldep_Click);
            // 
            // btnlistele
            // 
            this.btnlistele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnlistele.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnlistele.Location = new System.Drawing.Point(363, 176);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(190, 46);
            this.btnlistele.TabIndex = 27;
            this.btnlistele.Text = "Listele";
            this.btnlistele.UseVisualStyleBackColor = false;
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // btnGetir
            // 
            this.btnGetir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetir.Location = new System.Drawing.Point(363, 124);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(190, 46);
            this.btnGetir.TabIndex = 26;
            this.btnGetir.Text = "Getir";
            this.btnGetir.UseVisualStyleBackColor = false;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(385, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 36);
            this.label5.TabIndex = 25;
            this.label5.Text = "İşçiyi Getir";
            // 
            // txtıd
            // 
            this.txtıd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtıd.Location = new System.Drawing.Point(363, 77);
            this.txtıd.Name = "txtıd";
            this.txtıd.Size = new System.Drawing.Size(190, 41);
            this.txtıd.TabIndex = 24;
            // 
            // btnrütbe
            // 
            this.btnrütbe.BackColor = System.Drawing.Color.Yellow;
            this.btnrütbe.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnrütbe.Location = new System.Drawing.Point(127, 128);
            this.btnrütbe.Name = "btnrütbe";
            this.btnrütbe.Size = new System.Drawing.Size(190, 57);
            this.btnrütbe.TabIndex = 19;
            this.btnrütbe.Text = "Veriyi Getir";
            this.btnrütbe.UseVisualStyleBackColor = false;
            this.btnrütbe.Click += new System.EventHandler(this.btnrütbe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(11, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 36);
            this.label1.TabIndex = 18;
            this.label1.Text = "Rütbe:";
            // 
            // txtrütbe
            // 
            this.txtrütbe.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtrütbe.Location = new System.Drawing.Point(127, 81);
            this.txtrütbe.Name = "txtrütbe";
            this.txtrütbe.Size = new System.Drawing.Size(190, 41);
            this.txtrütbe.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox7);
            this.groupBox2.Controls.Add(this.checkBox6);
            this.groupBox2.Controls.Add(this.checkBox4);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.button9);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(671, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(528, 259);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Göremeyi sınırla veya arttır";
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(369, 90);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(131, 29);
            this.checkBox7.TabIndex = 74;
            this.checkBox7.Text = "checkBox7";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(366, 41);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(131, 29);
            this.checkBox6.TabIndex = 73;
            this.checkBox6.Text = "checkBox6";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(109, 147);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(131, 29);
            this.checkBox4.TabIndex = 71;
            this.checkBox4.Text = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(109, 112);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(131, 29);
            this.checkBox3.TabIndex = 70;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(130, 71);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(131, 29);
            this.checkBox2.TabIndex = 69;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(151, 41);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(131, 29);
            this.checkBox1.TabIndex = 68;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.SeaGreen;
            this.button9.Location = new System.Drawing.Point(200, 217);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(147, 36);
            this.button9.TabIndex = 42;
            this.button9.Text = "Git";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 25);
            this.label2.TabIndex = 54;
            this.label2.Text = "MalzemeKodu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 25);
            this.label4.TabIndex = 56;
            this.label4.Text = "Malzemeadi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 25);
            this.label6.TabIndex = 55;
            this.label6.Text = "Yilliksatiş";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 25);
            this.label7.TabIndex = 57;
            this.label7.Text = "BirimFiyat";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(279, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 25);
            this.label8.TabIndex = 58;
            this.label8.Text = "MinStok";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(282, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 25);
            this.label9.TabIndex = 59;
            this.label9.Text = "TSüresi";
            // 
            // lblmkod
            // 
            this.lblmkod.AutoSize = true;
            this.lblmkod.Location = new System.Drawing.Point(223, 219);
            this.lblmkod.Name = "lblmkod";
            this.lblmkod.Size = new System.Drawing.Size(180, 25);
            this.lblmkod.TabIndex = 42;
            this.lblmkod.Text = "Veri Görmeyi sınırla";
            this.lblmkod.Visible = false;
            // 
            // lblad
            // 
            this.lblad.AutoSize = true;
            this.lblad.Location = new System.Drawing.Point(460, 236);
            this.lblad.Name = "lblad";
            this.lblad.Size = new System.Drawing.Size(180, 25);
            this.lblad.TabIndex = 43;
            this.lblad.Text = "Veri Görmeyi sınırla";
            this.lblad.Visible = false;
            // 
            // lblfiyat
            // 
            this.lblfiyat.AutoSize = true;
            this.lblfiyat.Location = new System.Drawing.Point(198, 227);
            this.lblfiyat.Name = "lblfiyat";
            this.lblfiyat.Size = new System.Drawing.Size(180, 25);
            this.lblfiyat.TabIndex = 44;
            this.lblfiyat.Text = "Veri Görmeyi sınırla";
            this.lblfiyat.Visible = false;
            // 
            // lblyilliksatiş
            // 
            this.lblyilliksatiş.AutoSize = true;
            this.lblyilliksatiş.Location = new System.Drawing.Point(460, 230);
            this.lblyilliksatiş.Name = "lblyilliksatiş";
            this.lblyilliksatiş.Size = new System.Drawing.Size(180, 25);
            this.lblyilliksatiş.TabIndex = 45;
            this.lblyilliksatiş.Text = "Veri Görmeyi sınırla";
            this.lblyilliksatiş.Visible = false;
            // 
            // lblminstok
            // 
            this.lblminstok.AutoSize = true;
            this.lblminstok.Location = new System.Drawing.Point(460, 236);
            this.lblminstok.Name = "lblminstok";
            this.lblminstok.Size = new System.Drawing.Size(180, 25);
            this.lblminstok.TabIndex = 46;
            this.lblminstok.Text = "Veri Görmeyi sınırla";
            this.lblminstok.Visible = false;
            // 
            // lbltsüresi
            // 
            this.lbltsüresi.AutoSize = true;
            this.lbltsüresi.Location = new System.Drawing.Point(470, 236);
            this.lbltsüresi.Name = "lbltsüresi";
            this.lbltsüresi.Size = new System.Drawing.Size(180, 25);
            this.lbltsüresi.TabIndex = 47;
            this.lbltsüresi.Text = "Veri Görmeyi sınırla";
            this.lbltsüresi.Visible = false;
            // 
            // Işçi_Manipule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.lbltsüresi);
            this.Controls.Add(this.lblminstok);
            this.Controls.Add(this.lblyilliksatiş);
            this.Controls.Add(this.lblfiyat);
            this.Controls.Add(this.lblad);
            this.Controls.Add(this.lblmkod);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnlistele);
            this.Controls.Add(this.btnGetir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtıd);
            this.Controls.Add(this.btnrütbe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtrütbe);
            this.Controls.Add(this.lblşifre);
            this.Controls.Add(this.lbltc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Işçi_Manipule";
            this.Text = "Işçi_Manipule";
            this.Load += new System.EventHandler(this.Işçi_Manipule_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbltc;
        private System.Windows.Forms.Label lblşifre;
        private System.Windows.Forms.Button btnlistele;
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtıd;
        private System.Windows.Forms.Button btnrütbe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtrütbe;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.Label lblmkod;
        private System.Windows.Forms.Label lblad;
        private System.Windows.Forms.Label lblfiyat;
        private System.Windows.Forms.Label lblyilliksatiş;
        private System.Windows.Forms.Label lblminstok;
        private System.Windows.Forms.Label lbltsüresi;
    }
}