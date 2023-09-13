namespace EFCoreSınav
{
    partial class frmPlakDukkaniYoneticiEkrani
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
            btnEkle = new Button();
            dgvTablolar = new DataGridView();
            btnSil = new Button();
            btnGuncelle = new Button();
            lblAlbumAdi = new Label();
            txtAlbumAdi = new TextBox();
            cbxSatisDevamDurumu = new CheckBox();
            lblAlbumSanatcisi = new Label();
            lblAlbumCikisTarihi = new Label();
            lblAlbumFiyati = new Label();
            lblIndirimOrani = new Label();
            lblSatisDevamDurumu = new Label();
            txtAlbumSanatcisi = new TextBox();
            dtpAlbumCikisTarihi = new DateTimePicker();
            nudIndirimOrani = new NumericUpDown();
            nudAlbumFiyati = new NumericUpDown();
            btnSatisYok = new Button();
            btnSatisDevam = new Button();
            btnSon10Album = new Button();
            btnIndirim = new Button();
            btnAlbumler = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTablolar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudIndirimOrani).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAlbumFiyati).BeginInit();
            SuspendLayout();
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.FromArgb(255, 128, 0);
            btnEkle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnEkle.Location = new Point(98, 511);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(76, 29);
            btnEkle.TabIndex = 0;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // dgvTablolar
            // 
            dgvTablolar.BackgroundColor = Color.White;
            dgvTablolar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTablolar.Location = new Point(12, 12);
            dgvTablolar.Name = "dgvTablolar";
            dgvTablolar.RowTemplate.Height = 25;
            dgvTablolar.Size = new Size(760, 293);
            dgvTablolar.TabIndex = 1;
            dgvTablolar.CellClick += dgvTablolar_CellClick;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.FromArgb(255, 128, 0);
            btnSil.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSil.Location = new Point(262, 511);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(76, 29);
            btnSil.TabIndex = 0;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.FromArgb(255, 128, 0);
            btnGuncelle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuncelle.Location = new Point(180, 511);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(76, 29);
            btnGuncelle.TabIndex = 0;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // lblAlbumAdi
            // 
            lblAlbumAdi.AutoSize = true;
            lblAlbumAdi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAlbumAdi.Location = new Point(65, 325);
            lblAlbumAdi.Name = "lblAlbumAdi";
            lblAlbumAdi.Size = new Size(67, 15);
            lblAlbumAdi.TabIndex = 2;
            lblAlbumAdi.Text = "Albüm Adı:";
            // 
            // txtAlbumAdi
            // 
            txtAlbumAdi.BorderStyle = BorderStyle.FixedSingle;
            txtAlbumAdi.Location = new Point(138, 317);
            txtAlbumAdi.Name = "txtAlbumAdi";
            txtAlbumAdi.Size = new Size(200, 23);
            txtAlbumAdi.TabIndex = 3;
            // 
            // cbxSatisDevamDurumu
            // 
            cbxSatisDevamDurumu.AutoSize = true;
            cbxSatisDevamDurumu.Location = new Point(138, 474);
            cbxSatisDevamDurumu.Name = "cbxSatisDevamDurumu";
            cbxSatisDevamDurumu.Size = new Size(99, 19);
            cbxSatisDevamDurumu.TabIndex = 4;
            cbxSatisDevamDurumu.Text = "Devam Ediyor";
            cbxSatisDevamDurumu.UseVisualStyleBackColor = true;
            // 
            // lblAlbumSanatcisi
            // 
            lblAlbumSanatcisi.AutoSize = true;
            lblAlbumSanatcisi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAlbumSanatcisi.Location = new Point(-1, 355);
            lblAlbumSanatcisi.Name = "lblAlbumSanatcisi";
            lblAlbumSanatcisi.Size = new Size(137, 15);
            lblAlbumSanatcisi.TabIndex = 2;
            lblAlbumSanatcisi.Text = "Albüm Sanatçısı/Grubu:";
            // 
            // lblAlbumCikisTarihi
            // 
            lblAlbumCikisTarihi.AutoSize = true;
            lblAlbumCikisTarihi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAlbumCikisTarihi.Location = new Point(27, 385);
            lblAlbumCikisTarihi.Name = "lblAlbumCikisTarihi";
            lblAlbumCikisTarihi.Size = new Size(107, 15);
            lblAlbumCikisTarihi.TabIndex = 2;
            lblAlbumCikisTarihi.Text = "Albüm Çıkış Tarihi:";
            // 
            // lblAlbumFiyati
            // 
            lblAlbumFiyati.AutoSize = true;
            lblAlbumFiyati.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAlbumFiyati.Location = new Point(55, 415);
            lblAlbumFiyati.Name = "lblAlbumFiyati";
            lblAlbumFiyati.Size = new Size(78, 15);
            lblAlbumFiyati.TabIndex = 2;
            lblAlbumFiyati.Text = "Albüm Fiyatı:";
            // 
            // lblIndirimOrani
            // 
            lblIndirimOrani.AutoSize = true;
            lblIndirimOrani.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblIndirimOrani.Location = new Point(52, 445);
            lblIndirimOrani.Name = "lblIndirimOrani";
            lblIndirimOrani.Size = new Size(83, 15);
            lblIndirimOrani.TabIndex = 2;
            lblIndirimOrani.Text = "İndirim Oranı:";
            // 
            // lblSatisDevamDurumu
            // 
            lblSatisDevamDurumu.AutoSize = true;
            lblSatisDevamDurumu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSatisDevamDurumu.Location = new Point(4, 475);
            lblSatisDevamDurumu.Name = "lblSatisDevamDurumu";
            lblSatisDevamDurumu.Size = new Size(128, 15);
            lblSatisDevamDurumu.TabIndex = 2;
            lblSatisDevamDurumu.Text = "Satış Devam Durumu:";
            // 
            // txtAlbumSanatcisi
            // 
            txtAlbumSanatcisi.BorderStyle = BorderStyle.FixedSingle;
            txtAlbumSanatcisi.Location = new Point(138, 347);
            txtAlbumSanatcisi.Name = "txtAlbumSanatcisi";
            txtAlbumSanatcisi.Size = new Size(200, 23);
            txtAlbumSanatcisi.TabIndex = 3;
            // 
            // dtpAlbumCikisTarihi
            // 
            dtpAlbumCikisTarihi.Location = new Point(138, 379);
            dtpAlbumCikisTarihi.Name = "dtpAlbumCikisTarihi";
            dtpAlbumCikisTarihi.Size = new Size(200, 23);
            dtpAlbumCikisTarihi.TabIndex = 5;
            // 
            // nudIndirimOrani
            // 
            nudIndirimOrani.Location = new Point(138, 437);
            nudIndirimOrani.Name = "nudIndirimOrani";
            nudIndirimOrani.Size = new Size(88, 23);
            nudIndirimOrani.TabIndex = 6;
            // 
            // nudAlbumFiyati
            // 
            nudAlbumFiyati.Location = new Point(138, 407);
            nudAlbumFiyati.Name = "nudAlbumFiyati";
            nudAlbumFiyati.Size = new Size(88, 23);
            nudAlbumFiyati.TabIndex = 6;
            // 
            // btnSatisYok
            // 
            btnSatisYok.BackColor = Color.Black;
            btnSatisYok.ForeColor = SystemColors.ScrollBar;
            btnSatisYok.Location = new Point(570, 379);
            btnSatisYok.Name = "btnSatisYok";
            btnSatisYok.Size = new Size(202, 23);
            btnSatisYok.TabIndex = 7;
            btnSatisYok.Text = "Satışı Durmuş Albümler";
            btnSatisYok.UseVisualStyleBackColor = false;
            btnSatisYok.Click += btnSatisYok_Click;
            // 
            // btnSatisDevam
            // 
            btnSatisDevam.BackColor = Color.Black;
            btnSatisDevam.ForeColor = SystemColors.ScrollBar;
            btnSatisDevam.Location = new Point(570, 408);
            btnSatisDevam.Name = "btnSatisDevam";
            btnSatisDevam.Size = new Size(202, 23);
            btnSatisDevam.TabIndex = 7;
            btnSatisDevam.Text = "Satışı Devam Eden Albümler";
            btnSatisDevam.UseVisualStyleBackColor = false;
            btnSatisDevam.Click += btnSatisDevam_Click;
            // 
            // btnSon10Album
            // 
            btnSon10Album.BackColor = Color.Black;
            btnSon10Album.ForeColor = SystemColors.ScrollBar;
            btnSon10Album.Location = new Point(570, 467);
            btnSon10Album.Name = "btnSon10Album";
            btnSon10Album.Size = new Size(202, 23);
            btnSon10Album.TabIndex = 7;
            btnSon10Album.Text = "Sisteme Son Eklenen 10 Albüm";
            btnSon10Album.UseVisualStyleBackColor = false;
            btnSon10Album.Click += btnSon10Album_Click;
            // 
            // btnIndirim
            // 
            btnIndirim.BackColor = Color.Black;
            btnIndirim.ForeColor = SystemColors.ScrollBar;
            btnIndirim.Location = new Point(570, 437);
            btnIndirim.Name = "btnIndirim";
            btnIndirim.Size = new Size(202, 23);
            btnIndirim.TabIndex = 7;
            btnIndirim.Text = "İndirimdekiler";
            btnIndirim.UseVisualStyleBackColor = false;
            btnIndirim.Click += btnIndirim_Click;
            // 
            // btnAlbumler
            // 
            btnAlbumler.BackColor = Color.FromArgb(255, 128, 255);
            btnAlbumler.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAlbumler.ForeColor = SystemColors.MenuText;
            btnAlbumler.Location = new Point(570, 315);
            btnAlbumler.Name = "btnAlbumler";
            btnAlbumler.Size = new Size(202, 23);
            btnAlbumler.TabIndex = 7;
            btnAlbumler.Text = "Albümler Tablosunu Getir";
            btnAlbumler.UseVisualStyleBackColor = false;
            btnAlbumler.Click += btnAlbumler_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(570, 355);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 2;
            label1.Text = "Diğer Listeler:";
            // 
            // frmPlakDukkaniYoneticiEkrani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 560);
            Controls.Add(btnIndirim);
            Controls.Add(btnSon10Album);
            Controls.Add(btnSatisDevam);
            Controls.Add(btnAlbumler);
            Controls.Add(btnSatisYok);
            Controls.Add(nudAlbumFiyati);
            Controls.Add(nudIndirimOrani);
            Controls.Add(dtpAlbumCikisTarihi);
            Controls.Add(cbxSatisDevamDurumu);
            Controls.Add(txtAlbumSanatcisi);
            Controls.Add(txtAlbumAdi);
            Controls.Add(lblSatisDevamDurumu);
            Controls.Add(lblIndirimOrani);
            Controls.Add(label1);
            Controls.Add(lblAlbumFiyati);
            Controls.Add(lblAlbumCikisTarihi);
            Controls.Add(lblAlbumSanatcisi);
            Controls.Add(lblAlbumAdi);
            Controls.Add(dgvTablolar);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Name = "frmPlakDukkaniYoneticiEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPlakDukkaniYoneticiEkrani";
            Load += frmPlakDukkaniYoneticiEkrani_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTablolar).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudIndirimOrani).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAlbumFiyati).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEkle;
        private DataGridView dgvTablolar;
        private Button btnSil;
        private Button btnGuncelle;
        private Label lblAlbumAdi;
        private TextBox txtAlbumAdi;
        private CheckBox cbxSatisDevamDurumu;
        private Label lblAlbumSanatcisi;
        private Label lblAlbumCikisTarihi;
        private Label lblAlbumFiyati;
        private Label lblIndirimOrani;
        private Label lblSatisDevamDurumu;
        private TextBox txtAlbumSanatcisi;
        private DateTimePicker dtpAlbumCikisTarihi;
        private NumericUpDown nudIndirimOrani;
        private NumericUpDown nudAlbumFiyati;
        private Button btnSatisYok;
        private Button btnSatisDevam;
        private Button btnSon10Album;
        private Button btnIndirim;
        private Button btnAlbumler;
        private Label label1;
    }
}