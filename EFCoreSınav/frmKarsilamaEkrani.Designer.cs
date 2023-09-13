namespace EFCoreSınav
{
    partial class frmKarsilamaEkrani
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
            btnKullaniciGirisi = new Button();
            btnYeniKayitOlustur = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            SuspendLayout();
            // 
            // btnKullaniciGirisi
            // 
            btnKullaniciGirisi.Location = new Point(110, 76);
            btnKullaniciGirisi.Name = "btnKullaniciGirisi";
            btnKullaniciGirisi.Size = new Size(75, 47);
            btnKullaniciGirisi.TabIndex = 0;
            btnKullaniciGirisi.Text = "Kullanıcı Girişi";
            btnKullaniciGirisi.UseVisualStyleBackColor = true;
            btnKullaniciGirisi.Click += btnKullaniciGirisi_Click;
            // 
            // btnYeniKayitOlustur
            // 
            btnYeniKayitOlustur.Location = new Point(191, 76);
            btnYeniKayitOlustur.Name = "btnYeniKayitOlustur";
            btnYeniKayitOlustur.Size = new Size(75, 47);
            btnYeniKayitOlustur.TabIndex = 0;
            btnYeniKayitOlustur.Text = "Yeni Kayıt Oluştur";
            btnYeniKayitOlustur.UseVisualStyleBackColor = true;
            btnYeniKayitOlustur.Click += btnYeniKayitOlustur_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // frmKarsilamaEkrani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 211);
            Controls.Add(btnYeniKayitOlustur);
            Controls.Add(btnKullaniciGirisi);
            Name = "frmKarsilamaEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmKarsilamaEkrani";
            ResumeLayout(false);
        }

        #endregion

        private Button btnKullaniciGirisi;
        private Button btnYeniKayitOlustur;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}