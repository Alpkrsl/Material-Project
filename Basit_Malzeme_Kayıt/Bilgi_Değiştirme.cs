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
using System.Data.Common;
namespace Basit_Malzeme_Kayıt
{
    public partial class Bilgi_Değiştirme : Form
    {
        public Bilgi_Değiştirme()
        {
            InitializeComponent();
        }

        //sql bağlantı
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-HMITB4AP;Initial Catalog=STOK3;Integrated Security=True;");

       //Form load kısmı
        private void FrmEskiBilgiler_Load(object sender, EventArgs e)
        {
            atama();
            DataGriddProsedure();
            SilmeProsedür();
        }

        private void atama()
        {
            lbltc.Text = tcc;
            lblşifre.Text = şifree;
        }

        private void Prosedürönce()
        {

        }

        //datagrid veri kısmı
        public string değiş;
        

        //Prosedure Kısmı
        private void DataGriddProsedure()
        {
            baglanti.Open();
            SqlCommand PRO = new SqlCommand("Eklemee3",baglanti);
            PRO.CommandType = CommandType.StoredProcedure;
            PRO.Parameters.AddWithValue("@P1", TXTıd.Text);
            DataTable dt = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(PRO);
            sqlDataAdapter.Fill(dt);                
            dataGridView2.DataSource = dt;
            
            
            baglanti.Close();
        //    listele();
        }

        ////Listele Metot
        //private void listele()
        //{
        //    SqlCommand liste = new SqlCommand("SELECT*FROM MALZEMELER",baglanti);
        //    DataTable dtt = new DataTable();
        //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(liste);
        //    sqlDataAdapter.Fill(dtt);
        //    dataGridView1.DataSource = dtt;
        //}

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(TXTıd.Text))
                {
                    DataGriddProsedure();
                }
            }
            catch {
                MessageBox.Show("Id Numarası giriniz");
            }
        }

        //Silme Prosedür butonu
        private void button3_Click(object sender, EventArgs e)
        {
            SilmeProsedür();
        }


        //Silme Prosedür
        private void SilmeProsedür()
        {

                SqlCommand sil = new SqlCommand("SilmeProsedürü", baglanti);
                sil.CommandType = CommandType.StoredProcedure;
                sil.Parameters.AddWithValue("@P1",txtıdd.Text);
                DataTable dt = new DataTable();
                SqlDataAdapter dq = new SqlDataAdapter(sil);
                dq.Fill(dt);
                dataGridView1.DataSource = dt;
          
            //silinenliste();
        }
        //sill.Parameters.AddWithValue("@r1",txtıdd.Text); WHERE ID=@r1
        //Silinen Lİstesi 
        private void silinenliste()
        {
            SqlCommand sill = new SqlCommand("Select*from SilinenMalzemeler2", baglanti);
            DataTable dt = new DataTable();
            SqlDataAdapter dq = new SqlDataAdapter(sill);
            dq.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }


        //Eklenen Bilgiler için buton
        private void button2_Click(object sender, EventArgs e)
        {
            ProsedürEkle();
        }


        //Ekleme Prosedür
        private void ProsedürEkle()
        {
            SqlCommand çağır = new SqlCommand("KAYITÇAĞIR", baglanti);
            çağır.CommandType = CommandType.StoredProcedure;
            çağır.Parameters.AddWithValue("@P1",TXTıd.Text);
            DataTable dt = new DataTable();
            SqlDataAdapter dq = new SqlDataAdapter(çağır);
            dq.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            GüncelleSonra();
        }

        private void GüncelleSonra()
        {
            SqlCommand güncelleee = new SqlCommand("Güncel_Triggersonra",baglanti);
            güncelleee.CommandType = CommandType.StoredProcedure;
            güncelleee.Parameters.AddWithValue("@R3",txtgüncelsonra.Text);
            DataTable dt = new DataTable();
            SqlDataAdapter dq = new SqlDataAdapter(güncelleee);
            dq.Fill(dt);
            dataGridView4.DataSource = dt;
            baglanti.Close();
        }

        //LİSTELEME butonu
        private void button1_Click_1(object sender, EventArgs e)
        {
            silinenliste();
            eklenenliste();
            güncellemeliste();
            güncellemelistesonra();
        }

        //güncellemeden sonra
        private void güncellemelistesonra()
        {
            try
            {
                baglanti.Open(); // Bağlantıyı aç

                SqlCommand güncellistee = new SqlCommand("SELECT * FROM Yeni_Güncel", baglanti);
                DataTable dtt = new DataTable();
                SqlDataAdapter dqq = new SqlDataAdapter(güncellistee);
                dqq.Fill(dtt);
                dataGridView4.DataSource = dtt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close(); // Bağlantıyı kapat
            }
        }

        // Güncelleme listele butonu
        private void güncellemeliste()
        {
            try
            {
                baglanti.Open(); // Bağlantıyı aç

                SqlCommand güncelliste = new SqlCommand("SELECT * FROM Eski_Güncel", baglanti);
                DataTable dt = new DataTable();
                SqlDataAdapter dq = new SqlDataAdapter(güncelliste);
                dq.Fill(dt);
                dataGridView3.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close(); // Bağlantıyı kapat
            }
        }


        //Ekle Listelemesi
        private void eklenenliste()
        {
            SqlCommand liste = new SqlCommand("SELECT*FROM YeniKayıt",baglanti);
            DataTable dt = new DataTable();
            SqlDataAdapter d = new SqlDataAdapter(liste);
            d.Fill(dt);
            dataGridView2.DataSource= dt;
        }

        //GüncelleButonu
        private void BtnGüncelsonra_Click(object sender, EventArgs e)
        {
            Güncelle();
        }

        //Güncellestoreprosedürü
        private void Güncelle()
        {
            SqlCommand güncelle = new SqlCommand("Güncel_Trigger", baglanti);
            güncelle.CommandType = CommandType.StoredProcedure;
            güncelle.Parameters.AddWithValue("@R2",txtgüncelönce.Text);
            DataTable dt = new DataTable();
            SqlDataAdapter d = new SqlDataAdapter(güncelle);
            d.Fill(dt);
            dataGridView3.DataSource= dt;
        }
        public string tcc, şifree;
        private void button2_Click_1(object sender, EventArgs e)
        {
            MalzemeManipulasyonu frm = new MalzemeManipulasyonu();
            frm.tckno = lbltc.Text;
            frm.şif = lblşifre.Text;
            frm.Show();
            this.Close();
        }
    }
}
