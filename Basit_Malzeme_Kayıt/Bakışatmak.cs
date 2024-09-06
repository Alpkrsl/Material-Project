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
    public partial class Bakışatmak : Form
    {


        //sql bağlantı
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-HMITB4AP;Initial Catalog=STOK3;Integrated Security=True;");

        public Bakışatmak()
        {
            InitializeComponent();
        }


        //KullanıcıDeğiştirmeSayfasına Gitmek
        private void kullanıcıGirişDeğiştirmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullanıcıGiriş kullanıcı = new KullanıcıGiriş();
            kullanıcı.Show();
            this.Close();
        }

        private void malzemeKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MalzemeManipulasyonu panel = new MalzemeManipulasyonu();
            panel.Show();
            this.Close();
        }

        private void nelereBakmakİstiyorsunuzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Bakışatmak_Load(object sender, EventArgs e)
        {
            VeriGör();
            Listele();
        }

        private void Listele()
        {
            SqlCommand cmd = new SqlCommand("SELECT*FROM Işçi",baglanti);
            DataTable dataTable = new DataTable();  
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);    
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        public string tcknoo,şifree;
       public void VeriGör()
        {
            lbltc.Text = tcknoo;
            lblşifre.Text = şifree;
        }

        //private void patronPanelToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Patron_Panell patron = new Patron_Panell();
        //    patron.tc = lbltc.Text;
        //    patron.Show();
        //    this.Close();
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            Patron_Panell patron = new Patron_Panell();
            patron.tc = lbltc.Text;
            patron.şifre = lblşifre.Text;
            patron.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand çek = new SqlCommand("Işçi_Göster", baglanti);
                çek.CommandType = CommandType.StoredProcedure;
                çek.Parameters.AddWithValue("@P1", textBox1.Text);
                DataTable dataTable = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(çek);
                sqlDataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
