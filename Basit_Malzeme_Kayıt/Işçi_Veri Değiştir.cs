using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basit_Malzeme_Kayıt
{
    public partial class Işçi_Veri_Değiştir : Form
    {
        //Bağlantı
        SqlConnection SqlConnection = new SqlConnection("Data Source=LAPTOP-HMITB4AP;Initial Catalog=STOK3;Integrated Security=True;");
        public Işçi_Veri_Değiştir()
        {
            InitializeComponent();
        }

        private void Işçi_Veri_Değiştir_Load(object sender, EventArgs e)
        {
            verigörünüm();
            lİstele();
        }

        private void lİstele()
        {
            SqlCommand Işçii = new SqlCommand("Select*FROM Işçiler",SqlConnection);
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(Işçii);   
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource= dataTable;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Patron_Panell panel = new Patron_Panell();
                panel.tc = lbltc.Text;
                panel.şifre=lblşifre.Text;
                panel.Show();
                this.Close();
            }
            catch (Exception ex) { 
            MessageBox.Show(ex.Message,"Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        public string tc2,şifre2;
        //Veri Gör
        public void verigörünüm()
        {
           lbltc.Text=tc2;
            lblşifre.Text = şifre2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection.Open();
                    SqlCommand ekleme = new SqlCommand("Işçiler_Güncel2", SqlConnection);
                    ekleme.CommandType= CommandType.StoredProcedure;
                    ekleme.Parameters.AddWithValue("@R1",txtrütbe.Text);
                    ekleme.Parameters.AddWithValue("@R2",txtsattığımalzemeadedi.Text);
                    ekleme.Parameters.AddWithValue("@R3",txtmaaş.Text);
                    ekleme.Parameters.AddWithValue("@R4",txtıd.Text);
                    DataTable dt = new DataTable(); 
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(ekleme);
                    sqlDataAdapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    ekleme.ExecuteNonQuery();

                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally {
                SqlConnection.Close();
                lİstele();
            }

        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection.Open();
                SqlCommand getir = new SqlCommand("Işçi_Göster",SqlConnection);
                getir.CommandType= CommandType.StoredProcedure;
                getir.Parameters.AddWithValue("@P1",txtıd.Text);
                DataTable dataTable = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(getir);
                sqlDataAdapter.Fill(dataTable); 
                dataGridView1.DataSource= dataTable;
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

        private void btnlistele_Click(object sender, EventArgs e)
        {
            lİstele() ;
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection.Open();
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtıd.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtsattığımalzemeadedi.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            txtrütbe.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            txtmaaş.Text=dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            SqlConnection.Close();
        }
    }
}
