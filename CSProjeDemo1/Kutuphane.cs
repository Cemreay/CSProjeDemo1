using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1
{
    public class Kutuphane
    {
        public List<Kitap> MevcutKitaplar { get; set; }
        public List<Uye> Uyeler { get; set; }

        public Kutuphane()
        {
            MevcutKitaplar = new List<Kitap>();
            Uyeler = new List<Uye>();
        }

        public void KitapEkle(Kitap kitap)
        {
            MevcutKitaplar.Add(kitap);
        }

        public void UyeEkle(Uye uye)
        {
            Uyeler.Add(uye);
        }

        public void KitapDurumunuGuncelle(Kitap kitap, Durum durum)
        {
            kitap.KitapDurumu = durum;
        }

        public void KütüphaneDurumunuGoruntule()
        {
            Console.WriteLine("Kütüphane Durumu:");
            Console.WriteLine($"Mevcut Kitaplar: {MevcutKitaplar.Count}");
            Console.WriteLine($"Üye Sayısı: {Uyeler.Count}");
            int oduncAlinanKitaplarSayisi = 0;
            foreach (var kitap in MevcutKitaplar)
            {
                if (kitap.KitapDurumu == Durum.OduncVerildi)
                {
                    oduncAlinanKitaplarSayisi++;
                }
            }
            Console.WriteLine($"Ödünç Alınan Kitaplar : {oduncAlinanKitaplarSayisi}");
        }

        public void KitapDurumGörüntüle(Kitap kitap)
        {
            if (kitap.KitapDurumu == Durum.OduncVerildi)
            {
                Console.WriteLine("Kitap başkası tarafından alınmıştır");
            }
            else if (kitap.KitapDurumu == Durum.MevcutDegil)
            {
                Console.WriteLine("Kitap mevcut değildir.");
            }
            else
            {
                Console.WriteLine(
                "Kitap ödünç alınabilir.");
            }



        }


    }
}
