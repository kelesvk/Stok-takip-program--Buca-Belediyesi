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
    public partial class UrunEkleFrm : Form
    {
        public Point mouseLocation;

        public UrunEkleFrm()
        {
            InitializeComponent();
        }

        SqlConnection kaydetbtn = new SqlConnection("Data Source=DESKTOP-BG6FHSR;Initial Catalog=StokEklePrg;Integrated Security=True");
        void temizle()
        {
            cmbkategoriler.Text = "";
            cmbDuzenleyen.Text = "";
            cmbMudurluk.Text = "";
            txtSeriNo.Text = "";
            txturunadi.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            rchtxtnotlar.Text = "";
            cmbkategoriler.Focus();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stokTakipOrnekDataSet.Table_1' table. You can move, or remove it, as needed.
         //   this.table_1TableAdapter.Fill(this.stokTakipOrnekDataSet.Table_1);
            // TODO: This line of code loads data into the 'stokEklePrgDataSet5.TblStkEkle' table. You can move, or remove it, as needed.
            this.tblStkEkleTableAdapter.Fill(this.stokEklePrgDataSet5.TblStkEkle);

            StyleDatagridView();




        }
        void populatedatagridview()
        {
            



        }

        void StyleDatagridView()
        {
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238,239,249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.FromArgb(30,30,30);
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Geometria",9);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(60, 83, 131);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kaydetbtn.Open();
            SqlCommand komut = new SqlCommand("insert into TblStkEkle (Kategoriler, UrunAdi, SeriNo, Tarih, Mudurluk, Duzenleyen, Degisim,Notlar) values(@p1, @p2, @p3, @p4, @p5,@p6,@p7,@p8)", kaydetbtn);
            komut.Parameters.AddWithValue("@p1", cmbkategoriler.Text);
            komut.Parameters.AddWithValue("@p2", txturunadi.Text);
            komut.Parameters.AddWithValue("@p3", txtSeriNo.Text);
            komut.Parameters.AddWithValue("@p4", dtbTarih.Text);
            komut.Parameters.AddWithValue("@p5", cmbMudurluk.Text);
            komut.Parameters.AddWithValue("@p6", cmbDuzenleyen.Text);
            komut.Parameters.AddWithValue("@p7", lblrdbtn.Text);
            komut.Parameters.AddWithValue("@p8", rchtxtnotlar.Text);

            komut.ExecuteNonQuery();
            kaydetbtn.Close();




            MessageBox.Show("Eklendi");


           // kaydetbtn.Close();
            // TODO: This line of code loads data into the 'stokEklePrgDataSet5.TblStkEkle' table. You can move, or remove it, as needed.
            this.tblStkEkleTableAdapter.Fill(this.stokEklePrgDataSet5.TblStkEkle);



           //s temizle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            temizle();
        }
      

        private void label11_Click(object sender, EventArgs e)
        {
            YapilacakIslemlerFrm geri = new YapilacakIslemlerFrm();
            geri.Show();
            this.Hide();
        }

        private void cmbMudurluk_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbkategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                lblrdbtn.Text = "True";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                lblrdbtn.Text = "False";
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtUrunNo.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            cmbkategoriler.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txturunadi.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtSeriNo.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            dtbTarih.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            cmbMudurluk.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            cmbDuzenleyen.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            lblrdbtn.Text= dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            rchtxtnotlar.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();

        }

        private void lblrdbtn_TextChanged(object sender, EventArgs e)
        {  
            if (lblrdbtn.Text == "True")
            {
                radioButton1.Checked = true;
            }
            if (lblrdbtn.Text == "False")
            {
                radioButton2.Checked = true;
            }
          /*  if else
            {
                MessageBox.Show("Değişiklik kısmı boş bırakılamaz");
            }*/
        }

        private void button5_Click(object sender, EventArgs e)
        {
            kaydetbtn.Open();
            SqlCommand komutsil = new SqlCommand("Delete From TblStkEkle Where UrunNo=@k1", kaydetbtn);
            komutsil.Parameters.AddWithValue("@k1", txtUrunNo.Text);
            komutsil.ExecuteNonQuery();

            kaydetbtn.Close();



            MessageBox.Show("Kullanici Silindi");
            // TODO: This line of code loads data into the 'stokEklePrgDataSet5.TblStkEkle' table. You can move, or remove it, as needed.
            this.tblStkEkleTableAdapter.Fill(this.stokEklePrgDataSet5.TblStkEkle);

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            kaydetbtn.Open();
            SqlCommand komutguncelle = new SqlCommand("Update TblStkEkle Set Kategoriler=@a1, UrunAdi=@a2, SeriNo=@a3, Tarih=@a4, Mudurluk=@a5, Duzenleyen=@a6, Degisim=@a7, Notlar=@a8 Where UrunNo=@a9", kaydetbtn);
           // MessageBox.Show("komutguncelle" + komutguncelle.CommandText);

            komutguncelle.Parameters.AddWithValue("@a1", cmbkategoriler.Text);
            komutguncelle.Parameters.AddWithValue("@a2", txturunadi.Text);
            komutguncelle.Parameters.AddWithValue("@a3", txtSeriNo.Text);
            komutguncelle.Parameters.AddWithValue("@a4", dtbTarih.Text);
            komutguncelle.Parameters.AddWithValue("@a5", cmbMudurluk.Text);
            komutguncelle.Parameters.AddWithValue("@a6", cmbDuzenleyen.Text);
            komutguncelle.Parameters.AddWithValue("@a7", lblrdbtn.Text);
            komutguncelle.Parameters.AddWithValue("@a8", rchtxtnotlar.Text);
            komutguncelle.Parameters.AddWithValue("@a9", txtUrunNo.Text);

            komutguncelle.ExecuteNonQuery();

         //  MessageBox.Show("lblrdbtn.text" + lblrdbtn.Text);
            kaydetbtn.Close();
            // TODO: This line of code loads data into the 'stokEklePrgDataSet5.TblStkEkle' table. You can move, or remove it, as needed.
            this.tblStkEkleTableAdapter.Fill(this.stokEklePrgDataSet5.TblStkEkle);
            MessageBox.Show("Bilgiler Güncellendi");
            

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
                this.Hide();
            }
            Opacity -= 0.2;
        }
        private void btnenvanter_Click(object sender, EventArgs e)
        {
            EnvanterFrm1 formgr = new EnvanterFrm1();
            formgr.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            btnsil.Visible = false;
            btnguncelle.Visible = false;
            btnenvanter.Visible = false;
            lblekle.Visible = true;
            txtKtgr.Visible = true;
            btnktgri.Visible = true;
            button3.Visible = false;
            lblekle.Focus();
        }

        private void btnktgri_Click(object sender, EventArgs e)
        {
            cmbkategoriler.Items.Add(txtKtgr.Text);
            MessageBox.Show("Yeni Kategori Eklendi");
           button4.Visible = true;
            btnsil.Visible = true;
            btnguncelle.Visible = true;
            btnenvanter.Visible = true;
            lblekle.Visible = false;
            txtKtgr.Visible = false;
            btnktgri.Visible = false;
            button3.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lblekle.Text = "Müdürlük Ekle:";
            btnMudurluk.Text = "Müdürlük Ekle";
            button4.Visible = false;
            btnsil.Visible = false;
            btnguncelle.Visible = false;
            btnenvanter.Visible = false;
            lblekle.Visible = true;
            txtKtgr.Visible = true;
            btnMudurluk.Visible = true;
            button3.Visible = false;
            lblekle.Focus();
        }

        private void btnMudurluk_Click(object sender, EventArgs e)
        {
            cmbMudurluk.Items.Add(txtKtgr.Text);
            MessageBox.Show("Yeni Müdürlük Eklendi");
            button4.Visible = true;
            btnsil.Visible = true;
            btnguncelle.Visible = true;
            btnenvanter.Visible = true;
            lblekle.Visible = false;
            txtKtgr.Visible = false;
            btnMudurluk.Visible = false;
            button3.Visible = true;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
