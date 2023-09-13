using EFCoreSınav.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFCoreSınav
{
    public partial class frmKullaniciGirisi : Form
    {
        PlakDBContext db;
        public frmKullaniciGirisi()
        {
            InitializeComponent();
            db = new PlakDBContext();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            var sorgu1 = db.AdminBilgileri.Where(x=>x.KullaniciAdi == txtKullaniciAdi.Text).Count();
            var sifre = sha256_hash(txtSifre.Text);
            var sorgu2 = db.AdminBilgileri.Where(x => x.Sifre == sifre).Count();
            if(sorgu1>0 && sorgu2>0)
            {
                frmPlakDukkaniYoneticiEkrani frmPlakDukkaniYoneticiEkrani = new frmPlakDukkaniYoneticiEkrani();
                frmPlakDukkaniYoneticiEkrani.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Girmiş olduğunuz bilgiler hatalıdır !!");
            }

            
        }
        private string sha256_hash(string sifre)
        {
            SHA256 sHA256 = SHA256.Create();

            byte[] bytes = sHA256.ComputeHash(Encoding.UTF8.GetBytes(sifre));
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                sb.Append(bytes[i].ToString());
            }
            return sb.ToString();
        }
    }
}
