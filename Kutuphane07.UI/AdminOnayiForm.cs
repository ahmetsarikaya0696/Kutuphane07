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
    public partial class AdminOnayiForm : Form
    {

        public event EventHandler KitapSilindi;
        public AdminOnayiForm()
        {
            InitializeComponent();
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            if (txtAdminKullaniciAdi.Text == KullaniciYoneticisi.Admin.KullaniciAdi && txtAdminSifre.Text == KullaniciYoneticisi.Admin.Parola)
            {
                MessageBox.Show("İşlem onaylandı!");
                if (KitapSilindi != null)
                {
                    KitapSilindi(this, e);
                }
            }
            else
            {
                MessageBox.Show("Kullanici adi veya şifre yanlış!");
            }


        }
    }
}
