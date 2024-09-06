using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basit_Malzeme_Kayıt
{
    public partial class KullanıcıGiriş : Form
    {
        public KullanıcıGiriş()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (textBox1.Text ==x)
            //{

            //}
            Işçi_Giriş ışçi_=new Işçi_Giriş();
            ışçi_.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Patron_Giriş patron_Giri = new Patron_Giriş();
            patron_Giri.Show();
            this.Close();
        }

        private void KullanıcıGiriş_Load(object sender, EventArgs e)
        {

        }
    }
}
