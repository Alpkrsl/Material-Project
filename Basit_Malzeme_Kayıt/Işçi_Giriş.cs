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
    public partial class Işçi_Giriş : Form
    {
        //string connectionString = "Server=SERVER_ADI; Database=DATABASE_ADI; User Id=YOUR_USERNAME; Password=YOUR_PASSWORD;";
        //Data Source=LAPTOP-HMITB4AP;Initial Catalog=STOK3;Integrated Security=True;Trust Server Certificate=True;Server SPN=True
        //Bağlantı
        SqlConnection SqlCon = new SqlConnection("Data Source=LAPTOP-HMITB4AP;Initial Catalog=STOK3;Integrated Security=True;");
        public Işçi_Giriş()
        {
            InitializeComponent();
        }

        private void btnüyekayıt_Click(object sender, EventArgs e)
        {
            IşçiKayıt kullanıcıKayıt =new IşçiKayıt();
            kullanıcıKayıt.Show();
            this.Close();
        }
        public string @P1, @P2;

        private void button1_Click(object sender, EventArgs e)
        {
            KullanıcıGiriş kullanıcıGiriş = new KullanıcıGiriş();
            kullanıcıGiriş.Show();
            this.Close();
        }

        private void msktc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            msktc.Text.Trim();

        }

        //Tc Aktarım
        //private void tcaktarım()
        //{
        //    Işçi_Panel panel = new Işçi_Panel();
        //    panel.tc = msktc.Text;

        //}

        private void mskşifre_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            mskşifre.Text.Trim();
        }

        //İşçi Ekran Yükleme
        private void Işçi_Giriş_Load(object sender, EventArgs e)
        {

        }

        private void btngirişyap_Click(object sender, EventArgs e)
        {

            try
            {

                if (!string.IsNullOrEmpty(msktc.Text) &&
                   !string.IsNullOrEmpty(mskşifre.Text))
                    SqlCon.Open();
                SqlCommand giriş = new SqlCommand("SELECT*FROM Işçiler WHERE KullanıcıTC=@R1 AND KullanıcıŞifre=@R2", SqlCon);
                giriş.Parameters.AddWithValue("@R1", msktc.Text);
                giriş.Parameters.AddWithValue("@R2", mskşifre.Text);
                SqlDataReader dr=giriş.ExecuteReader();
                if(dr.Read())
                {
                        Işçi_Panel ışçi_ =new Işçi_Panel();
                    ışçi_.tc = msktc.Text;
                    ışçi_.Show();
                        this.Close();
                }
                else
                {
                    MessageBox.Show("Yanlış Şifre veya Kullanıcı Adı","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                SqlCon.Close();
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message,"Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {

                //MessageBox.Show("Giriş Yaptınız", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
