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

namespace stkgirisprg
{
    public partial class GoruntuleFrm : Form
    {
        public Point mouseLocation;


        public GoruntuleFrm()
        {
            InitializeComponent();
        }
        SqlConnection kaydetbtn = new SqlConnection("Data Source=DESKTOP-BG6FHSR;Initial Catalog=StokEklePrg;Integrated Security=True");

        private void label11_Click(object sender, EventArgs e)
        {
            YapilacakIslemlerFrm geri = new YapilacakIslemlerFrm();
            geri.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            

            // Ürün Sayısı
            kaydetbtn.Open();
            SqlCommand komut1 = new SqlCommand("Select Count(*) From TblStkEkle", kaydetbtn);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lblAdslMs.Text = dr1[0].ToString();
            }
            kaydetbtn.Close();

            // Farklı Ürün Sayısı
             kaydetbtn.Open();
             SqlCommand komut2 = new SqlCommand("Select Count(distinct(Kategoriler)) From TblStkEkle ", kaydetbtn);
             SqlDataReader dr2 = komut2.ExecuteReader();
             while (dr2.Read())
             {
                 lblDizustu.Text = dr2[0].ToString();
             }
             kaydetbtn.Close();

            //  StyleDatagridView();

           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            kaydetbtn.Open();

            SqlCommand komut4 = new SqlCommand("Select * From TblStkEkle", kaydetbtn);
            SqlDataReader oku = komut4.ExecuteReader();
            while (oku.Read()) 
            {
              //  MessageBox.Show("oku[UrunNo].ToString()"+ oku["UrunNo"].ToString());
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["UrunNo"].ToString();
                ekle.SubItems.Add(oku["Kategoriler"].ToString());
                ekle.SubItems.Add(oku["UrunAdi"].ToString());
                ekle.SubItems.Add(oku["SeriNo"].ToString());
                ekle.SubItems.Add(oku["Tarih"].ToString());
                ekle.SubItems.Add(oku["Mudurluk"].ToString());
                ekle.SubItems.Add(oku["Duzenleyen"].ToString());
                ekle.SubItems.Add(oku["Degisim"].ToString());
                ekle.SubItems.Add(oku["Notlar"].ToString());
                listView1.Items.Add(ekle);
            }

            kaydetbtn.Close();
           
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

        private void btnbul_Click(object sender, EventArgs e)
        {

            listView1.Items.Clear();


            kaydetbtn.Open();

            SqlCommand komut4 = new SqlCommand("Select * From TblStkEkle Where SeriNo like '%"+ txtbul.Text + "%'", kaydetbtn);
            SqlDataReader oku = komut4.ExecuteReader();
           while (oku.Read()) 
            {

                ListViewItem ekle = new ListViewItem();
                ekle.Text=oku["UrunNo"].ToString();
                ekle.SubItems.Add(oku["Kategoriler"].ToString());
                ekle.SubItems.Add(oku["UrunAdi"].ToString());
                ekle.SubItems.Add(oku["SeriNo"].ToString());
                ekle.SubItems.Add(oku["Tarih"].ToString());
                ekle.SubItems.Add(oku["Mudurluk"].ToString());
                ekle.SubItems.Add(oku["Duzenleyen"].ToString());
                ekle.SubItems.Add(oku["Degisim"].ToString());
                ekle.SubItems.Add(oku["Notlar"].ToString());
                listView1.Items.Add(ekle);
            }
            kaydetbtn.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
