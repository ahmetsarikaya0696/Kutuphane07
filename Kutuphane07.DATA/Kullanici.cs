using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane07.DATA
{
    public class Kullanici
    {
        public Kullanici(string adSoyad, string kullaniciAdi, string parola)
        {
            Id = Guid.NewGuid();
            AdSoyad = adSoyad;
            KullaniciAdi = kullaniciAdi;
            Parola = parola;
            OduncAlinanKitapListesi = new List<Kitap>();
        }
        public Guid Id { get; private set; }
        public string AdSoyad { get; set; }
        public string KullaniciAdi { get; set; }
        public string Parola { get; private set; }
        public List<Kitap> OduncAlinanKitapListesi { get; set; }
    }
}
