using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basit_Malzeme_Kayıt
{
    public partial class Patron_Panell : Form
    {


        //Bağlantı
        SqlConnection bag = new SqlConnection("Data Source=LAPTOP-HMITB4AP;Initial Catalog=STOK3;Integrated Security=True;");
        public Patron_Panell()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        //Load Ekranı
        private void Patron_Panell_Load(object sender, EventArgs e)
        {
            Verilerkısmı();
            ŞifreGöster();
            Listele();


        }

        private void ŞifreGöster()
        {
            lblşifre.Text = şifre;
        }

        public string dept;
        private void DepartmanGöster()
        {

            //try
            //{
            //    bag.Open();
            //    SqlCommand Departman = new SqlCommand("Departman_Göster", bag);
            //    Departman.CommandType = CommandType.StoredProcedure;
            //    Departman.Parameters.AddWithValue("@L1", tc);
            //    if ("@L1"==tc) { 
            //    SqlParameter sqlParameter = Departman.Parameters.AddWithValue("@L2", label4.Text);
            //    label4.Text = dataGridView1.Rows[0].Cells[5].Value.ToString();
            //    label5.Text = label4.Text;
            //    Departman.ExecuteNonQuery();
            //}
            //}
            //catch (Exception ex){
            //    MessageBox.Show(ex.Message,"Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);

            //}
            //finally { 
            //    bag.Close();
            //}
        }

        //Veri görme


        //private void Verigör()
        //{
        //    LBLTCc.Text = tcc;
        //    //SetData(dataGridView1.DataSource);
        //}

        //Veriler Kısmı Görünüm
        private void Verilerkısmı()
        {
            try
            {
                bag.Open();
                SqlCommand veriler = new SqlCommand("SELECT*FROM BirleşmişVeri", bag);
                DataTable dt = new DataTable();
                SqlDataReader sqlDataReader = veriler.ExecuteReader();
                dt.Load(sqlDataReader);
                dataGridView2.DataSource = dt;
                veriler.ExecuteReader();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                bag.Close();
                Listele();
            }
        }

        public string tc,şifre;
        //Patron listeleme Metodu
        private void Listele()
        {
            try
            {
                bag.Open();
                LBLTCc.Text = tc;

                SqlCommand listele = new SqlCommand("PATRON_Unutmama", bag);
                listele.CommandType = CommandType.StoredProcedure;
                listele.Parameters.AddWithValue("@P1",LBLTCc.Text);
                DataTable dt = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(listele);    
                sqlDataAdapter.Fill(dt);
                dataGridView1.DataSource= dt;
                bag.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        //Patron girişe geri dön
        private void button1_Click(object sender, EventArgs e)
        {
            Patron_Giriş patron_Giriş = new Patron_Giriş();
            patron_Giriş.Show();
            this.Close();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        //Tıklayarak ekleme
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtıd.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtsoyad.Text= dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtdepartman.Text= dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            msktc.Text= dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            mskşifre.Text= dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            //label4.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
            //public string dept =label4.Text;

        }

        //Programı Sonlandrıma
        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Malzemelere git

        private void button2_Click(object sender, EventArgs e)
        {
            MalzemeManipulasyonu malzemeManipulasyonu = new MalzemeManipulasyonu();
            malzemeManipulasyonu.tckno=LBLTCc.Text;
            malzemeManipulasyonu.şif = lblşifre.Text;
            malzemeManipulasyonu.Show();
            this.Close();
        }

        //Viewa Git

        private void button5_Click(object sender, EventArgs e)
        {
            Bakışatmak bakışatmak = new Bakışatmak();
            bakışatmak.tcknoo=LBLTCc.Text;
            bakışatmak.şifree=lblşifre.Text;
            bakışatmak.Show();
            this.Close();
        }

        //İşçi Manipulasyonuna git
        private void button6_Click(object sender, EventArgs e)
        {
            Işçi_Manipule ışçi_ = new Işçi_Manipule();
            ışçi_.tc3 = LBLTCc.Text;
            ışçi_.şifrel = lblşifre.Text;
            ışçi_.Show();
            this.Close();
        }

        public string tcc;
        //Işçinin verilerini değiştir
        private void button4_Click(object sender, EventArgs e)
        {
            Işçi_Veri_Değiştir _Değiştir = new Işçi_Veri_Değiştir();
            _Değiştir.tc2 = LBLTCc.Text;
            _Değiştir.şifre2 = lblşifre.Text;
            _Değiştir.Show();
            this.Close();
        }

        //Güncelleme İşlemi
        private void button3_Click(object sender, EventArgs e)
        {
            Güncellemeprosedür();
        }

        //Güncellenme Prosedürü

        private void Güncellemeprosedür()
        {
            try
            {
                bag.Open();
                SqlCommand güncelle = new SqlCommand("Patron_Güncelleme", bag);
                güncelle.CommandType = CommandType.StoredProcedure;
                güncelle.Parameters.AddWithValue("@P1", txtad.Text);
                güncelle.Parameters.AddWithValue("@P2", txtsoyad.Text);
                güncelle.Parameters.AddWithValue("@P3", txtdepartman.Text);
                güncelle.Parameters.AddWithValue("@P4", msktc.Text);
                güncelle.Parameters.AddWithValue("@P5", mskşifre.Text);
                güncelle.Parameters.AddWithValue("P6",txtıd.Text);
                DataTable dt = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(güncelle);
                sqlDataAdapter.Fill(dt);
                dataGridView1.DataSource = dt;
                bag.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally{
                Listele();
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        //private void button8_Click(object sender, EventArgs e)
        //{
        //    this.Refresh();
        //}

        private void LBLTCc_Click(object sender, EventArgs e)
        {

        }
    }
}
