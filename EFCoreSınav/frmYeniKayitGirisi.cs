using EFCoreSınav.Data;
using EFCoreSınav.Entities;
using EFCoreSınav.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace EFCoreSınav
{
    public partial class frmYeniKayitGirisi : Form
    {
        Repository<AdminBilgisi> repo;
        PlakDBContext _db;
        public frmYeniKayitGirisi()
        {
            InitializeComponent();
            _db = new PlakDBContext();
            repo = new Repository<AdminBilgisi>();
        }



        private void btnKayitOlustur_Click(object sender, EventArgs e)
        {
            

         

            var dbKullaniciAdi = _db.AdminBilgileri.Where(x => x.KullaniciAdi == txtAd.Text).Count();
            if (dbKullaniciAdi == 0)
            {
                if (txtSifreOlustur.Text == txtSifreyiTekrarGirin.Text)
                {

                    string sifre = sha256_hash(txtSifreOlustur.Text);
                    AdminBilgisi adminBilgisi = new AdminBilgisi()
                    {
                        KullaniciAdi = txtAd.Text,
                        Sifre = sifre
                    };
                    repo.Ekle(adminBilgisi);
                    _db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Şifrelerin Aynı Olduğunu Kontrol Edin");
                }
                MessageBox.Show("Kayıt Başarılı");
            }
            else
            {
                MessageBox.Show("Lütfen Farklı Bir Kullanıcı Adı Girin");
            }
            

            frmKullaniciGirisi frmKullaniciGirisi = new frmKullaniciGirisi();
            frmKullaniciGirisi.Show();
            this.Close();

        }

        private void txtSifreOlustur_TextChanged(object sender, EventArgs e)
        {
            RegularEx("^(?=.*?[A-Z])(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[a-z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[!:+*])(?=.*?[!:+*]).{8,}$", txtSifreOlustur, lblSifre);
        }
        public void RegularEx(string rgx, TextBox txtb, Label lbl)
        {
            Regex regex = new Regex(rgx);
            Match match = regex.Match(txtb.Text);

            
        }

        private void txtSifreyiTekrarGirin_TextChanged(object sender, EventArgs e)
        {
            RegularEx("^(?=.*?[A-Z])(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[a-z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[!:+*])(?=.*?[!:+*]).{8,}$", txtSifreyiTekrarGirin, lblSifreyiTekrarGirin);
            if (txtSifreOlustur.Text == txtSifreyiTekrarGirin.Text)
            {
                btnKayitOlustur.Enabled = true;
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

