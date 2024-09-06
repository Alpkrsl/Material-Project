using Basit_Malzeme_Kayıt.STOK3DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basit_Malzeme_Kayıt
{
    public partial class Işçi_Panel : Form
    {

        //Bağlantımız
        SqlConnection bağlantı = new SqlConnection("Data Source=LAPTOP-HMITB4AP;Initial Catalog=STOK3;Integrated Security=True;");


        public Işçi_Panel()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        //Seçme datagridview
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Seçme();

        }

        //Görülen veriler
        private void GörülebilenVeriler()
        {
            bağlantı.Open();
            if (lblrütbe.Text == "düşük") {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT*FROM DÜŞÜK_G", bağlantı);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                dataGridView2.DataSource = dt;
            }
           else if (lblrütbe.Text=="Orta") {
                SqlDataAdapter dataAdapterr = new SqlDataAdapter("SELECT*FROM Orta_G", bağlantı);
                DataTable dtt = new DataTable();
                dataAdapterr.Fill(dtt);
                dataGridView2.DataSource = dtt;
            }
          else  if (lblrütbe.Text == "Yüksek")
            {
                SqlDataAdapter dataAdapterrr = new SqlDataAdapter("SELECT*FROM Yüksek_G", bağlantı);
                DataTable dttt = new DataTable();
                dataAdapterrr.Fill(dttt);
                dataGridView2.DataSource = dttt;
            }
            bağlantı.Close();
        }

        public string tc;


       // Kişi Datası Metodu();
        private void KişiDatası()
        {
            try
            {
                // Kullanıcı TC'ye göre verileri çek
                LBLTC.Text = tc;
                bağlantı.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Işçiler WHERE KullanıcıTC = @P1", bağlantı);
                sqlCommand.Parameters.AddWithValue("@P1", LBLTC.Text);
                DataTable dataTable = new DataTable();  
                SqlDataAdapter sqlData= new SqlDataAdapter(sqlCommand);
                sqlData.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                sqlCommand.ExecuteNonQuery();
                bağlantı.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //load kısmı
        private void Işçi_Panel_Load(object sender, EventArgs e)
        {
            KişiDatası();
            VeriGör();
            GörülebilenVeriler();

        }

        private void VeriGör()
        {
            try
            {
                bağlantı.Open();
                SqlCommand ekleme = new SqlCommand("DEPARTMAN",bağlantı);
                ekleme.CommandType= CommandType.StoredProcedure;
                ekleme.Parameters.AddWithValue("@R1",LBLTC.Text);
                ekleme.Parameters.AddWithValue("@P2",lbldepartman.Text);
                lbldepartman.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
                lblrütbe.Text = dataGridView1.Rows[0].Cells[7].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                bağlantı.Close();
            }
        }

        //Girişe geri dönüş
        private void button1_Click(object sender, EventArgs e)
        {
            Işçi_Giriş ışçi_ = new Işçi_Giriş();
            ışçi_.Show();
            this.Close();
        }

        //Güncelleme Metodu
        private void button3_Click(object sender, EventArgs e)
        {
            GüncellemeMetot();
        }

        private void GüncellemeMetot()
        {
            try
            {
                bağlantı.Open();
                SqlCommand güncelle = new SqlCommand("Işçiler_Güncelleme", bağlantı);
                güncelle.CommandType = CommandType.StoredProcedure;
                güncelle.Parameters.AddWithValue("@p1", txtad.Text);
                güncelle.Parameters.AddWithValue("@p2", txtsoyad.Text);
                güncelle.Parameters.AddWithValue("@p3", txtdepartman.Text);
                güncelle.Parameters.AddWithValue("@p4", msktc.Text);
                güncelle.Parameters.AddWithValue("@p5", mskşifre.Text);
                güncelle.Parameters.AddWithValue("@p6", TXTID.Text);
                güncelle.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"Hata",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            finally
            {
                bağlantı.Close();
                KişiDatası();
            }
        }

        //Listeleme Metodu
        //private void Listele()
        //{
        //    try
        //    {
        //        bağlantı.Open();
        //        SqlCommand sqlCommand = new SqlCommand("SELECT*FROM Işçiler WHERE KullanıcıID=@p3",bağlantı);
        //        sqlCommand.Parameters.AddWithValue("@p3",TXTID.Text);
        //        DataTable dataTable = new DataTable();
        //        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
        //        sqlDataAdapter.Fill(dataTable);
        //        dataGridView1.DataSource = dataTable;
        //        sqlCommand.ExecuteNonQuery();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message,"Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
        //    }
        //    finally
        //    {
        //        bağlantı.Close();
        //    }
        //}


        //Kişinin bilgilerini textboxlara vermek
        private void Seçme()
        {
            bağlantı.Open();
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TXTID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString(); 
            txtsoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtdepartman.Text= dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            msktc.Text= dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            mskşifre.Text= dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            bağlantı.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
