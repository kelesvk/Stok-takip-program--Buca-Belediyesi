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
    public partial class YetkiVerFrm : Form
    {

        public Point mouseLocation;

        public YetkiVerFrm()
        {
            InitializeComponent();
        }
        SqlConnection kaydetbtn = new SqlConnection("Data Source=DESKTOP-BG6FHSR;Initial Catalog=StokEklePrg;Integrated Security=True");

        void temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            
        }


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

        private void YetkiVerFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stokEklePrgDataSet9.TblYonetici' table. You can move, or remove it, as needed.
            this.tblYoneticiTableAdapter1.Fill(this.stokEklePrgDataSet9.TblYonetici);
            StyleDatagridView();

            // TODO: This line of code loads data into the 'stokEklePrgDataSet8.TblYonetici' table. You can move, or remove it, as needed.
            

        }
        void StyleDatagridView()
        {
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.FromArgb(30, 30, 30);
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Geometria", 9);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(60, 83, 131);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            kaydetbtn.Open();
            SqlCommand komut = new SqlCommand("insert into TblYonetici (KullaniciAd, Sifre) values(@p1, @p2)", kaydetbtn);
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox2.Text);
            komut.ExecuteNonQuery();
            kaydetbtn.Close();
            MessageBox.Show("Eklendi");

            temizle();

            // TODO: This line of code loads data into the 'stokEklePrgDataSet9.TblYonetici' table. You can move, or remove it, as needed.
            this.tblYoneticiTableAdapter1.Fill(this.stokEklePrgDataSet9.TblYonetici);
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            kaydetbtn.Open();
            SqlCommand komutsil = new SqlCommand("Delete From TblYonetici Where KullaniciAd=@s1", kaydetbtn);
            komutsil.Parameters.AddWithValue("@s1", textBox1.Text);
            komutsil.ExecuteNonQuery();

            kaydetbtn.Close();
            MessageBox.Show("Kayıt Silindi");
            // TODO: This line of code loads data into the 'stokEklePrgDataSet9.TblYonetici' table. You can move, or remove it, as needed.
            this.tblYoneticiTableAdapter1.Fill(this.stokEklePrgDataSet9.TblYonetici);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kaydetbtn.Open();
            SqlCommand komutguncelle = new SqlCommand("Update TblYonetici Set KullaniciAd=@a1, Sifre=@a2 Where KullaniciAd=@a1", kaydetbtn);
           

            komutguncelle.Parameters.AddWithValue("@a1", textBox1.Text);
            komutguncelle.Parameters.AddWithValue("@a2", textBox2.Text);

            komutguncelle.ExecuteNonQuery();

           
            kaydetbtn.Close();


            // TODO: This line of code loads data into the 'stokEklePrgDataSet9.TblYonetici' table. You can move, or remove it, as needed.
            this.tblYoneticiTableAdapter1.Fill(this.stokEklePrgDataSet9.TblYonetici);
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            textBox1.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }
    }
}
