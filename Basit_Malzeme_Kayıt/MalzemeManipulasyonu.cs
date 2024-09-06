using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.SqlServer.Server;

namespace Basit_Malzeme_Kayıt
{
    public partial class MalzemeManipulasyonu : Form
    {
        public MalzemeManipulasyonu()
        {
            InitializeComponent();
        }
        //Bağlantı
      
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-HMITB4AP;Initial Catalog=STOK3;Integrated Security=True;");
        
        //Form_Load kısmı
        private void Form1_Load(object sender, EventArgs e)
        {
            VeriGör();            
            Listele();
        }

        //Veri Gör
        public void VeriGör()
        {
            label8.Text = tckno;
            lblşifre.Text = şif;
        }


        //Ekleme Butonu
        private void Btnekle_Click(object sender, EventArgs e)
        {
            Ekle();
        }

        //Ekleme metodu
        private void Ekle()
        {
            try
            {
                // Parametrelerin boş olup olmadığını kontrol ediyoruz
                if (!string.IsNullOrEmpty(txtmalzemekod.Text) &&
                    !string.IsNullOrEmpty(txtmalzemead.Text) &&
                   !string.IsNullOrEmpty(txtyıllıksatış.Text) &&
                    !string.IsNullOrEmpty(txtbirimfiyat.Text) &&
                    !string.IsNullOrEmpty(txtminumumstok.Text) &&
                    !string.IsNullOrEmpty(txttedariksüresi.Text))

                    baglanti.Open();
                SqlCommand sql = new SqlCommand("INSERT INTO MALZEMELER(MalzemeKodu,Malzemeadi,Yilliksatiş,BirimFiyat,MinStok,TSüresi)VALUES(@P1,@P2,@P3,@P4,@P5,@P6)", baglanti);
                sql.Parameters.AddWithValue("@P1", txtmalzemekod.Text);
                sql.Parameters.AddWithValue("@P2", txtmalzemead.Text);
                sql.Parameters.AddWithValue("@P3", txtyıllıksatış.Text);
                sql.Parameters.AddWithValue("@P4", txtbirimfiyat.Text);
                sql.Parameters.AddWithValue("@P5", txtminumumstok.Text);
                sql.Parameters.AddWithValue("@P6", txttedariksüresi.Text);
                sql.ExecuteNonQuery();
                MessageBox.Show("Kayıt Başarılı");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {

                baglanti.Close();
                Listele();

            }
        }

        //Trigger çalışması için değer koyma
        private void triçalışma()
        {
            //SqlCommand sql = new SqlCommand("Select*from KAYİT WHERE Kayitıd=@p1 and KayıtTarih=@p2",baglanti);
            //sql.Parameters.AddWithValue("@p1",lbl1.Text);
            //sql.Parameters.AddWithValue("@p2",lbl2.Text);
            //sql.ExecuteNonQuery();
            //baglanti.Close();
        }

        //Listeleme metodu
        private void Listele()
        {
            baglanti.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT*FROM MALZEMELER", baglanti);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();

        }

        private void BtnListele_Click(object sender, EventArgs e)
        {

        }

        //Sil Butonu
        private void BtnSil_Click(object sender, EventArgs e)
        {
            Sil();

        }

        //Sil Metodu
        private void Sil()
        {
            try
            {
                // Parametrelerin boş olup olmadığını kontrol ediyoruz
                if (!string.IsNullOrEmpty(txtıd.Text))

                    baglanti.Open();
                SqlCommand sql = new SqlCommand("DELETE MALZEMELER WHERE ID=@p2", baglanti);
                sql.Parameters.AddWithValue("@p2", txtıd.Text);
                sql.ExecuteNonQuery();
                MessageBox.Show("Başarıyla Silindi");
            }
            catch
            {
                MessageBox.Show("Hata öbür değerleri de giriniz");
            }
            finally
            {

                baglanti.Close();
                Listele();
            }
        }

        //Textbox boşluk temizleme
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtıd.Text = txtıd.Text.Trim(); // Başlangıç ve sondaki boşlukları temizler
            txtıd.SelectionStart = txtıd.Text.Length;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        //Güncelleme Butonu
        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            Güncelle();
        }

        //Güncelleme Metodu
        private void Güncelle()
        {
            try
            {
                // Parametrelerin boş olup olmadığını kontrol ediyoruz
                if (!string.IsNullOrEmpty(txtmalzemekod.Text) &&
                    !string.IsNullOrEmpty(txtmalzemead.Text) &&
                   !string.IsNullOrEmpty(txtyıllıksatış.Text) &&
                    !string.IsNullOrEmpty(txtbirimfiyat.Text) &&
                    !string.IsNullOrEmpty(txtminumumstok.Text) &&
                    !string.IsNullOrEmpty(txttedariksüresi.Text))


                    baglanti.Open();
                SqlCommand sql = new SqlCommand("UPDATE MALZEMELER SET  MalzemeKodu=@r1,Malzemeadi=@r2,Yilliksatiş=@r3,BirimFiyat=@r4,MinStok=@r5,TSüresi=@r6 WHERE ID=@r7", baglanti);
                sql.Parameters.AddWithValue("@r1", txtmalzemekod.Text);
                sql.Parameters.AddWithValue("@r2", txtmalzemead.Text);
                sql.Parameters.AddWithValue("@r3", txtyıllıksatış.Text);
                sql.Parameters.AddWithValue("@r4", txtbirimfiyat.Text);
                sql.Parameters.AddWithValue("@r5", txtminumumstok.Text);
                sql.Parameters.AddWithValue("@r6", txttedariksüresi.Text);
                sql.Parameters.AddWithValue("@r7", txtıd.Text);
                sql.ExecuteNonQuery();
                MessageBox.Show("Güncelleme Başarılı");
            }
            catch
            {
                MessageBox.Show("Hata öbür değerleri de giriniz");
            }
            finally
            {
                baglanti.Close();
                Listele();
            }
        }

        //Güncelleme Öncesi Trigger
        private void güncellemeöncesiTrigger()
        {

                
            

        }

        //Datagridviewa tıklayarak değer alma
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Değerçağır();
        }


        //Datagridviewa tıklayarak değer alma metodu
        private void Değerçağır()
        {

            txtmalzemekod.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtmalzemead.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtyıllıksatış.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtbirimfiyat.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtminumumstok.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txttedariksüresi.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtıd.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

        }

        //Programdan Çıkma Butonu
        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Textbox boşluk temizleme
        private void txtmalzemekod_TextChanged(object sender, EventArgs e)
        {
            txtmalzemekod.Text = txtmalzemekod.Text.Trim(); // Başlangıç ve sondaki boşlukları temizler
            txtmalzemekod.SelectionStart = txtmalzemekod.Text.Length;
        }

        //Textbox boşluk temizleme
        private void txtmalzemead_TextChanged(object sender, EventArgs e)
        {
            txtmalzemead.Text = txtmalzemead.Text.Trim(); // Başlangıç ve sondaki boşlukları temizler
            txtmalzemead.SelectionStart = txtmalzemead.Text.Length;
        }

        //Textbox boşluk temizleme
        private void txtyıllıksatış_TextChanged(object sender, EventArgs e)
        {
            txtyıllıksatış.Text = txtyıllıksatış.Text.Trim(); // Başlangıç ve sondaki boşlukları temizler
            txtyıllıksatış.SelectionStart = txtyıllıksatış.Text.Length;
        }

        //Textbox boşluk temizleme
        private void txtbirimfiyat_TextChanged(object sender, EventArgs e)
        {
            txtbirimfiyat.Text = txtbirimfiyat.Text.Trim(); // Başlangıç ve sondaki boşlukları temizler
            //txtbirimfiyat.SelectionStart = txtbirimfiyat.Text.Length;
        }

        //Textbox boşluk temizleme
        private void txtminumumstok_TextChanged(object sender, EventArgs e)
        {
            txtminumumstok.Text = txtminumumstok.Text.Trim();
        }

        //Textbox boşluk temizleme
        private void txttedariksüresi_TextChanged(object sender, EventArgs e)
        {
            txttedariksüresi.Text = txttedariksüresi.Text.Trim();

        }

        //Renklşendirme metodu
        private void renklendir()
        {
            //for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            //{
            //    if (Convert.ToInt32(dataGridView1.Rows[i].Cells["MinStok"].Value.ToString()) >= 3000)
            //    {
            //        dataGridView1.Rows[i].Cells["MinStok"].Style.BackColor = Color.Red;
            //    }
            //}
        }

        private void dataGridView1_RowHeadersDefaultCellStyleChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_AlternatingRowsDefaultCellStyleChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_AllowUserToAddRowsChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_AllowUserToDeleteRowsChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_AllowUserToOrderColumnsChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SystemColorsChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

        }


        //Performansı arttıran Renklendirme metodu
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                if (Convert.ToInt32(dataGridView1.Rows[i].Cells["MinStok"].Value.ToString()) >= 3000)
                {
                    dataGridView1.Rows[i].Cells["MinStok"].Style.BackColor = Color.Red;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void malzemeKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MalzemeManipulasyonu frm = new MalzemeManipulasyonu();
            frm.Show();
            this.Close();
        }

        private void aBCAnaliziToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bakışatmak viewlar = new Bakışatmak();
            viewlar.Show();
            this.Hide();
        }

        private void malzemelerdeNelerDeğişmişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bilgi_Değiştirme frmEskiBilgiler = new Bilgi_Değiştirme();
            frmEskiBilgiler.tcc = tckno;
            frmEskiBilgiler.şifree = şif;
            frmEskiBilgiler.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public string tckno,şif;
        private void patronPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Patron_Panell panel = new Patron_Panell();
            panel.tc = label8.Text;
            panel.şifre = lblşifre.Text;
            this.Refresh();
            panel.Show();
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
 

        
    

         
   