
namespace stkgirisprg
{
    partial class UrunEkleFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunEkleFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbkategoriler = new System.Windows.Forms.ComboBox();
            this.cmbMudurluk = new System.Windows.Forms.ComboBox();
            this.txturunadi = new System.Windows.Forms.TextBox();
            this.txtSeriNo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dtbTarih = new System.Windows.Forms.DateTimePicker();
            this.cmbDuzenleyen = new System.Windows.Forms.ComboBox();
            this.lblrdbtn = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.urunNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategorilerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seriNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mudurlukDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duzenleyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Degisim = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Notlar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblStkEkleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stokEklePrgDataSet5 = new stkgirisprg.StokEklePrgDataSet5();
            this.btnsil = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.rchtxtnotlar = new System.Windows.Forms.RichTextBox();
            this.tblStkEkleTableAdapter = new stkgirisprg.StokEklePrgDataSet5TableAdapters.TblStkEkleTableAdapter();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnenvanter = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.txtKtgr = new System.Windows.Forms.TextBox();
            this.lblekle = new System.Windows.Forms.Label();
            this.btnktgri = new System.Windows.Forms.Button();
            this.btnMudurluk = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtUrunNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStkEkleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokEklePrgDataSet5)).BeginInit();
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
            this.panel1.TabIndex = 3;
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
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1138, -1);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(155, 255);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(-8, 702);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1356, 53);
            this.panel2.TabIndex = 16;
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
            this.label1.Font = new System.Drawing.Font("Geometria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(103, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 30);
            this.label1.TabIndex = 17;
            this.label1.Text = "Ürün Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Geometria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(121, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 30);
            this.label3.TabIndex = 17;
            this.label3.Text = "Seri No:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Geometria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(71, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 30);
            this.label6.TabIndex = 17;
            this.label6.Text = "Kategoriler:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Geometria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(147, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 30);
            this.label7.TabIndex = 17;
            this.label7.Text = "Tarih:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Geometria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(95, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 30);
            this.label8.TabIndex = 17;
            this.label8.Text = "Müdürlük:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Geometria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(111, 381);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 30);
            this.label9.TabIndex = 17;
            this.label9.Text = "Değişim:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Geometria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(66, 328);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 30);
            this.label10.TabIndex = 17;
            this.label10.Text = "Düzenleyen:";
            // 
            // cmbkategoriler
            // 
            this.cmbkategoriler.BackColor = System.Drawing.Color.Azure;
            this.cmbkategoriler.Font = new System.Drawing.Font("Geometria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbkategoriler.ForeColor = System.Drawing.Color.Black;
            this.cmbkategoriler.FormattingEnabled = true;
            this.cmbkategoriler.Items.AddRange(new object[] {
            "Adsl Modem",
            "Dizüstü",
            "Ekran Kartı",
            "Harddisk",
            "Klavye",
            "Kulaklık",
            "Masaüstü",
            "Mouse",
            "Monitör",
            "Power Supply",
            "Ram",
            "SSD",
            "Switch",
            "Tarayıcı",
            "Usb Wifi",
            "Yazıcı"});
            this.cmbkategoriler.Location = new System.Drawing.Point(247, 85);
            this.cmbkategoriler.Name = "cmbkategoriler";
            this.cmbkategoriler.Size = new System.Drawing.Size(217, 27);
            this.cmbkategoriler.TabIndex = 1;
            this.cmbkategoriler.SelectedIndexChanged += new System.EventHandler(this.cmbkategoriler_SelectedIndexChanged);
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
            this.cmbMudurluk.Location = new System.Drawing.Point(248, 279);
            this.cmbMudurluk.Name = "cmbMudurluk";
            this.cmbMudurluk.Size = new System.Drawing.Size(217, 27);
            this.cmbMudurluk.TabIndex = 6;
            this.cmbMudurluk.SelectedIndexChanged += new System.EventHandler(this.cmbMudurluk_SelectedIndexChanged);
            // 
            // txturunadi
            // 
            this.txturunadi.BackColor = System.Drawing.Color.Azure;
            this.txturunadi.Font = new System.Drawing.Font("Geometria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txturunadi.ForeColor = System.Drawing.Color.Black;
            this.txturunadi.Location = new System.Drawing.Point(247, 132);
            this.txturunadi.Name = "txturunadi";
            this.txturunadi.Size = new System.Drawing.Size(216, 26);
            this.txturunadi.TabIndex = 2;
            // 
            // txtSeriNo
            // 
            this.txtSeriNo.BackColor = System.Drawing.Color.Azure;
            this.txtSeriNo.Font = new System.Drawing.Font("Geometria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSeriNo.ForeColor = System.Drawing.Color.Black;
            this.txtSeriNo.Location = new System.Drawing.Point(248, 183);
            this.txtSeriNo.Name = "txtSeriNo";
            this.txtSeriNo.Size = new System.Drawing.Size(216, 26);
            this.txtSeriNo.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Geometria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(248, 585);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 47);
            this.button1.TabIndex = 21;
            this.button1.Text = "KAYDET";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Geometria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(24, 585);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(217, 47);
            this.button2.TabIndex = 22;
            this.button2.Text = "TEMİZLE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dtbTarih
            // 
            this.dtbTarih.CalendarFont = new System.Drawing.Font("Geometria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtbTarih.CalendarForeColor = System.Drawing.Color.Azure;
            this.dtbTarih.CalendarMonthBackground = System.Drawing.Color.Azure;
            this.dtbTarih.Location = new System.Drawing.Point(248, 234);
            this.dtbTarih.Name = "dtbTarih";
            this.dtbTarih.Size = new System.Drawing.Size(216, 22);
            this.dtbTarih.TabIndex = 5;
            // 
            // cmbDuzenleyen
            // 
            this.cmbDuzenleyen.BackColor = System.Drawing.Color.Azure;
            this.cmbDuzenleyen.Font = new System.Drawing.Font("Geometria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDuzenleyen.ForeColor = System.Drawing.Color.Black;
            this.cmbDuzenleyen.FormattingEnabled = true;
            this.cmbDuzenleyen.Items.AddRange(new object[] {
            "Gökhan Demirel",
            "Şenol Uçun",
            "Uğur Yılmaz",
            "Volkan Keleş",
            "Volkan Par"});
            this.cmbDuzenleyen.Location = new System.Drawing.Point(248, 333);
            this.cmbDuzenleyen.Name = "cmbDuzenleyen";
            this.cmbDuzenleyen.Size = new System.Drawing.Size(217, 27);
            this.cmbDuzenleyen.TabIndex = 8;
            this.cmbDuzenleyen.SelectedIndexChanged += new System.EventHandler(this.cmbMudurluk_SelectedIndexChanged);
            // 
            // lblrdbtn
            // 
            this.lblrdbtn.AutoSize = true;
            this.lblrdbtn.Location = new System.Drawing.Point(22, 682);
            this.lblrdbtn.Name = "lblrdbtn";
            this.lblrdbtn.Size = new System.Drawing.Size(41, 17);
            this.lblrdbtn.TabIndex = 24;
            this.lblrdbtn.Text = "rdbtn";
            this.lblrdbtn.Visible = false;
            this.lblrdbtn.TextChanged += new System.EventHandler(this.lblrdbtn_TextChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(248, 389);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(57, 21);
            this.radioButton1.TabIndex = 25;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Evet";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(322, 390);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(62, 21);
            this.radioButton2.TabIndex = 25;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Hayır";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunNoDataGridViewTextBoxColumn,
            this.kategorilerDataGridViewTextBoxColumn,
            this.urunAdiDataGridViewTextBoxColumn,
            this.seriNoDataGridViewTextBoxColumn,
            this.tarihDataGridViewTextBoxColumn,
            this.mudurlukDataGridViewTextBoxColumn,
            this.Duzenleyen,
            this.Degisim,
            this.Notlar});
            this.dataGridView1.DataSource = this.tblStkEkleBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.GridColor = System.Drawing.Color.Honeydew;
            this.dataGridView1.Location = new System.Drawing.Point(516, 274);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(779, 397);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // urunNoDataGridViewTextBoxColumn
            // 
            this.urunNoDataGridViewTextBoxColumn.DataPropertyName = "UrunNo";
            this.urunNoDataGridViewTextBoxColumn.HeaderText = "UrunNo";
            this.urunNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunNoDataGridViewTextBoxColumn.Name = "urunNoDataGridViewTextBoxColumn";
            this.urunNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // kategorilerDataGridViewTextBoxColumn
            // 
            this.kategorilerDataGridViewTextBoxColumn.DataPropertyName = "Kategoriler";
            this.kategorilerDataGridViewTextBoxColumn.HeaderText = "Kategoriler";
            this.kategorilerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kategorilerDataGridViewTextBoxColumn.Name = "kategorilerDataGridViewTextBoxColumn";
            this.kategorilerDataGridViewTextBoxColumn.Width = 125;
            // 
            // urunAdiDataGridViewTextBoxColumn
            // 
            this.urunAdiDataGridViewTextBoxColumn.DataPropertyName = "UrunAdi";
            this.urunAdiDataGridViewTextBoxColumn.HeaderText = "UrunAdi";
            this.urunAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunAdiDataGridViewTextBoxColumn.Name = "urunAdiDataGridViewTextBoxColumn";
            this.urunAdiDataGridViewTextBoxColumn.Width = 125;
            // 
            // seriNoDataGridViewTextBoxColumn
            // 
            this.seriNoDataGridViewTextBoxColumn.DataPropertyName = "SeriNo";
            this.seriNoDataGridViewTextBoxColumn.HeaderText = "SeriNo";
            this.seriNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.seriNoDataGridViewTextBoxColumn.Name = "seriNoDataGridViewTextBoxColumn";
            this.seriNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "Tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "Tarih";
            this.tarihDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            this.tarihDataGridViewTextBoxColumn.Width = 125;
            // 
            // mudurlukDataGridViewTextBoxColumn
            // 
            this.mudurlukDataGridViewTextBoxColumn.DataPropertyName = "Mudurluk";
            this.mudurlukDataGridViewTextBoxColumn.HeaderText = "Mudurluk";
            this.mudurlukDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mudurlukDataGridViewTextBoxColumn.Name = "mudurlukDataGridViewTextBoxColumn";
            this.mudurlukDataGridViewTextBoxColumn.Width = 125;
            // 
            // Duzenleyen
            // 
            this.Duzenleyen.DataPropertyName = "Duzenleyen";
            this.Duzenleyen.HeaderText = "Duzenleyen";
            this.Duzenleyen.MinimumWidth = 6;
            this.Duzenleyen.Name = "Duzenleyen";
            this.Duzenleyen.Width = 125;
            // 
            // Degisim
            // 
            this.Degisim.DataPropertyName = "Degisim";
            this.Degisim.HeaderText = "Degisim";
            this.Degisim.MinimumWidth = 6;
            this.Degisim.Name = "Degisim";
            this.Degisim.Width = 125;
            // 
            // Notlar
            // 
            this.Notlar.DataPropertyName = "Notlar";
            this.Notlar.HeaderText = "Notlar";
            this.Notlar.MinimumWidth = 6;
            this.Notlar.Name = "Notlar";
            this.Notlar.Width = 125;
            // 
            // tblStkEkleBindingSource
            // 
            this.tblStkEkleBindingSource.DataMember = "TblStkEkle";
            this.tblStkEkleBindingSource.DataSource = this.stokEklePrgDataSet5;
            // 
            // stokEklePrgDataSet5
            // 
            this.stokEklePrgDataSet5.DataSetName = "StokEklePrgDataSet5";
            this.stokEklePrgDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.Maroon;
            this.btnsil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsil.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsil.Location = new System.Drawing.Point(516, 141);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(174, 64);
            this.btnsil.TabIndex = 26;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.button5_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Geometria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(130, 436);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 30);
            this.label12.TabIndex = 17;
            this.label12.Text = "Notlar:";
            // 
            // rchtxtnotlar
            // 
            this.rchtxtnotlar.BackColor = System.Drawing.Color.Azure;
            this.rchtxtnotlar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rchtxtnotlar.Font = new System.Drawing.Font("Geometria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rchtxtnotlar.Location = new System.Drawing.Point(248, 443);
            this.rchtxtnotlar.Name = "rchtxtnotlar";
            this.rchtxtnotlar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rchtxtnotlar.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rchtxtnotlar.Size = new System.Drawing.Size(216, 96);
            this.rchtxtnotlar.TabIndex = 9;
            this.rchtxtnotlar.Text = "";
            // 
            // tblStkEkleTableAdapter
            // 
            this.tblStkEkleTableAdapter.ClearBeforeFill = true;
            // 
            // btnguncelle
            // 
            this.btnguncelle.BackColor = System.Drawing.Color.ForestGreen;
            this.btnguncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguncelle.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnguncelle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnguncelle.Location = new System.Drawing.Point(697, 138);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(173, 67);
            this.btnguncelle.TabIndex = 79;
            this.btnguncelle.Text = "GÜNCELLE";
            this.btnguncelle.UseVisualStyleBackColor = false;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnenvanter
            // 
            this.btnenvanter.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnenvanter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnenvanter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnenvanter.Font = new System.Drawing.Font("Geometria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnenvanter.ForeColor = System.Drawing.SystemColors.Control;
            this.btnenvanter.Location = new System.Drawing.Point(876, 83);
            this.btnenvanter.Name = "btnenvanter";
            this.btnenvanter.Size = new System.Drawing.Size(184, 42);
            this.btnenvanter.TabIndex = 80;
            this.btnenvanter.Text = "ENVANTER";
            this.btnenvanter.UseVisualStyleBackColor = false;
            this.btnenvanter.Click += new System.EventHandler(this.btnenvanter_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 70;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 70;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // txtKtgr
            // 
            this.txtKtgr.BackColor = System.Drawing.Color.Azure;
            this.txtKtgr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKtgr.Font = new System.Drawing.Font("Geometria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKtgr.Location = new System.Drawing.Point(673, 211);
            this.txtKtgr.Name = "txtKtgr";
            this.txtKtgr.Size = new System.Drawing.Size(169, 33);
            this.txtKtgr.TabIndex = 81;
            this.txtKtgr.Visible = false;
            // 
            // lblekle
            // 
            this.lblekle.AutoSize = true;
            this.lblekle.Font = new System.Drawing.Font("Geometria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblekle.Location = new System.Drawing.Point(517, 215);
            this.lblekle.Name = "lblekle";
            this.lblekle.Size = new System.Drawing.Size(150, 25);
            this.lblekle.TabIndex = 82;
            this.lblekle.Text = "Kategori Ekle:";
            this.lblekle.Visible = false;
            // 
            // btnktgri
            // 
            this.btnktgri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnktgri.Font = new System.Drawing.Font("Geometria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnktgri.ForeColor = System.Drawing.Color.Coral;
            this.btnktgri.Location = new System.Drawing.Point(860, 205);
            this.btnktgri.Name = "btnktgri";
            this.btnktgri.Size = new System.Drawing.Size(174, 42);
            this.btnktgri.TabIndex = 83;
            this.btnktgri.Text = "KATEGORİ EKLE";
            this.btnktgri.UseVisualStyleBackColor = true;
            this.btnktgri.Visible = false;
            this.btnktgri.Click += new System.EventHandler(this.btnktgri_Click);
            // 
            // btnMudurluk
            // 
            this.btnMudurluk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMudurluk.Font = new System.Drawing.Font("Geometria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMudurluk.ForeColor = System.Drawing.Color.Coral;
            this.btnMudurluk.Location = new System.Drawing.Point(860, 205);
            this.btnMudurluk.Name = "btnMudurluk";
            this.btnMudurluk.Size = new System.Drawing.Size(174, 42);
            this.btnMudurluk.TabIndex = 85;
            this.btnMudurluk.Text = "MÜDÜRLÜK EKLE";
            this.btnMudurluk.UseVisualStyleBackColor = true;
            this.btnMudurluk.Visible = false;
            this.btnMudurluk.Click += new System.EventHandler(this.btnMudurluk_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Geometria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(697, 83);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(173, 42);
            this.button4.TabIndex = 84;
            this.button4.Text = "MÜDÜRLÜK EKLE";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Geometria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(516, 83);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(174, 42);
            this.button3.TabIndex = 83;
            this.button3.Text = "KATEGORİ EKLE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtUrunNo
            // 
            this.txtUrunNo.BackColor = System.Drawing.Color.Azure;
            this.txtUrunNo.Font = new System.Drawing.Font("Geometria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunNo.ForeColor = System.Drawing.Color.Black;
            this.txtUrunNo.Location = new System.Drawing.Point(247, 55);
            this.txtUrunNo.Name = "txtUrunNo";
            this.txtUrunNo.Size = new System.Drawing.Size(216, 26);
            this.txtUrunNo.TabIndex = 78;
            this.txtUrunNo.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Geometria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(71, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 30);
            this.label2.TabIndex = 17;
            this.label2.Text = "Ürün No:";
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // UrunEkleFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1344, 756);
            this.Controls.Add(this.btnMudurluk);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnktgri);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lblekle);
            this.Controls.Add(this.txtKtgr);
            this.Controls.Add(this.btnenvanter);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.rchtxtnotlar);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.lblrdbtn);
            this.Controls.Add(this.dtbTarih);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSeriNo);
            this.Controls.Add(this.txtUrunNo);
            this.Controls.Add(this.txturunadi);
            this.Controls.Add(this.cmbDuzenleyen);
            this.Controls.Add(this.cmbMudurluk);
            this.Controls.Add(this.cmbkategoriler);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnsil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UrunEkleFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStkEkleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokEklePrgDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbkategoriler;
        private System.Windows.Forms.ComboBox cmbMudurluk;
        private System.Windows.Forms.TextBox txturunadi;
        private System.Windows.Forms.TextBox txtSeriNo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dtbTarih;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbDuzenleyen;
        private System.Windows.Forms.Label lblrdbtn;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox rchtxtnotlar;
        private StokEklePrgDataSet5 stokEklePrgDataSet5;
        private System.Windows.Forms.BindingSource tblStkEkleBindingSource;
        private StokEklePrgDataSet5TableAdapters.TblStkEkleTableAdapter tblStkEkleTableAdapter;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnenvanter;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox txtKtgr;
        private System.Windows.Forms.Label lblekle;
        private System.Windows.Forms.Button btnktgri;
        private System.Windows.Forms.Button btnMudurluk;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtUrunNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategorilerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seriNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mudurlukDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duzenleyen;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Degisim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notlar;
    }
}