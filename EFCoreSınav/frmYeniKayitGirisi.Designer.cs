namespace EFCoreSınav
{
    partial class frmYeniKayitGirisi
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
            lblSifre = new Label();
            lblKullaniciAdi = new Label();
            txtSifreOlustur = new TextBox();
            txtSifreyiTekrarGirin = new TextBox();
            lblSifreyiTekrarGirin = new Label();
            btnKayitOlustur = new Button();
            txtAd = new TextBox();
            SuspendLayout();
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Location = new Point(90, 66);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(75, 15);
            lblSifre.TabIndex = 5;
            lblSifre.Text = "Şifre Oluştur:";
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.Location = new Point(90, 14);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new Size(76, 15);
            lblKullaniciAdi.TabIndex = 6;
            lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // txtSifreOlustur
            // 
            txtSifreOlustur.BorderStyle = BorderStyle.FixedSingle;
            txtSifreOlustur.Location = new Point(90, 83);
            txtSifreOlustur.Name = "txtSifreOlustur";
            txtSifreOlustur.Size = new Size(195, 23);
            txtSifreOlustur.TabIndex = 3;
            txtSifreOlustur.TextChanged += txtSifreOlustur_TextChanged;
            // 
            // txtSifreyiTekrarGirin
            // 
            txtSifreyiTekrarGirin.BorderStyle = BorderStyle.FixedSingle;
            txtSifreyiTekrarGirin.Location = new Point(90, 133);
            txtSifreyiTekrarGirin.Name = "txtSifreyiTekrarGirin";
            txtSifreyiTekrarGirin.Size = new Size(195, 23);
            txtSifreyiTekrarGirin.TabIndex = 3;
            txtSifreyiTekrarGirin.TextChanged += txtSifreyiTekrarGirin_TextChanged;
            // 
            // lblSifreyiTekrarGirin
            // 
            lblSifreyiTekrarGirin.AutoSize = true;
            lblSifreyiTekrarGirin.Location = new Point(90, 116);
            lblSifreyiTekrarGirin.Name = "lblSifreyiTekrarGirin";
            lblSifreyiTekrarGirin.Size = new Size(104, 15);
            lblSifreyiTekrarGirin.TabIndex = 5;
            lblSifreyiTekrarGirin.Text = "Şifreyi Tekrar Girin:";
            // 
            // btnKayitOlustur
            // 
            btnKayitOlustur.Enabled = false;
            btnKayitOlustur.Location = new Point(202, 162);
            btnKayitOlustur.Name = "btnKayitOlustur";
            btnKayitOlustur.Size = new Size(83, 23);
            btnKayitOlustur.TabIndex = 7;
            btnKayitOlustur.Text = "Kayıt Oluştur";
            btnKayitOlustur.UseVisualStyleBackColor = true;
            btnKayitOlustur.Click += btnKayitOlustur_Click;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(90, 32);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(195, 23);
            txtAd.TabIndex = 8;
            // 
            // frmYeniKayitGirisi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 211);
            Controls.Add(txtAd);
            Controls.Add(btnKayitOlustur);
            Controls.Add(lblSifreyiTekrarGirin);
            Controls.Add(lblSifre);
            Controls.Add(lblKullaniciAdi);
            Controls.Add(txtSifreyiTekrarGirin);
            Controls.Add(txtSifreOlustur);
            Name = "frmYeniKayitGirisi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmYeniKayitGirisi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblSifre;
        private Label lblKullaniciAdi;
        private TextBox txtSifreOlustur;
        private TextBox txtSifreyiTekrarGirin;
        private Label lblSifreyiTekrarGirin;
        private Button btnKayitOlustur;
        private TextBox txtAd;
    }
}