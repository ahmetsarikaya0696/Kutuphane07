using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane07.DATA
{
    public static class KullaniciYoneticisi
    {
        public static List<Kullanici> KullanciListesi { get; set; } = new List<Kullanici>();

        public static void KayitOl(Kullanici kullanici)
        {
            if (!KullaniciVarMi(kullanici.KullaniciAdi))
                KullanciListesi.Add(kullanici);
        }

        public static bool GirisBasariliMi(string kullaniciAdi, string sifre)
        {
            if (KullanciListesi.Any(x => x.KullaniciAdi == kullaniciAdi && x.Parola == sifre))
                return true;
            else
                return false;
        }

        public static bool KullaniciVarMi(string kullaniciAdi)
        {
            return KullanciListesi.Any(x => x.KullaniciAdi == kullaniciAdi);
        }
    }
}
