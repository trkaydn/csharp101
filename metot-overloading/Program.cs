using System;

namespace metot_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //out parametreler 
            string sayi="999";
            int outSayi;
            bool sonuc = int.TryParse(sayi, out outSayi);
            
            if(sonuc)
            {
                Console.WriteLine("Başarılı!");
                Console.WriteLine(outSayi);
            }
            else
            Console.WriteLine("Başarısız!");

            Metotlar instance = new Metotlar();
            instance.Topla(4,5, out int toplamSonucu);
            Console.WriteLine(toplamSonucu);

            //Metot aşırı yükleme - overloading
            int ifade=999;
            instance.EkranaYazdir(ifade.ToString());
            instance.EkranaYazdir(ifade);
            instance.EkranaYazdir("Tarık","Aydın");
        }
    }

    class Metotlar
    {
        public void Topla(int a,int b, out int toplam)
        {
            toplam=a+b;
        }

        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(string veri1,string veri2)
        {
            Console.WriteLine(veri1 + veri2);
        }
    }
}
