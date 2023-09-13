namespace EFCoreSınav
{
    partial class frmKullaniciGirisi
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
            txtKullaniciAdi = new TextBox();
            txtSifre = new TextBox();
            lblKullaniciAdi = new Label();
            lblSifre = new Label();
            btnGiris = new Button();
            SuspendLayout();
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.BorderStyle = BorderStyle.FixedSingle;
            txtKullaniciAdi.Location = new Point(90, 65);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(195, 23);
            txtKullaniciAdi.TabIndex = 0;
            // 
            // txtSifre
            // 
            txtSifre.BorderStyle = BorderStyle.FixedSingle;
            txtSifre.Location = new Point(90, 124);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(195, 23);
            txtSifre.TabIndex = 0;
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.Location = new Point(90, 47);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new Size(76, 15);
            lblKullaniciAdi.TabIndex = 1;
            lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Location = new Point(90, 107);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(33, 15);
            lblSifre.TabIndex = 1;
            lblSifre.Text = "Şifre:";
            // 
            // btnGiris
            // 
            btnGiris.Location = new Point(210, 165);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(75, 23);
            btnGiris.TabIndex = 2;
            btnGiris.Text = "Giriş";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // frmKullaniciGirisi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 211);
            Controls.Add(btnGiris);
            Controls.Add(lblSifre);
            Controls.Add(lblKullaniciAdi);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            Name = "frmKullaniciGirisi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmKayitliKullaniciGirisi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtKullaniciAdi;
        private TextBox txtSifre;
        private Label lblKullaniciAdi;
        private Label lblSifre;
        private Button btnGiris;
    }
}