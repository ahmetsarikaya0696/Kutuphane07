using Kutuphane07.DATA;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane07.UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            KullaniciVerileriniOku();
        }


        private void llblKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (GirisYapBasariliMi(txtKullaniciAdi.Text, txtSifre.Text))
            {
                Kullanici girisYapanKullanici = (Kullanici)KullaniciYoneticisi.KullanciListesi.FirstOrDefault(x => x.KullaniciAdi == txtKullaniciAdi.Text && x.Parola == txtSifre.Text);
                new KutuphaneForm(girisYapanKullanici).ShowDialog();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre girdiniz! Lütfen tekrar deneyiniz.");
            }
        }

        bool girisYapBasarili = false;
        private bool GirisYapBasariliMi(string kullaniciAdi, string sifre)
        {
            if (KullaniciYoneticisi.GirisBasariliMi(kullaniciAdi, sifre))
                girisYapBasarili = !girisYapBasarili;
            return girisYapBasarili;
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            KullaniciVerileriniKaydet();
        }

        private static void KullaniciVerileriniKaydet()
        {
            string toJson = JsonConvert.SerializeObject(KullaniciYoneticisi.KullanciListesi);
            File.WriteAllText("veri.json", toJson);
        }
        private void KullaniciVerileriniOku()
        {
            string fromJson = File.ReadAllText("veri.json");
            KullaniciYoneticisi.KullanciListesi = JsonConvert.DeserializeObject<List<Kullanici>>(fromJson);
        }
    }
}
