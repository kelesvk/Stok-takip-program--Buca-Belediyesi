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
    public partial class HareketlerFrm : Form
    {

        public Point mouseLocation;

        public HareketlerFrm()
        {
            InitializeComponent();
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
    }
}
