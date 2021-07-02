using System;

namespace project1
{
    public static class KisiKaydet
    {
        public static Kisi Kaydet()
        {
            Kisi yenikisi = new Kisi();

            Console.Write("Lütfen isim giriniz: ");
            yenikisi.Isim = Console.ReadLine();

            Console.Write("Lütfen soyisim giriniz: ");
            yenikisi.Soyisim = Console.ReadLine();

            Console.Write("Lütfen telefon numarası giriniz: ");
            yenikisi.Telefon= Console.ReadLine();
            return yenikisi;

        }

    }
}
