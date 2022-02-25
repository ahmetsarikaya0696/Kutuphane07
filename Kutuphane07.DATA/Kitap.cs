using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane07.DATA
{
    public class Kitap
    {
        public Kitap(string ad, DateTime basimTarihi, KitapTurEnum kitapTur, string yazarAdi, int sayfaSayisi, string aciklama)
        {
            Id = Guid.NewGuid();
            Ad = ad;
            BasimTarihi = basimTarihi;
            KitapTuru = kitapTur;
            YazarAdi = yazarAdi;
            SayfaSayisi = sayfaSayisi;
            Aciklama = aciklama;
        }
        public Guid Id { get; private set; }
        public string Ad { get; set; }
        public DateTime BasimTarihi { get; set; }
        public KitapTurEnum KitapTuru { get; set; }
        public string YazarAdi { get; set; }
        public int SayfaSayisi { get; set; }
        public string Aciklama { get; set; }
    }
}
