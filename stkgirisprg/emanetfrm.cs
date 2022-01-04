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
    public partial class emanetfrm : Form
    {
        public Point mouseLocation;
        public emanetfrm()
        {
            InitializeComponent();
        }
        SqlConnection kaydetbtn = new SqlConnection("Data Source=DESKTOP-BG6FHSR;Initial Catalog=StokEklePrg;Integrated Security=True");

        private void emanetfrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stokEklePrgDataSet10.TblEmanet' table. You can move, or remove it, as needed.
            this.tblEmanetTableAdapter.Fill(this.stokEklePrgDataSet10.TblEmanet);
            StyleDatagridView();
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
        private void mouse_down(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }
        private void mouse_move(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;

            }
        }

        
    }
}
