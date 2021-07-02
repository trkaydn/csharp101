using System;

namespace kalitim_inheritance
{
    public class Hayvanlar : Canlilar
    {
        public void Adaptasyon()
        {
            Console.WriteLine("Hayvanlar adaptasyon yapabilir.");
        }

        public void SuruHalindeHareket()
        {
        Console.WriteLine("Hayvanlar sürüler halinde hareket eder."); 
        }
    }

    public class Kuslar : Hayvanlar
    {
        public void Ucmak()
        {
            Console.WriteLine("Kuşlar uçar");
        }
    }

    public class Ordek : Hayvanlar
    {
        public void Yuzmek()
         {
            Console.WriteLine("Ördekler yüzer");
         }
    }   
}
