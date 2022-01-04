using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stkgirisprg
{
    public partial class YapilacakIslemlerFrm : Form
    {
        public Point mouseLocation;
        public YapilacakIslemlerFrm()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Close();
        }

       

        private void label11_Click(object sender, EventArgs e)
        {
            AnaSayfa geri = new AnaSayfa();
            geri.Show();
            this.Hide();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                timer1.Stop();
            }
            Opacity += 0.2;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Opacity <= 0)
            {
                this.Close();
            }
            Opacity -= 0.2;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UrunEkleFrm ekle = new UrunEkleFrm();
            ekle.Show();
            // this.Hide();
            timer2.Start();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            GoruntuleFrm goruntule = new GoruntuleFrm();
            goruntule.Show();
            this.Hide();
        }

      

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            GoruntuleFrm goruntule = new GoruntuleFrm();
            goruntule.Show();
            this.Hide();
        }


        private void pictureBox6_Click(object sender, EventArgs e)
        {
            YetkiVerFrm yetki = new YetkiVerFrm();
            yetki.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            AyarlarFrm ayarlar = new AyarlarFrm();
            ayarlar.Show();
            this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            HareketlerFrm hareketler = new HareketlerFrm();
            hareketler.Show();
            this.Hide();
        }

       

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            EnvanterFrm1 envanter = new EnvanterFrm1();
            envanter.Show();
            this.Hide();
         }

        private void mouse_Down(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void mouse_Move(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;

            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            emanetfrm emanetgr = new emanetfrm();
            emanetgr.Show();
            this.Close();
        }
    }
    }
    

