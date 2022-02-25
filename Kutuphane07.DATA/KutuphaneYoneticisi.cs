using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane07.DATA
{
    public static class KutuphaneYoneticisi
    {
        public static List<Kitap> KitapListesi { get; set; } = new List<Kitap>() {

            new Kitap("İFA", new DateTime(2019, 01, 01), KitapTurEnum.Eğitim, "Sinan Canan", 184, "İnsanın Fabrika Ayarları"),
            new Kitap("Outliers", new DateTime(2019, 01, 01), KitapTurEnum.Eğitim, "Malcolm Gladwell", 244, "Çizginin Dışındakiler"),
            new Kitap("İnsan Nedir?", new DateTime(2019, 01, 01), KitapTurEnum.Roman, "Mark Twain", 136, "İnsan nedir?"),

            };

        public static void KitapBagisla(string kitapAdi, DateTime basimTarihi, KitapTurEnum kitapTuru, string yazarAdi, int sayfaSayisi, string aciklama = "")
        {
            Kitap bagisYapilanKitap = new Kitap(kitapAdi, basimTarihi, kitapTuru, yazarAdi, sayfaSayisi, aciklama);
            KutuphaneYoneticisi.KitapListesi.Add(bagisYapilanKitap);
        }

        public static void KitapImhaEt()
        {

        }

        public static void KitapOduncAl(Kullanici kullanici, Kitap kitap)
        {

        }

        public static List<Kitap> SeciliTurdekiKitaplariDondur(KitapTurEnum kitapTuru)
        {
            return KutuphaneYoneticisi.KitapListesi.Where(x => x.KitapTuru == kitapTuru).ToList();
        }
    }
}
