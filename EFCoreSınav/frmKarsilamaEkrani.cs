using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFCoreSınav
{
    public partial class frmKarsilamaEkrani : Form
    {
        public frmKarsilamaEkrani()
        {
            InitializeComponent();
        }

        private void btnKullaniciGirisi_Click(object sender, EventArgs e)
        {
            frmKullaniciGirisi frmKullaniciGirisi = new frmKullaniciGirisi();
            frmKullaniciGirisi.Show();
           
        }

        private void btnYeniKayitOlustur_Click(object sender, EventArgs e)
        {
            frmYeniKayitGirisi frmYeniKayitGirisi=new frmYeniKayitGirisi();
            frmYeniKayitGirisi.Show();
            

        }
    }
}
