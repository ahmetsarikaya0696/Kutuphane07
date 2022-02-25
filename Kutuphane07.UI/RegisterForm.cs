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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            bool gerekliAlanlarDoluMu = !(string.IsNullOrEmpty(txtKullaniciAdi.Text) && string.IsNullOrEmpty(txtAd.Text) && string.IsNullOrEmpty(txtSoyad.Text) && string.IsNullOrEmpty(txtSifre.Text) && string.IsNullOrEmpty(txtSifreTekrarla.Text));

            if (gerekliAlanlarDoluMu && !KullaniciYoneticisi.KullaniciVarMi(txtKullaniciAdi.Text))
            {
                KullaniciYoneticisi.KayitOl(new Kullanici(txtAd.Text + " " + txtSoyad.Text, txtKullaniciAdi.Text, txtSifre.Text));
                DialogResult dr = MessageBox.Show("Kayıt başarılı!", "Kayıt başarılı!",MessageBoxButtons.OK);
                if (dr == DialogResult.OK)
                {
                    Close();
                }

            }
            else
            {
                MessageBox.Show("Kayıt başarısız! Lütfen gerekli alanları doldurunuz ve girdiğiniz şifrelerin birbiriyle uyuştuğundan emin olunuz!");
            }
        }


        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {
            if (KullaniciYoneticisi.KullaniciVarMi(txtKullaniciAdi.Text))
            {
                lblKullaniciAdiUygunluk.Text = "Girilen kullanıcı adı kullanılmakta!";
                lblKullaniciAdiUygunluk.ForeColor = Color.Red;
            }
            else
            {
                lblKullaniciAdiUygunluk.Text = "Kullanıcı adı uygun.";
                lblKullaniciAdiUygunluk.ForeColor = Color.Green;
            }

        }

        private void txtSifreTekrarla_TextChanged(object sender, EventArgs e)
        {
            SifreUygunluk();
        }
        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            SifreUygunluk();
        }

        private void SifreUygunluk()
        {
            if (txtSifre.Text != txtSifreTekrarla.Text)
            {
                lblSifreUygunluk.Text = "Girilen şifreler farklı!";
                lblSifreUygunluk.ForeColor = Color.Red;
            }
            else
            {
                lblSifreUygunluk.Text = "Girilen şifreler uyuşuyor.";
                lblSifreUygunluk.ForeColor = Color.Green;
            }
        }

    }
}
