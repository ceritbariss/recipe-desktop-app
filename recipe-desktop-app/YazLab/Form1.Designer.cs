namespace YazLab
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TxtArama = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CmbSirala = new System.Windows.Forms.ComboBox();
            this.BtnSirala = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtTarifAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSure = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtHazirlanis = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CmbMalzemeler = new System.Windows.Forms.ComboBox();
            this.BtnTarifiGüncelle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtBirim = new System.Windows.Forms.TextBox();
            this.TxtMiktar = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CmbKategori = new System.Windows.Forms.ComboBox();
            this.BtnMalzemeGüncelle = new System.Windows.Forms.Button();
            this.BtnMalzemeEkle = new System.Windows.Forms.Button();
            this.CmbTumMalzemeler = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.TxtArama);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-5, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1443, 115);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1126, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // TxtArama
            // 
            this.TxtArama.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtArama.Location = new System.Drawing.Point(1184, 40);
            this.TxtArama.Name = "TxtArama";
            this.TxtArama.Size = new System.Drawing.Size(203, 38);
            this.TxtArama.TabIndex = 4;
            this.TxtArama.TextChanged += new System.EventHandler(this.TxtArama_TextChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(817, 31);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 60);
            this.button3.TabIndex = 3;
            this.button3.Text = "Tarif Bul";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(627, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 60);
            this.button2.TabIndex = 2;
            this.button2.Text = "Tarif Sil";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(434, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tarif Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "TARİFİM";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridView1.Location = new System.Drawing.Point(12, 138);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(472, 560);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(-5, 729);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1443, 22);
            this.panel2.TabIndex = 2;
            // 
            // CmbSirala
            // 
            this.CmbSirala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSirala.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbSirala.FormattingEnabled = true;
            this.CmbSirala.Location = new System.Drawing.Point(522, 138);
            this.CmbSirala.Name = "CmbSirala";
            this.CmbSirala.Size = new System.Drawing.Size(183, 31);
            this.CmbSirala.TabIndex = 3;
            this.CmbSirala.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // BtnSirala
            // 
            this.BtnSirala.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnSirala.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSirala.ForeColor = System.Drawing.Color.White;
            this.BtnSirala.Location = new System.Drawing.Point(722, 138);
            this.BtnSirala.Name = "BtnSirala";
            this.BtnSirala.Size = new System.Drawing.Size(139, 39);
            this.BtnSirala.TabIndex = 4;
            this.BtnSirala.Text = "Sırala";
            this.BtnSirala.UseVisualStyleBackColor = false;
            this.BtnSirala.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(638, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tarifin Adı:";
            // 
            // TxtTarifAdi
            // 
            this.TxtTarifAdi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtTarifAdi.Location = new System.Drawing.Point(780, 232);
            this.TxtTarifAdi.Multiline = true;
            this.TxtTarifAdi.Name = "TxtTarifAdi";
            this.TxtTarifAdi.Size = new System.Drawing.Size(185, 31);
            this.TxtTarifAdi.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(654, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kategori:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(502, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 31);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hazırlanma Süresi (Dk):";
            // 
            // TxtSure
            // 
            this.TxtSure.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSure.Location = new System.Drawing.Point(780, 324);
            this.TxtSure.Multiline = true;
            this.TxtSure.Name = "TxtSure";
            this.TxtSure.Size = new System.Drawing.Size(185, 35);
            this.TxtSure.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(641, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 31);
            this.label5.TabIndex = 11;
            this.label5.Text = "Hazırlanış:";
            // 
            // TxtHazirlanis
            // 
            this.TxtHazirlanis.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtHazirlanis.Location = new System.Drawing.Point(780, 376);
            this.TxtHazirlanis.Multiline = true;
            this.TxtHazirlanis.Name = "TxtHazirlanis";
            this.TxtHazirlanis.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtHazirlanis.Size = new System.Drawing.Size(307, 321);
            this.TxtHazirlanis.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(1059, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 31);
            this.label6.TabIndex = 14;
            this.label6.Text = "Malzemeler:";
            // 
            // CmbMalzemeler
            // 
            this.CmbMalzemeler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbMalzemeler.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbMalzemeler.FormattingEnabled = true;
            this.CmbMalzemeler.IntegralHeight = false;
            this.CmbMalzemeler.Location = new System.Drawing.Point(1221, 280);
            this.CmbMalzemeler.MaxDropDownItems = 10;
            this.CmbMalzemeler.Name = "CmbMalzemeler";
            this.CmbMalzemeler.Size = new System.Drawing.Size(185, 31);
            this.CmbMalzemeler.TabIndex = 15;
            this.CmbMalzemeler.SelectedIndexChanged += new System.EventHandler(this.CmbMalzemeler_SelectedIndexChanged);
            // 
            // BtnTarifiGüncelle
            // 
            this.BtnTarifiGüncelle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnTarifiGüncelle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTarifiGüncelle.ForeColor = System.Drawing.Color.White;
            this.BtnTarifiGüncelle.Location = new System.Drawing.Point(1144, 605);
            this.BtnTarifiGüncelle.Name = "BtnTarifiGüncelle";
            this.BtnTarifiGüncelle.Size = new System.Drawing.Size(224, 65);
            this.BtnTarifiGüncelle.TabIndex = 16;
            this.BtnTarifiGüncelle.Text = "Tarifi Güncelle";
            this.BtnTarifiGüncelle.UseVisualStyleBackColor = false;
            this.BtnTarifiGüncelle.Click += new System.EventHandler(this.BtnTarifiGüncelle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(1128, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 31);
            this.label7.TabIndex = 17;
            this.label7.Text = "Birimi:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(1115, 372);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 31);
            this.label8.TabIndex = 18;
            this.label8.Text = "Miktarı:";
            // 
            // TxtBirim
            // 
            this.TxtBirim.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtBirim.Location = new System.Drawing.Point(1221, 321);
            this.TxtBirim.Multiline = true;
            this.TxtBirim.Name = "TxtBirim";
            this.TxtBirim.ReadOnly = true;
            this.TxtBirim.Size = new System.Drawing.Size(86, 38);
            this.TxtBirim.TabIndex = 19;
            // 
            // TxtMiktar
            // 
            this.TxtMiktar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtMiktar.Location = new System.Drawing.Point(1221, 369);
            this.TxtMiktar.Multiline = true;
            this.TxtMiktar.Name = "TxtMiktar";
            this.TxtMiktar.Size = new System.Drawing.Size(86, 38);
            this.TxtMiktar.TabIndex = 20;
            this.TxtMiktar.TextChanged += new System.EventHandler(this.TxtMiktar_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1440, 626);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // CmbKategori
            // 
            this.CmbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbKategori.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbKategori.FormattingEnabled = true;
            this.CmbKategori.Location = new System.Drawing.Point(780, 279);
            this.CmbKategori.Name = "CmbKategori";
            this.CmbKategori.Size = new System.Drawing.Size(185, 31);
            this.CmbKategori.TabIndex = 23;
            // 
            // BtnMalzemeGüncelle
            // 
            this.BtnMalzemeGüncelle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnMalzemeGüncelle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnMalzemeGüncelle.ForeColor = System.Drawing.Color.White;
            this.BtnMalzemeGüncelle.Location = new System.Drawing.Point(1188, 419);
            this.BtnMalzemeGüncelle.Name = "BtnMalzemeGüncelle";
            this.BtnMalzemeGüncelle.Size = new System.Drawing.Size(218, 39);
            this.BtnMalzemeGüncelle.TabIndex = 24;
            this.BtnMalzemeGüncelle.Text = "Malzemeyi Güncelle";
            this.BtnMalzemeGüncelle.UseVisualStyleBackColor = false;
            this.BtnMalzemeGüncelle.Click += new System.EventHandler(this.BtnMalzemeGüncelle_Click);
            // 
            // BtnMalzemeEkle
            // 
            this.BtnMalzemeEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnMalzemeEkle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnMalzemeEkle.ForeColor = System.Drawing.Color.White;
            this.BtnMalzemeEkle.Location = new System.Drawing.Point(1188, 464);
            this.BtnMalzemeEkle.Name = "BtnMalzemeEkle";
            this.BtnMalzemeEkle.Size = new System.Drawing.Size(218, 39);
            this.BtnMalzemeEkle.TabIndex = 25;
            this.BtnMalzemeEkle.Text = "Malzeme Ekle";
            this.BtnMalzemeEkle.UseVisualStyleBackColor = false;
            this.BtnMalzemeEkle.Click += new System.EventHandler(this.button7_Click);
            // 
            // CmbTumMalzemeler
            // 
            this.CmbTumMalzemeler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTumMalzemeler.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbTumMalzemeler.FormattingEnabled = true;
            this.CmbTumMalzemeler.IntegralHeight = false;
            this.CmbTumMalzemeler.Location = new System.Drawing.Point(1221, 233);
            this.CmbTumMalzemeler.MaxDropDownItems = 10;
            this.CmbTumMalzemeler.Name = "CmbTumMalzemeler";
            this.CmbTumMalzemeler.Size = new System.Drawing.Size(185, 31);
            this.CmbTumMalzemeler.TabIndex = 27;
            this.CmbTumMalzemeler.SelectedIndexChanged += new System.EventHandler(this.CmbTumMalzemeler_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(1008, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(189, 31);
            this.label9.TabIndex = 26;
            this.label9.Text = "Tüm Malzemeler:";
            // 
            // BtnEkle
            // 
            this.BtnEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnEkle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnEkle.ForeColor = System.Drawing.Color.White;
            this.BtnEkle.Location = new System.Drawing.Point(1339, 317);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(67, 46);
            this.BtnEkle.TabIndex = 28;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = false;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnSil.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.ForeColor = System.Drawing.Color.White;
            this.BtnSil.Location = new System.Drawing.Point(1339, 367);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(67, 46);
            this.BtnSil.TabIndex = 29;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = false;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 750);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.CmbTumMalzemeler);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BtnMalzemeEkle);
            this.Controls.Add(this.BtnMalzemeGüncelle);
            this.Controls.Add(this.CmbKategori);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtMiktar);
            this.Controls.Add(this.TxtBirim);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnTarifiGüncelle);
            this.Controls.Add(this.CmbMalzemeler);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtHazirlanis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtSure);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtTarifAdi);
            this.Controls.Add(this.BtnSirala);
            this.Controls.Add(this.CmbSirala);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "TARİFİM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtArama;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox CmbSirala;
        private System.Windows.Forms.Button BtnSirala;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtTarifAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtSure;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtHazirlanis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CmbMalzemeler;
        private System.Windows.Forms.Button BtnTarifiGüncelle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtBirim;
        private System.Windows.Forms.TextBox TxtMiktar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox CmbKategori;
        private System.Windows.Forms.Button BtnMalzemeGüncelle;
        private System.Windows.Forms.Button BtnMalzemeEkle;
        private System.Windows.Forms.ComboBox CmbTumMalzemeler;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtnSil;
    }
}

