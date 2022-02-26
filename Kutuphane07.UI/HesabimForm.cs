using Kutuphane07.DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane07.UI
{
    public partial class HesabimForm : Form
    {
        public event EventHandler KitapTeslimEdildi;
        private readonly Kullanici kullanici;

        public HesabimForm(Kullanici kullanici)
        {
            this.kullanici = kullanici;
            InitializeComponent();
            FormuYenile();
        }

        private void FormuYenile()
        {
            dgvOduncAlinanKitaplar.DataSource = null;
            if (kullanici.OduncAlinanKitapListesi != null)
                dgvOduncAlinanKitaplar.DataSource = kullanici.OduncAlinanKitapListesi;
        }

        private void HesabimForm_Load(object sender, EventArgs e)
        {
            lblKullaniciAdi.Text = kullanici.KullaniciAdi;
            lblKullaniciAdSoyad.Text = kullanici.AdSoyad;
            lblKullaniciId.Text = $"{kullanici.Id}";
            lblKullaniciParola.Text = kullanici.Parola;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dgvOduncAlinanKitaplar.SelectedRows.Count == 0) return;

            Kitap teslimEdilecekKitap = (Kitap)dgvOduncAlinanKitaplar.SelectedRows[0].DataBoundItem;
            if (teslimEdilecekKitap != null)
            {
                KutuphaneYoneticisi.KitabiTeslimEt(kullanici, teslimEdilecekKitap);
                FormuYenile();
                if (KitapTeslimEdildi != null)
                {
                    KitapTeslimEdildi(this, e);
                }
            }
        }
    }
}
