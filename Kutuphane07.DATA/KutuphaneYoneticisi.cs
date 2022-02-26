using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane07.DATA
{
    public static class KutuphaneYoneticisi
    {
        public static List<Kitap> KitapListesi { get; set; } = new List<Kitap>();

        public static void KitapBagisla(string kitapAdi, DateTime basimTarihi, KitapTurEnum kitapTuru, string yazarAdi, int sayfaSayisi, string aciklama = "")
        {
            Kitap bagisYapilanKitap = new Kitap(kitapAdi, basimTarihi, kitapTuru, yazarAdi, sayfaSayisi, aciklama);
            KutuphaneYoneticisi.KitapListesi.Add(bagisYapilanKitap);
        }

        public static void KitapImhaEt(Kitap kitap)
        {
            KutuphaneYoneticisi.KitapListesi.Remove(kitap);
        }

        public static void KitapOduncAl(Kullanici kullanici, Kitap kitap)
        {
            kullanici.OduncAlinanKitapListesi.Add(kitap);
            KutuphaneYoneticisi.KitapListesi.Remove(kitap);
        }

        public static void KitabiTeslimEt(Kullanici kullanici, Kitap kitap)
        {
            kullanici.OduncAlinanKitapListesi.Remove(kitap);
            KutuphaneYoneticisi.KitapListesi.Add(kitap);
        }

        public static List<Kitap> SeciliTurdekiKitaplariDondur(KitapTurEnum kitapTuru)
        {
            return KutuphaneYoneticisi.KitapListesi.Where(x => x.KitapTuru == kitapTuru).ToList();
        }
    }
}
