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
    public partial class EnvanterFrm1 : Form
    {

        public Point mouseLocation;

        public EnvanterFrm1()
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

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Form11_Load(object sender, EventArgs e)
        {
            kaydetbtn.Open();
            SqlCommand komutg1 = new SqlCommand("Select Kategoriler,Count(*) From TblStkEkle Group By Kategoriler ",kaydetbtn);
            SqlDataReader dr1 = komutg1.ExecuteReader();
            while (dr1.Read())
            {
                chart1.Series["Kategori"].Points.AddXY(dr1[0],dr1[1]);
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

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
