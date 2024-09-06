namespace Basit_Malzeme_Kayıt
{
    partial class MalzemeManipulasyonu
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.patronPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.malzemelerdeNelerDeğişmişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtıd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txttedariksüresi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtminumumstok = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbirimfiyat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtyıllıksatış = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmalzemead = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmalzemekod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Btnekle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGüncelle = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblşifre = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Teal;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patronPanelToolStripMenuItem,
            this.malzemelerdeNelerDeğişmişToolStripMenuItem,
            this.çıkışToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(862, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // patronPanelToolStripMenuItem
            // 
            this.patronPanelToolStripMenuItem.Name = "patronPanelToolStripMenuItem";
            this.patronPanelToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.patronPanelToolStripMenuItem.Text = "Patron Panel";
            this.patronPanelToolStripMenuItem.Click += new System.EventHandler(this.patronPanelToolStripMenuItem_Click);
            // 
            // malzemelerdeNelerDeğişmişToolStripMenuItem
            // 
            this.malzemelerdeNelerDeğişmişToolStripMenuItem.Name = "malzemelerdeNelerDeğişmişToolStripMenuItem";
            this.malzemelerdeNelerDeğişmişToolStripMenuItem.Size = new System.Drawing.Size(223, 24);
            this.malzemelerdeNelerDeğişmişToolStripMenuItem.Text = "Malzemelerde Neler Değişmiş";
            this.malzemelerdeNelerDeğişmişToolStripMenuItem.Click += new System.EventHandler(this.malzemelerdeNelerDeğişmişToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(14, 24);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.txtıd);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txttedariksüresi);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtminumumstok);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtbirimfiyat);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtyıllıksatış);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtmalzemead);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtmalzemekod);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(0, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(719, 258);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Malzeme Bilgisi";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtıd
            // 
            this.txtıd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtıd.Location = new System.Drawing.Point(315, 40);
            this.txtıd.Name = "txtıd";
            this.txtıd.Size = new System.Drawing.Size(141, 30);
            this.txtıd.TabIndex = 13;
            this.txtıd.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(258, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "ID:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txttedariksüresi
            // 
            this.txttedariksüresi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttedariksüresi.Location = new System.Drawing.Point(551, 210);
            this.txttedariksüresi.Name = "txttedariksüresi";
            this.txttedariksüresi.Size = new System.Drawing.Size(144, 30);
            this.txttedariksüresi.TabIndex = 11;
            this.txttedariksüresi.TextChanged += new System.EventHandler(this.txttedariksüresi_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(326, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tedarik Süresi(gün):";
            // 
            // txtminumumstok
            // 
            this.txtminumumstok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtminumumstok.Location = new System.Drawing.Point(551, 149);
            this.txtminumumstok.Name = "txtminumumstok";
            this.txtminumumstok.Size = new System.Drawing.Size(144, 30);
            this.txtminumumstok.TabIndex = 9;
            this.txtminumumstok.TextChanged += new System.EventHandler(this.txtminumumstok_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(326, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Minumum Stok(Adet):";
            // 
            // txtbirimfiyat
            // 
            this.txtbirimfiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbirimfiyat.Location = new System.Drawing.Point(551, 87);
            this.txtbirimfiyat.Name = "txtbirimfiyat";
            this.txtbirimfiyat.Size = new System.Drawing.Size(144, 30);
            this.txtbirimfiyat.TabIndex = 7;
            this.txtbirimfiyat.TextChanged += new System.EventHandler(this.txtbirimfiyat_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(326, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Birim Fiyat(TL/Adet):";
            // 
            // txtyıllıksatış
            // 
            this.txtyıllıksatış.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtyıllıksatış.Location = new System.Drawing.Point(179, 210);
            this.txtyıllıksatış.Name = "txtyıllıksatış";
            this.txtyıllıksatış.Size = new System.Drawing.Size(141, 30);
            this.txtyıllıksatış.TabIndex = 5;
            this.txtyıllıksatış.TextChanged += new System.EventHandler(this.txtyıllıksatış_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Yıllık Satış(Adet):";
            // 
            // txtmalzemead
            // 
            this.txtmalzemead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtmalzemead.Location = new System.Drawing.Point(179, 149);
            this.txtmalzemead.Name = "txtmalzemead";
            this.txtmalzemead.Size = new System.Drawing.Size(141, 30);
            this.txtmalzemead.TabIndex = 3;
            this.txtmalzemead.TextChanged += new System.EventHandler(this.txtmalzemead_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Malzeme Adı:";
            // 
            // txtmalzemekod
            // 
            this.txtmalzemekod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtmalzemekod.Location = new System.Drawing.Point(179, 87);
            this.txtmalzemekod.Name = "txtmalzemekod";
            this.txtmalzemekod.Size = new System.Drawing.Size(141, 30);
            this.txtmalzemekod.TabIndex = 1;
            this.txtmalzemekod.TextChanged += new System.EventHandler(this.txtmalzemekod_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Malzeme Kodu:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 286);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(858, 215);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.AllowUserToAddRowsChanged += new System.EventHandler(this.dataGridView1_AllowUserToAddRowsChanged);
            this.dataGridView1.AllowUserToDeleteRowsChanged += new System.EventHandler(this.dataGridView1_AllowUserToDeleteRowsChanged);
            this.dataGridView1.AllowUserToOrderColumnsChanged += new System.EventHandler(this.dataGridView1_AllowUserToOrderColumnsChanged);
            this.dataGridView1.AlternatingRowsDefaultCellStyleChanged += new System.EventHandler(this.dataGridView1_AlternatingRowsDefaultCellStyleChanged);
            this.dataGridView1.RowHeadersDefaultCellStyleChanged += new System.EventHandler(this.dataGridView1_RowHeadersDefaultCellStyleChanged);
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
            this.dataGridView1.SystemColorsChanged += new System.EventHandler(this.dataGridView1_SystemColorsChanged);
            // 
            // Btnekle
            // 
            this.Btnekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btnekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btnekle.Location = new System.Drawing.Point(725, 45);
            this.Btnekle.Name = "Btnekle";
            this.Btnekle.Size = new System.Drawing.Size(133, 56);
            this.Btnekle.TabIndex = 3;
            this.Btnekle.Text = "Ekle";
            this.Btnekle.UseVisualStyleBackColor = false;
            this.Btnekle.Click += new System.EventHandler(this.Btnekle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.Location = new System.Drawing.Point(725, 128);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(133, 56);
            this.BtnSil.TabIndex = 4;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = false;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGüncelle
            // 
            this.BtnGüncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnGüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGüncelle.Location = new System.Drawing.Point(725, 210);
            this.BtnGüncelle.Name = "BtnGüncelle";
            this.BtnGüncelle.Size = new System.Drawing.Size(133, 56);
            this.BtnGüncelle.TabIndex = 5;
            this.BtnGüncelle.Text = "Güncelle";
            this.BtnGüncelle.UseVisualStyleBackColor = false;
            this.BtnGüncelle.Click += new System.EventHandler(this.BtnGüncelle_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(765, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "label8";
            this.label8.Visible = false;
            // 
            // lblşifre
            // 
            this.lblşifre.AutoSize = true;
            this.lblşifre.Location = new System.Drawing.Point(777, 194);
            this.lblşifre.Name = "lblşifre";
            this.lblşifre.Size = new System.Drawing.Size(44, 16);
            this.lblşifre.TabIndex = 7;
            this.lblşifre.Text = "label9";
            this.lblşifre.Visible = false;
            // 
            // MalzemeManipulasyonu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(862, 502);
            this.Controls.Add(this.lblşifre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtnGüncelle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.Btnekle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MalzemeManipulasyonu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txttedariksüresi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtminumumstok;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbirimfiyat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtyıllıksatış;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmalzemead;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmalzemekod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Btnekle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGüncelle;
        private System.Windows.Forms.TextBox txtıd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem malzemelerdeNelerDeğişmişToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patronPanelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblşifre;
    }
}

