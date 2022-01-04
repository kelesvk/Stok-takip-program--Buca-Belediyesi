
namespace stkgirisprg
{
    partial class emanetfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(emanetfrm));
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stokEklePrgDataSet10 = new stkgirisprg.StokEklePrgDataSet10();
            this.tblEmanetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblEmanetTableAdapter = new stkgirisprg.StokEklePrgDataSet10TableAdapters.TblEmanetTableAdapter();
            this.mudurlukDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verilenTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notlarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtbTarih = new System.Windows.Forms.DateTimePicker();
            this.cmbMudurluk = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txturunadi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rchtxtnotlar = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokEklePrgDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmanetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Geometria", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(34, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 75);
            this.label1.TabIndex = 33;
            this.label1.Text = "EMANET";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(-8, 702);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1356, 53);
            this.panel2.TabIndex = 35;
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
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1138, -1);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(155, 255);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 34;
            this.pictureBox4.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(-4, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1356, 38);
            this.panel1.TabIndex = 32;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_down);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_move);
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
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mudurlukDataGridViewTextBoxColumn,
            this.sureDataGridViewTextBoxColumn,
            this.verilenTarihDataGridViewTextBoxColumn,
            this.notlarDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblEmanetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(492, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(589, 265);
            this.dataGridView1.TabIndex = 36;
            // 
            // stokEklePrgDataSet10
            // 
            this.stokEklePrgDataSet10.DataSetName = "StokEklePrgDataSet10";
            this.stokEklePrgDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblEmanetBindingSource
            // 
            this.tblEmanetBindingSource.DataMember = "TblEmanet";
            this.tblEmanetBindingSource.DataSource = this.stokEklePrgDataSet10;
            // 
            // tblEmanetTableAdapter
            // 
            this.tblEmanetTableAdapter.ClearBeforeFill = true;
            // 
            // mudurlukDataGridViewTextBoxColumn
            // 
            this.mudurlukDataGridViewTextBoxColumn.DataPropertyName = "Mudurluk";
            this.mudurlukDataGridViewTextBoxColumn.HeaderText = "Mudurluk";
            this.mudurlukDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mudurlukDataGridViewTextBoxColumn.Name = "mudurlukDataGridViewTextBoxColumn";
            this.mudurlukDataGridViewTextBoxColumn.Width = 125;
            // 
            // sureDataGridViewTextBoxColumn
            // 
            this.sureDataGridViewTextBoxColumn.DataPropertyName = "Sure";
            this.sureDataGridViewTextBoxColumn.HeaderText = "Sure";
            this.sureDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sureDataGridViewTextBoxColumn.Name = "sureDataGridViewTextBoxColumn";
            this.sureDataGridViewTextBoxColumn.Width = 125;
            // 
            // verilenTarihDataGridViewTextBoxColumn
            // 
            this.verilenTarihDataGridViewTextBoxColumn.DataPropertyName = "VerilenTarih";
            this.verilenTarihDataGridViewTextBoxColumn.HeaderText = "VerilenTarih";
            this.verilenTarihDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.verilenTarihDataGridViewTextBoxColumn.Name = "verilenTarihDataGridViewTextBoxColumn";
            this.verilenTarihDataGridViewTextBoxColumn.Width = 125;
            // 
            // notlarDataGridViewTextBoxColumn
            // 
            this.notlarDataGridViewTextBoxColumn.DataPropertyName = "Notlar";
            this.notlarDataGridViewTextBoxColumn.HeaderText = "Notlar";
            this.notlarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.notlarDataGridViewTextBoxColumn.Name = "notlarDataGridViewTextBoxColumn";
            this.notlarDataGridViewTextBoxColumn.Width = 125;
            // 
            // dtbTarih
            // 
            this.dtbTarih.CalendarFont = new System.Drawing.Font("Geometria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtbTarih.CalendarForeColor = System.Drawing.Color.Azure;
            this.dtbTarih.CalendarMonthBackground = System.Drawing.Color.Azure;
            this.dtbTarih.Location = new System.Drawing.Point(229, 338);
            this.dtbTarih.Name = "dtbTarih";
            this.dtbTarih.Size = new System.Drawing.Size(216, 22);
            this.dtbTarih.TabIndex = 37;
            // 
            // cmbMudurluk
            // 
            this.cmbMudurluk.BackColor = System.Drawing.Color.Azure;
            this.cmbMudurluk.Font = new System.Drawing.Font("Geometria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbMudurluk.ForeColor = System.Drawing.Color.Black;
            this.cmbMudurluk.FormattingEnabled = true;
            this.cmbMudurluk.Items.AddRange(new object[] {
            "Bilgi İşlem",
            "Basın Yayın Halkla İlişk.",
            "Çevre Koruma ve Kontrol",
            "Destek Hizmetleri",
            "Emlak İstimlak",
            "Etüt Proje",
            "Fen İşleri",
            "Hukuk İşleri",
            "İmar ve Şehircilik",
            "İnsan Kaynakları",
            "İşletme",
            "İşletme ve İştirakler",
            "Kadın ve Aile Hizmetleri",
            "Kentsel Tasarım",
            "Kültür ve Sosyal İşler",
            "Kütüphane",
            "Mali Hizmetler",
            "Muhtarlık İşleri Müdürlüğü",
            "Özel Kalem",
            "Park ve Bahçeler",
            "Plan ve Proje",
            "Ruhsat ve Denetim",
            "Sağlık İşleri",
            "Sivil Savunma",
            "Sosyal Yardım",
            "Spor İşleri",
            "Strateji Geliştirme",
            "Tarımsal Hizmetler",
            "Teftiş Kurulu",
            "Temizlik İşleri",
            "Tesisler ",
            "Ulaşım Hizmetleri",
            "Veteriner İşleri",
            "Yapı Kontrol",
            "Yazı İşleri",
            "Zabıta"});
            this.cmbMudurluk.Location = new System.Drawing.Point(229, 193);
            this.cmbMudurluk.Name = "cmbMudurluk";
            this.cmbMudurluk.Size = new System.Drawing.Size(216, 27);
            this.cmbMudurluk.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Geometria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(76, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 30);
            this.label8.TabIndex = 39;
            this.label8.Text = "Müdürlük:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Geometria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(39, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 30);
            this.label7.TabIndex = 40;
            this.label7.Text = "Verilen Tarih:";
            // 
            // txturunadi
            // 
            this.txturunadi.BackColor = System.Drawing.Color.Azure;
            this.txturunadi.Font = new System.Drawing.Font("Geometria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txturunadi.ForeColor = System.Drawing.Color.Black;
            this.txturunadi.Location = new System.Drawing.Point(230, 265);
            this.txturunadi.Name = "txturunadi";
            this.txturunadi.Size = new System.Drawing.Size(216, 26);
            this.txturunadi.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Geometria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(134, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 30);
            this.label2.TabIndex = 42;
            this.label2.Text = "Süre:";
            // 
            // rchtxtnotlar
            // 
            this.rchtxtnotlar.BackColor = System.Drawing.Color.Azure;
            this.rchtxtnotlar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rchtxtnotlar.Font = new System.Drawing.Font("Geometria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rchtxtnotlar.Location = new System.Drawing.Point(229, 405);
            this.rchtxtnotlar.Name = "rchtxtnotlar";
            this.rchtxtnotlar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rchtxtnotlar.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rchtxtnotlar.Size = new System.Drawing.Size(216, 96);
            this.rchtxtnotlar.TabIndex = 43;
            this.rchtxtnotlar.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Geometria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(111, 398);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 30);
            this.label12.TabIndex = 44;
            this.label12.Text = "Notlar:";
            // 
            // btnguncelle
            // 
            this.btnguncelle.BackColor = System.Drawing.Color.ForestGreen;
            this.btnguncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguncelle.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnguncelle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnguncelle.Location = new System.Drawing.Point(672, 446);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(173, 67);
            this.btnguncelle.TabIndex = 82;
            this.btnguncelle.Text = "GÜNCELLE";
            this.btnguncelle.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Geometria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(230, 524);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 47);
            this.button1.TabIndex = 80;
            this.button1.Text = "KAYDET";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.Maroon;
            this.btnsil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsil.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsil.Location = new System.Drawing.Point(491, 449);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(174, 64);
            this.btnsil.TabIndex = 81;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = false;
            // 
            // emanetfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1344, 756);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.rchtxtnotlar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txturunadi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtbTarih);
            this.Controls.Add(this.cmbMudurluk);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "emanetfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "emanetfrm";
            this.Load += new System.EventHandler(this.emanetfrm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokEklePrgDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmanetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private StokEklePrgDataSet10 stokEklePrgDataSet10;
        private System.Windows.Forms.BindingSource tblEmanetBindingSource;
        private StokEklePrgDataSet10TableAdapters.TblEmanetTableAdapter tblEmanetTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mudurlukDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn verilenTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notlarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dtbTarih;
        private System.Windows.Forms.ComboBox cmbMudurluk;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txturunadi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rchtxtnotlar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnsil;
    }
}