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
    public partial class Patron_Kayıt : Form
    {
        public Patron_Kayıt()
        {
            InitializeComponent();
        }

        //Bağlantı
        SqlConnection SqlConnectio = new SqlConnection("Data Source = LAPTOP-HMITB4AP;Initial Catalog = STOK3;Integrated Security = True;");


        private void Patron_Kayıt_Load(object sender, EventArgs e)
        {

        }

        //Patron Kayıt Metodu
        private void PatronKayıt()
        {
            try
            {
                if (!String.IsNullOrEmpty(txtad.Text) &&
                        !String.IsNullOrEmpty(txtsoyad.Text) &&
                        !String.IsNullOrEmpty(txtdepartman.Text) &&
                        !String.IsNullOrEmpty(msktc.Text) &&
                        !String.IsNullOrEmpty(mskşifre.Text))
                {
                    SqlConnectio.Open();
                    SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Patronlar P WHERE KullanıcıTC=@tc", SqlConnectio);
                    checkCmd.Parameters.AddWithValue("@tc", msktc.Text);


                    int userExist = (int)checkCmd.ExecuteScalar();
                    if (userExist <= 0)
                    {
                        SqlCommand cmd = new SqlCommand("INSERT INTO Patronlar(KullanıcıAd,KullanıcıSoyad,KullanıcıDepartman,KullanıcıTC,KullanıcıŞifre)Values(@P1,@P2,@P3,@P4,@P5)", SqlConnectio);
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
                SqlConnectio.Close();
            }
        }


        //Geri Dönüş Butonu
        private void button4_Click(object sender, EventArgs e)
        {
            Patron_Giriş ptr = new Patron_Giriş();
            ptr.Show();
            this.Close();
        }

        //Patron Kayıt Butonu
        private void button3_Click(object sender, EventArgs e)
        {
            PatronKayıt();
        }
    }
}
