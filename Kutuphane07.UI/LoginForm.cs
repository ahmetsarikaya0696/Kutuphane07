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
            KitapVerileriniOku();
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
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
            }
        }


        private bool GirisYapBasariliMi(string kullaniciAdi, string sifre)
        {
            return KullaniciYoneticisi.GirisBasariliMi(kullaniciAdi, sifre);
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            KullaniciVerileriniKaydet();
            KitapVerileriniKaydet();
        }

        private void KitapVerileriniKaydet()
        {
            string toJson = JsonConvert.SerializeObject(KutuphaneYoneticisi.KitapListesi);
            File.WriteAllText("kitalistesiveri.json", toJson);
        }

        private static void KullaniciVerileriniKaydet()
        {
            string toJson = JsonConvert.SerializeObject(KullaniciYoneticisi.KullanciListesi);
            File.WriteAllText("veri.json", toJson);
        }
        private void KitapVerileriniOku()
        {
            string fromJson = File.ReadAllText("kitalistesiveri.json");
            KutuphaneYoneticisi.KitapListesi = JsonConvert.DeserializeObject<List<Kitap>>(fromJson);
        }
        private void KullaniciVerileriniOku()
        {
            string fromJson = File.ReadAllText("veri.json");
            KullaniciYoneticisi.KullanciListesi = JsonConvert.DeserializeObject<List<Kullanici>>(fromJson);
        }
    }
}
