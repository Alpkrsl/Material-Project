using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Basit_Malzeme_Kayıt
{
    public partial class Işçi_Manipule : Form
    {

        //Bağlantı
        SqlConnection SqlConnection = new SqlConnection("Data Source=LAPTOP-HMITB4AP;Initial Catalog=STOK3;Integrated Security=True;");
        public Işçi_Manipule()
        {
            InitializeComponent();
        }

        private void Işçi_Manipule_Load(object sender, EventArgs e)
        {
            verigörünüm();
            listele();
        }

        private void listele()
        {
            SqlCommand Işçii = new SqlCommand("SELECT*FROM BirleşmişVeri", SqlConnection);
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(Işçii);
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Patron_Panell panel = new Patron_Panell();
                panel.tc = lbltc.Text;
                panel.şifre=lblşifre.Text;
                panel.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public string tc3,şifrel;
        //Veri Gör
        public void verigörünüm()
        {
            lbltc.Text = tc3;
            lblşifre.Text = şifrel;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection.Open();
                SqlCommand getir = new SqlCommand("View_Cek", SqlConnection);
                getir.CommandType = CommandType.StoredProcedure;
                getir.Parameters.AddWithValue("@P1", txtıd.Text);
                DataTable dataTable = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(getir);
                sqlDataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                SqlConnection.Close();
            }
        }

        private void btnrütbe_Click(object sender, EventArgs e)
        {
            if (txtrütbe.Text == "düşük")
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT*FROM YeniKayıt", SqlConnection);

                        DataTable dt = new DataTable();
                        dataAdapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    
                
            }
            else if (txtrütbe.Text == "Orta")
            {
                SqlDataAdapter dataAdapterr = new SqlDataAdapter("SELECT*FROM YeniKayıt", SqlConnection);

                DataTable dtt = new DataTable();
                dataAdapterr.Fill(dtt);
                dataGridView1.DataSource = dtt;
            }
            else if (txtrütbe.Text == "Yüksek")
            {
                SqlDataAdapter dataAdapterrr = new SqlDataAdapter("SELECT*FROM YeniKayıt", SqlConnection);
                DataTable dttt = new DataTable();
                dataAdapterrr.Fill(dttt);
                dataGridView1.DataSource = dttt;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SqlConnection.Open();
            try
            {
                if (txtrütbe.Text == "Yüksek")
                {

                        // Dinamik SQL sorgusu için başlangıç
                        string query = "SELECT ";

                        // CheckBox'lara göre hangi sütunların seçileceğini belirleyin
                        if (checkBox1.Checked)
                            query += "MalzemeKodu, ";
                        if (checkBox2.Checked)
                            query += "MalzemeAdi, ";
                        if (checkBox4.Checked)
                            query += "Yilliksatiş, ";
                        if (checkBox3.Checked)
                            query += "BirimFiyat, ";
                        if (checkBox6.Checked)
                            query += "MinStok, ";
                        if (checkBox7.Checked)
                            query += "TSüresi, ";

                        // Sonundaki fazla virgülü kaldırın
                        query = query.TrimEnd(',', ' ');

                        // VIEW ismi ile ekleyin
                        query += " FROM Yüksek_G";

                        // Dinamik SQL sorgusunu kullanarak SqlCommand oluşturun
                        SqlCommand Gör = new SqlCommand(query, SqlConnection);

                        // Sorguyu çalıştırın ve sonuçları DataGridView'da gösterin
                        DataTable dt = new DataTable();
                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(Gör);
                        sqlDataAdapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }

                
                if (txtrütbe.Text == "Orta_G")
                {
                    SqlCommand Görr = new SqlCommand("SELECT MalzemeAdi,MalzemeKodu,YillikSatiş,BirimFiyat,MinStok,TSüresi,ID FROM Görünüm", SqlConnection);
                    if (checkBox1.Checked != true)
                    {
                        Görr.Parameters.AddWithValue("MalzemeKodu", checkBox1.Checked);
                    }
                    else if (checkBox2.Checked != true)
                    {
                        Görr.Parameters.AddWithValue("MalzemeAdi", checkBox2.Checked);
                    }
                    else if (checkBox4.Checked != true)
                    {
                        Görr.Parameters.AddWithValue("YillikSatiş", checkBox4.Checked);
                    }
                    else if (checkBox3.Checked != true)
                    {
                        Görr.Parameters.AddWithValue("BirimFiyat", checkBox3.Checked);
                    }
                    else if (checkBox6.Checked != true)
                    {
                        Görr.Parameters.AddWithValue("MinStok", checkBox6.Checked);
                    }
                    else if (checkBox7.Checked != true)
                    {
                        Görr.Parameters.AddWithValue("TSüresi", checkBox7.Checked);
                    }
 
                    DataTable dt = new DataTable();
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(Görr);
                    sqlDataAdapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                if (txtrütbe.Text == "DÜŞÜK_G")
                {
                    SqlCommand Görrr = new SqlCommand("SELECT MalzemeAdi,MalzemeKodu,YillikSatiş,BirimFiyat,MinStok,TSüresi,ID FROM Görünüm", SqlConnection);
                    if (checkBox1.Checked != true)
                    {
                        Görrr.Parameters.AddWithValue("MalzemeKodu", checkBox1.Checked);
                    }
                    else if (checkBox2.Checked != true)
                    {
                        Görrr.Parameters.AddWithValue("MalzemeAdi", checkBox2.Checked);
                    }
                    else if (checkBox4.Checked != true)
                    {
                        Görrr.Parameters.AddWithValue("YillikSatiş", checkBox4.Checked);
                    }
                    else if (checkBox3.Checked != true)
                    {
                        Görrr.Parameters.AddWithValue("BirimFiyat", checkBox3.Checked);
                    }
                    else if (checkBox6.Checked != true)
                    {
                        Görrr.Parameters.AddWithValue("MinStok", checkBox6.Checked);
                    }
                    else if (checkBox7.Checked != true)
                    {
                        Görrr.Parameters.AddWithValue("TSüresi", checkBox7.Checked);
                    }

                    DataTable dt = new DataTable();
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(Görrr);
                    sqlDataAdapter.Fill(dt);
                    dataGridView1.DataSource = dt;

                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { SqlConnection.Close(); }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Listele2();
        }

        private void Listele2()
        {
        //    if (txtrütbe.Text == "Yüksek")
        //    {
        //        SqlCommand
        //        DataTable dt = new DataTable(); 
        //        SqlDataAdapter

        //    }
        }

        private void lbldep_Click(object sender, EventArgs e)
        {

        }
    }
}
