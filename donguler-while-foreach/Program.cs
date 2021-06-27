using System;

namespace console_programlama
{
    class Program
    {
        public static void Main(string[] args)
        {
            //while
            //1den başlayarak console'a girilen sayıya kadar (sayı dahil) ortalama hesaplayıp console'a yazdıran program.
            int sayi = int.Parse(Console.ReadLine());
            int sayac =0;
            int toplam=0;
            while (sayac<=sayi)
            {
                toplam+=sayac;
                sayac++;
            }
            Console.WriteLine(toplam/sayi);

            //a'dan z'ye kadar tüm harfleri console'a yazdır.
            char character='a';
            while (character <='z')
            {
                Console.Write(character);
                character++;
            }

            Console.WriteLine("*** Foreach ****");
            string[] arabalar = {"BMW","Ford","Toyota","Opel"};
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }


        }
    }
}
