using EFCoreSınav.Data;
using EFCoreSınav.Entities;
using EFCoreSınav.Repositories;
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
    public partial class frmPlakDukkaniYoneticiEkrani : Form
    {
        private static Repository<Album> repository;
        PlakDBContext db;

        public frmPlakDukkaniYoneticiEkrani()
        {
            InitializeComponent();

            repository = new Repository<Album>();
            db = new PlakDBContext();
        }

        private void frmPlakDukkaniYoneticiEkrani_Load(object sender, EventArgs e)
        {
            ListeyiYenile();
        }

        private void ListeyiYenile()
        {
            dgvTablolar.DataSource = repository.FilterList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Album album = new Album()
            {
                AlbumAdi = txtAlbumAdi.Text,
                AlbumunSanatcisi = txtAlbumSanatcisi.Text,
                AlbumCikisTarihi = dtpAlbumCikisTarihi.Value,
                AlbumFiyati = nudAlbumFiyati.Value,
                IndirimOrani = Convert.ToDouble(nudIndirimOrani.Value),
                SatisaDevamEdiyorMu = cbxSatisDevamDurumu.Checked
            };
            repository.Ekle(album);
            MessageBox.Show("Albümünüz başarıyla eklenmiştir.");
            ListeyiYenile();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string albumAdi = dgvTablolar.SelectedRows[0].Cells["AlbumAdi"].Value.ToString();
            string albumSanatcisi = dgvTablolar.SelectedRows[0].Cells["AlbumunSanatcisi"].Value.ToString();
            DateTime cikisTarihi = (DateTime)dgvTablolar.SelectedRows[0].Cells["AlbumCikisTarihi"].Value;
            decimal fiyat = Convert.ToDecimal(dgvTablolar.SelectedRows[0].Cells["AlbumFiyati"].Value);
            double indirimOrani = Convert.ToDouble(dgvTablolar.SelectedRows[0].Cells["IndirimOrani"].Value);
            bool satisDevamMi = (bool)dgvTablolar.SelectedRows[0].Cells["SatisaDevamEdiyorMu"].Value;

            Album album = repository.Sec(x => x.AlbumAdi == albumAdi
                                        && x.AlbumunSanatcisi == albumSanatcisi
                                        && x.AlbumCikisTarihi == cikisTarihi
                                        && x.AlbumFiyati == fiyat
                                        && x.IndirimOrani == indirimOrani
                                        && x.SatisaDevamEdiyorMu == satisDevamMi
                                        );

            repository.Sil(album);
            MessageBox.Show("Seçilen albüm başarıyla silinmiştir.");
            ListeyiYenile();
        }

        private void dgvTablolar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtAlbumAdi.Text = dgvTablolar.SelectedRows[0].Cells["AlbumAdi"].Value.ToString();
                txtAlbumSanatcisi.Text = dgvTablolar.SelectedRows[0].Cells["AlbumunSanatcisi"].Value.ToString();
                dtpAlbumCikisTarihi.Value = (DateTime)dgvTablolar.SelectedRows[0].Cells["AlbumCikisTarihi"].Value;
                nudAlbumFiyati.Value = Convert.ToDecimal(dgvTablolar.SelectedRows[0].Cells["AlbumFiyati"].Value);
                nudIndirimOrani.Value = Convert.ToDecimal(dgvTablolar.SelectedRows[0].Cells["IndirimOrani"].Value);
                cbxSatisDevamDurumu.Checked = (bool)dgvTablolar.SelectedRows[0].Cells["SatisaDevamEdiyorMu"].Value;
            }
            catch (Exception u)
            {
                MessageBox.Show(u.Message);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvTablolar.SelectedCells[6].Value);
            Album album = repository.Sec(x => x.ID == id);
            album.AlbumAdi = txtAlbumAdi.Text;
            album.AlbumunSanatcisi = txtAlbumSanatcisi.Text;
            album.AlbumCikisTarihi = dtpAlbumCikisTarihi.Value;
            album.AlbumFiyati = nudAlbumFiyati.Value;
            album.IndirimOrani = Convert.ToDouble(nudIndirimOrani.Value);
            album.SatisaDevamEdiyorMu = cbxSatisDevamDurumu.Checked;

            repository.Guncelle(album);
            MessageBox.Show("Seçilen albüm başarıyla güncellenmiştir.");
            ListeyiYenile();
        }

        private void btnSatisYok_Click(object sender, EventArgs e)
        {
            dgvTablolar.DataSource = null;

            dgvTablolar.DataSource = db.Albumler.Where(x => x.SatisaDevamEdiyorMu == false)
                .Select(x => new
                {
                    AlbumAdi = x.AlbumAdi,
                    SanatciAdi = x.AlbumunSanatcisi
                }).ToList();
        }

        private void btnSatisDevam_Click(object sender, EventArgs e)
        {
            dgvTablolar.DataSource = null;

            dgvTablolar.DataSource = db.Albumler.Where(x => x.SatisaDevamEdiyorMu == true)
                .Select(x => new
                {
                    AlbumAdi = x.AlbumAdi,
                    SanatciAdi = x.AlbumunSanatcisi
                }).ToList();
        }

        private void btnIndirim_Click(object sender, EventArgs e)
        {
            dgvTablolar.DataSource = null;

            dgvTablolar.DataSource = db.Albumler.Where(x => x.IndirimOrani != 0)
                .OrderByDescending(x => x.IndirimOrani)
                .Select(x => new
                {
                    AlbumAdi = x.AlbumAdi,
                    SanatciAdi = x.AlbumunSanatcisi
                }).ToList();
        }

        private void btnSon10Album_Click(object sender, EventArgs e)
        {
            dgvTablolar.DataSource = null;

            dgvTablolar.DataSource = db.Albumler.OrderByDescending(x => x.ID)
                .Select(x => new
                {
                    AlbumAdi = x.AlbumAdi,
                    SanatciAdi = x.AlbumunSanatcisi
                }).Take(10).ToList();
        }

        private void btnAlbumler_Click(object sender, EventArgs e)
        {
            ListeyiYenile();
        }
    }
}
