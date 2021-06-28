using System;
using System.Collections;

namespace console1
{
    class Program
    {
        static void Main(string[] args)
        {
           ArrayList AsalSayilar = new ArrayList();
            ArrayList AsalOlmayanSayilar = new ArrayList();

            for (int i = 0; i < 20; i++)
            {
                int sayi=0, sayac=0;
                Console.Write(i+1+". sayıyı girin: ");
                bool control = int.TryParse(Console.ReadLine(), out sayi);

                if(!control  || sayi<0)
                return;

                else if (sayi==1 || sayi==0)
                {
                AsalOlmayanSayilar.Add(sayi);
                continue;
                }

                int j = 2;
                while (j < sayi)
                {
                    if (sayi % j == 0)
                    sayac++;
                    j++;
                }
 
                if (sayac != 0)
                AsalOlmayanSayilar.Add(sayi);
                else
                AsalSayilar.Add(sayi);
            }

            Console.Write("Asal sayılar: ");
            AsalSayilar.Sort();
            AsalSayilar.Reverse();
            foreach (var sayi in AsalSayilar)
                Console.Write(sayi+" ");
            
            Console.WriteLine();
            Console.Write("Asal olmayan sayılar: ");
            AsalOlmayanSayilar.Sort();
            AsalOlmayanSayilar.Reverse();
            foreach (var sayi in AsalOlmayanSayilar)
                Console.Write(sayi+" ");

            Console.WriteLine();
            Console.WriteLine("Toplam {0} adet asal sayı, {1} adet asal olmayan sayı girildi.",AsalSayilar.Count,AsalOlmayanSayilar.Count);

            double asaltoplam=0, asalolmayantoplam=0;
            foreach (var item in AsalSayilar)
             asaltoplam+=Convert.ToInt32(item);

             foreach (var item in AsalOlmayanSayilar)
             asalolmayantoplam+=Convert.ToInt32(item);

            Console.WriteLine("Asal sayıların ortalaması: {0}, Asal olmayan sayıların ortalaması: {1}",(asaltoplam/AsalSayilar.Count),(asalolmayantoplam/AsalOlmayanSayilar.Count));

        }
    }
}
