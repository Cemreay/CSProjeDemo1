using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1
{
    public class Uye : IUye
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int UyeNumarasi { get; set; }
        public List<Kitap> OduncKitaplar { get; set; }

        public Uye(string ad, string soyad, int uyeNumarasi)
        {
            Ad = ad;
            Soyad = soyad;
            UyeNumarasi = uyeNumarasi;
            OduncKitaplar = new List<Kitap>();
        }

        public void KitapOduncAl(Kitap kitap)
        {

            if (kitap.KitapDurumu == Durum.OduncAlabilir)
            {
                kitap.KitapDurumu = Durum.OduncVerildi;
                OduncKitaplar.Add(kitap);
                Console.WriteLine($"{kitap.Baslik} adlı kitap ödünç alındı.");
            }
            else
            {
                Console.WriteLine($"{kitap.Baslik} adlı kitap mevcut değil.");
            }
        }

        public void KitapIadeEt(Kitap kitap)
        {
            if (OduncKitaplar.Contains(kitap))
            {
                OduncKitaplar.Remove(kitap);
                kitap.KitapDurumu = Durum.OduncAlabilir;

                Console.WriteLine($"{kitap.Baslik} adlı kitap iade edildi.");
            }
            else
            {
                Console.WriteLine($"{kitap.Baslik} adlı kitap ödünç alınmamış.");
            }
        }

        public void OduncAlinanKitaplariGoruntule()
        {
            Console.WriteLine($"Üye: {Ad} {Soyad}, Numara: {UyeNumarasi}");
            Console.WriteLine("Ödünç Alınan Kitaplar:");
            foreach (var kitap in OduncKitaplar)
            {
                Console.WriteLine($"{kitap.Baslik} - {kitap.Yazar}");
            }
        }
    }
}
