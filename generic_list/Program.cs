using System;
using System.Collections.Generic;

namespace generic_list
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T> class
            //System.Collections.Generic
            // T=> object türündedir.

            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("kırmızı");
            renkListesi.Add("mavi");
            renkListesi.Add("turuncu");
            renkListesi.Add("sarı");
            renkListesi.Add("yeşil");

            //Count
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            foreach (var sayi in sayiListesi)
            Console.WriteLine(sayi);
            foreach (var renk in renkListesi)
            Console.WriteLine(renk);
                
            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
            renkListesi.ForEach(renk=> Console.WriteLine(renk));

            //listeden eleman çıkarma
            sayiListesi.RemoveAt(4);
            renkListesi.Remove("yeşil");
            
            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);

            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
            renkListesi.ForEach(renk=> Console.WriteLine(renk));

            //liste içerisinde arama
            if(sayiListesi.Contains(10))
            Console.WriteLine("10 liste içerisinde bulundu!");

            //eleman ile indexe erişme
            Console.WriteLine(renkListesi.BinarySearch("sarı"));

            //diziyi List'e çevirme
            string[] hayvanlar = {"kedi","köpek","kuş"};
            
            List<string> hayvanListesi = new List<string>(hayvanlar);

            //Listeyi temizleme
            hayvanListesi.Clear();

            //list içinde nesne tutma
            List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();

            Kullanicilar kullanici1 = new Kullanicilar();
            kullanici1.Isim="Tarık";
            kullanici1.Soyisim="Aydın";
            kullanici1.Yas=20;

            Kullanicilar kullanici2 = new Kullanicilar();
            kullanici2.Isim="Faruk";
            kullanici2.Soyisim="Aydın";
            kullanici2.Yas=24;

            List<Kullanicilar> yeniListe = new List<Kullanicilar>();
            yeniListe.Add(new Kullanicilar(){
                Isim="Tarık",
                Soyisim="Aydın",
                Yas=20
            });

            foreach (var kullanici in kullaniciListesi)
            {
              Console.WriteLine("Kullanıcı Adı: "+kullanici.Isim);
              Console.WriteLine("Kullanıcı Soyadı: "+kullanici.Soyisim);
              Console.WriteLine("Kullanıcı Yaşı: "+kullanici.Yas);
            }

            yeniListe.Clear();
        }
    }

    public class Kullanicilar
    {
        private string isim;
        private string soyisim;
        private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}
