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
    public partial class IşçiKayıt : Form
    {

        //Bağlantı
        SqlConnection SqlConnection = new SqlConnection("Data Source=LAPTOP-HMITB4AP;Initial Catalog=STOK3;Integrated Security=True;");
        //Bağlantı_datası bağlantı = new Bağlantı_datası();
        //SqlConnection SqlConnection = bağlantı.baglan();

        public IşçiKayıt()
        {
            InitializeComponent();
        }

        //Boşluk kalmaması için
        private void msktc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            msktc.Text.Trim();
        }

        //Boşluk kalmaması için
        private void txtdepartman_TextChanged(object sender, EventArgs e)
        {
            txtdepartman.Text.Trim();
        }

        //Boşluk kalmaması için
        private void txtsoyad_TextChanged(object sender, EventArgs e)
        {
            txtsoyad.Text.Trim();
        }

        //Boşluk kalmaması için
        private void txtad_TextChanged(object sender, EventArgs e)
        {
            txtad.Text.Trim();
        }

        private void KullanıcıKayıt_Load(object sender, EventArgs e)
        {

        }

        //Giriş Butonu
        private void button3_Click(object sender, EventArgs e)
        {
            Kayıtmetodu();
        }

        //Ekleme Metodu
        private void Kayıtmetodu()
        {
            try
            {
                if (!String.IsNullOrEmpty(txtad.Text) &&
                        !String.IsNullOrEmpty(txtsoyad.Text) &&
                        !String.IsNullOrEmpty(txtdepartman.Text) &&
                        !String.IsNullOrEmpty(msktc.Text) &&
                        !String.IsNullOrEmpty(mskşifre.Text))
                {
                    SqlConnection.Open();
                    SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Işçiler I WHERE KullanıcıTC=@tc", SqlConnection);
                    checkCmd.Parameters.AddWithValue("@tc", msktc.Text);



                    int userExist = (int)checkCmd.ExecuteScalar();
                    if (userExist <= 0)
                    {
                        SqlCommand cmd = new SqlCommand("INSERT INTO Işçiler(KullanıcıAd,KullanıcıSoyad,KullanıcıDepartman,KullanıcıTC,KullanıcıŞifre)Values(@P1,@P2,@P3,@P4,@P5)", SqlConnection);
                        cmd.Parameters.AddWithValue("@P1", txtad.Text);
                        cmd.Parameters.AddWithValue("@P2", txtsoyad.Text);
                        cmd.Parameters.AddWithValue("@P3", txtdepartman.Text);
                        cmd.Parameters.AddWithValue("@P4", msktc.Text);
                        cmd.Parameters.AddWithValue("@P5", mskşifre.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Kayıt Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Bu Tc Zaten Kullanılıyor");
                    }
                }
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                SqlConnection.Close();
            }
        }

        //Boşluk kalmaması için
        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            mskşifre.Text.Trim();
        }

        //Geri Dönüş Butonu
        private void button4_Click(object sender, EventArgs e)
        {
            Işçi_Giriş ışçi_ = new Işçi_Giriş();
            ışçi_.Show();
            this.Close();
        }
    }
}
