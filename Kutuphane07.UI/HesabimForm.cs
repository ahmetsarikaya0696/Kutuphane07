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
        private readonly Kullanici kullanici;

        public HesabimForm(Kullanici kullanici)
        {
            this.kullanici = kullanici;
            InitializeComponent();
        }

        private void HesabimForm_Load(object sender, EventArgs e)
        {
            lblKullaniciAdi.Text = kullanici.KullaniciAdi;
            lblKullaniciAdSoyad.Text = kullanici.AdSoyad;
            lblKullaniciId.Text = $"{kullanici.Id}";
            lblKullaniciParola.Text = kullanici.Parola;
        }
    }
}
