using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using FontAwesome.Sharp;


namespace stkgirisprg
{
    public partial class GirisSayfaFrm : Form
    {

        public Point mouseLocation;


        private IconButton currentBtn;
        private Panel leftBorderBtn;

        public GirisSayfaFrm()
        {
            InitializeComponent();
            txtKullaniciAd.Focus();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
        }
        SqlConnection kaydetbtn = new SqlConnection("Data Source=DESKTOP-BG6FHSR;Initial Catalog=StokEklePrg;Integrated Security=True");
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(253, 138, 114);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            
        }

        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //Left Border Button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(527, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

            }

        }
        private void DisableButton()
        {

            if (currentBtn != null)
            {

                currentBtn.BackColor = Color.FromArgb(60, 83, 131);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;

            }


 /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



        //    SqlConnection kaydetbtn = new SqlConnection("Data Source=DESKTOP-BG6FHSR;Initial Catalog=StokEklePrg;Integrated Security=True");

     
        }

        private void ıconButton1_Click(object sender, EventArgs e)
        {
            
            ActivateButton(sender, RGBColors.color1);
           kaydetbtn.Open();
           SqlCommand komut = new SqlCommand("Select * From TblYonetici Where KullaniciAd=@p1 and Sifre=@p2", kaydetbtn);
           komut.Parameters.AddWithValue("@p1", txtKullaniciAd.Text);
           komut.Parameters.AddWithValue("@p2", txtSifre.Text);
           SqlDataReader dr = komut.ExecuteReader();
           if (dr.Read())
           {
               YapilacakIslemlerFrm gir = new YapilacakIslemlerFrm();
               gir.Show();
               this.Hide();

           }
           else
           {
               MessageBox.Show("Hatalı Kullanıcı Adı ya da Şifre");
           }
           kaydetbtn.Close();
            
        }

        private void txtKullaniciAd_Click(object sender, EventArgs e)
        {
            txtKullaniciAd.Clear();
            panel4.ForeColor = Color.FromArgb(62, 83, 183);
            pic.ForeColor = Color.FromArgb(62, 83, 183);
            txtKullaniciAd.ForeColor = Color.FromArgb(62, 83, 183);
            
        }

        private void txtSifre_Click(object sender, EventArgs e)
        {
            txtSifre.Clear();
            panel4.ForeColor = Color.FromArgb(62, 83, 183);
            piclocked.ForeColor = Color.FromArgb(62, 83, 183);
            txtSifre.ForeColor = Color.FromArgb(62, 83, 183);
            txtSifre.PasswordChar = '*';
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AnaSayfa anasyf = new AnaSayfa();
            anasyf.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void Form2_Load(object sender, EventArgs e)
        {

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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    } }
