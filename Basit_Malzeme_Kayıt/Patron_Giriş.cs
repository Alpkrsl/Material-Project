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
    public partial class Patron_Giriş : Form
    {
        public Patron_Giriş()
        {
            InitializeComponent();
        }

        //Bağlantı
        SqlConnection SqlCon = new SqlConnection("Data Source=LAPTOP-HMITB4AP;Initial Catalog=STOK3;Integrated Security=True;");

        //Geri Gitme Butonu
        private void button1_Click(object sender, EventArgs e)
        {
            KullanıcıGiriş kullan =new KullanıcıGiriş();
            kullan.Show();
            this.Close();
        }

        //Patron Kayıt Butonu
        private void btngirişyap_Click(object sender, EventArgs e)
        {
            PatronKayıt();
        }

        //Patron Kayıt Metodu
        private void PatronKayıt()
        {
            try
            {

                if (!string.IsNullOrEmpty(msktc1.Text) &&
                   !string.IsNullOrEmpty(mskşifre1.Text))
                    SqlCon.Open();
                SqlCommand giriş = new SqlCommand("SELECT*FROM Patronlar WHERE KullanıcıTC=@P1 AND KullanıcıŞifre=@P2", SqlCon);
                giriş.Parameters.AddWithValue("@P1", msktc1.Text);
                giriş.Parameters.AddWithValue("@P2", mskşifre1.Text);
                SqlDataReader dr = giriş.ExecuteReader();
                if (dr.Read())
                {
                    Patron_Panell pat = new Patron_Panell();
                    pat.tc = msktc1.Text;
                    pat.şifre = mskşifre1.Text;
                    pat.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Yanlış Şifre veya Kullanıcı Adı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                SqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                //MessageBox.Show("Giriş Yaptınız", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Patron Kayıta
        private void btnüyekayıt_Click(object sender, EventArgs e)
        {
            Patron_Kayıt patron = new Patron_Kayıt();
            patron.Show();
            this.Hide();
        }

        private void Patron_Giriş_Load(object sender, EventArgs e)
        {

        }
    }
}
