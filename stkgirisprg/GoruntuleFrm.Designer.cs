
namespace stkgirisprg
{
    partial class GoruntuleFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoruntuleFrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tblStkEkleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stokEklePrgDataSet7 = new stkgirisprg.StokEklePrgDataSet7();
            this.tblStkEkleTableAdapter = new stkgirisprg.StokEklePrgDataSet7TableAdapters.TblStkEkleTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAdslMs = new System.Windows.Forms.Label();
            this.group = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDizustu = new System.Windows.Forms.Label();
            this.txtbul = new System.Windows.Forms.TextBox();
            this.btnbul = new System.Windows.Forms.Button();
            this.lblbul = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblStkEkleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokEklePrgDataSet7)).BeginInit();
            this.group.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(-4, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1356, 38);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_Down);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_Move);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label11.Font = new System.Drawing.Font("Cocogoose", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(16, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 29);
            this.label11.TabIndex = 25;
            this.label11.Text = "<";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Cocogoose", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(1311, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 29);
            this.label5.TabIndex = 13;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1138, -1);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(155, 255);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 26;
            this.pictureBox4.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(-8, 702);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1356, 53);
            this.panel2.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Geometria", 7.799999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(528, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(295, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "BUCA BELEDİYESİ - TÜM HAKLARI SAKLIDIR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Geometria", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(34, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 75);
            this.label1.TabIndex = 17;
            this.label1.Text = "GÖRÜNTÜLE";
            // 
            // tblStkEkleBindingSource
            // 
            this.tblStkEkleBindingSource.DataMember = "TblStkEkle";
            this.tblStkEkleBindingSource.DataSource = this.stokEklePrgDataSet7;
            // 
            // stokEklePrgDataSet7
            // 
            this.stokEklePrgDataSet7.DataSetName = "StokEklePrgDataSet7";
            this.stokEklePrgDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblStkEkleTableAdapter
            // 
            this.tblStkEkleTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Geometria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(96, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 21);
            this.label2.TabIndex = 29;
            this.label2.Text = "Ürün Sayısı:";
            // 
            // lblAdslMs
            // 
            this.lblAdslMs.AutoSize = true;
            this.lblAdslMs.Font = new System.Drawing.Font("Geometria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdslMs.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblAdslMs.Location = new System.Drawing.Point(220, 46);
            this.lblAdslMs.Name = "lblAdslMs";
            this.lblAdslMs.Size = new System.Drawing.Size(22, 21);
            this.lblAdslMs.TabIndex = 29;
            this.lblAdslMs.Text = "0";
            // 
            // group
            // 
            this.group.Controls.Add(this.button1);
            this.group.Controls.Add(this.label7);
            this.group.Controls.Add(this.label6);
            this.group.Controls.Add(this.lblDizustu);
            this.group.Controls.Add(this.label2);
            this.group.Controls.Add(this.lblAdslMs);
            this.group.Font = new System.Drawing.Font("Geometria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.group.ForeColor = System.Drawing.SystemColors.GrayText;
            this.group.Location = new System.Drawing.Point(17, 548);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(1315, 129);
            this.group.TabIndex = 30;
            this.group.TabStop = false;
            this.group.Text = "Kategori Sayı Bilgisi";
            this.group.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Geometria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(275, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 85);
            this.button1.TabIndex = 30;
            this.button1.Text = "Listele";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Geometria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(45, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 21);
            this.label7.TabIndex = 29;
            this.label7.Text = "Farklı Ürün Sayısı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Geometria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(291, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 21);
            this.label6.TabIndex = 29;
            // 
            // lblDizustu
            // 
            this.lblDizustu.AutoSize = true;
            this.lblDizustu.Font = new System.Drawing.Font("Geometria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDizustu.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblDizustu.Location = new System.Drawing.Point(220, 76);
            this.lblDizustu.Name = "lblDizustu";
            this.lblDizustu.Size = new System.Drawing.Size(22, 21);
            this.lblDizustu.TabIndex = 29;
            this.lblDizustu.Text = "0";
            // 
            // txtbul
            // 
            this.txtbul.BackColor = System.Drawing.Color.Azure;
            this.txtbul.Font = new System.Drawing.Font("Geometria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbul.Location = new System.Drawing.Point(775, 73);
            this.txtbul.Name = "txtbul";
            this.txtbul.Size = new System.Drawing.Size(238, 29);
            this.txtbul.TabIndex = 31;
            // 
            // btnbul
            // 
            this.btnbul.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnbul.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbul.Font = new System.Drawing.Font("Geometria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnbul.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnbul.Location = new System.Drawing.Point(1019, 64);
            this.btnbul.Name = "btnbul";
            this.btnbul.Size = new System.Drawing.Size(102, 49);
            this.btnbul.TabIndex = 32;
            this.btnbul.Text = "ARA";
            this.btnbul.UseVisualStyleBackColor = false;
            this.btnbul.Click += new System.EventHandler(this.btnbul_Click);
            // 
            // lblbul
            // 
            this.lblbul.AutoSize = true;
            this.lblbul.Font = new System.Drawing.Font("Geometria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblbul.Location = new System.Drawing.Point(719, 78);
            this.lblbul.Name = "lblbul";
            this.lblbul.Size = new System.Drawing.Size(44, 21);
            this.lblbul.TabIndex = 33;
            this.lblbul.Text = "Ara:";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Azure;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listView1.Font = new System.Drawing.Font("Geometria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(17, 150);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1315, 381);
            this.listView1.TabIndex = 34;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ürün No";
            this.columnHeader1.Width = 73;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Kategoriler";
            this.columnHeader2.Width = 175;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ürün Adı";
            this.columnHeader3.Width = 152;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Seri No";
            this.columnHeader4.Width = 173;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tarih";
            this.columnHeader6.Width = 193;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Müdürlük";
            this.columnHeader7.Width = 183;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Düzenleyen";
            this.columnHeader8.Width = 139;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Değişim";
            this.columnHeader9.Width = 87;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Notlar";
            this.columnHeader10.Width = 230;
            // 
            // GoruntuleFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1344, 756);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lblbul);
            this.Controls.Add(this.btnbul);
            this.Controls.Add(this.txtbul);
            this.Controls.Add(this.group);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GoruntuleFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblStkEkleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokEklePrgDataSet7)).EndInit();
            this.group.ResumeLayout(false);
            this.group.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private StokEklePrgDataSet7 stokEklePrgDataSet7;
        private System.Windows.Forms.BindingSource tblStkEkleBindingSource;
        private StokEklePrgDataSet7TableAdapters.TblStkEkleTableAdapter tblStkEkleTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAdslMs;
        private System.Windows.Forms.GroupBox group;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDizustu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtbul;
        private System.Windows.Forms.Button btnbul;
        private System.Windows.Forms.Label lblbul;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Label label6;
    }
}