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
    public partial class Giriş : Form
    {
        public Giriş()
        {
            InitializeComponent();
        }
        public int sayaç=0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            sayaç++;
            label5.Text = sayaç.ToString();
            if (sayaç % 1 == 0)
            {
                progressBar1.Value += 1;
            }
            if (sayaç == 60)
            { 
                timer1.Stop();
            if (this.Visible) {
                   
                    Application.Exit();
                }
            }
            
        }
        private void timermetot()
        {
            

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            KullanıcıGiriş kullanıcı =new KullanıcıGiriş();
            kullanıcı.Show();
            this.Hide();
        }

        private void Giriş_Load(object sender, EventArgs e)
        {

        }
    }
}
