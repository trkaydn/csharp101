using System;

namespace console1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];

            for (int i = 0; i < 20; i++)
            {
                int sayi=0;
                Console.Write(i+1+". sayıyı girin: ");
                bool control = int.TryParse(Console.ReadLine(), out sayi);

                if(!control  || sayi<0)
                return;

                array[i] = sayi;
            }

            Array.Sort(array);
            
            int[] kucuk = new int[3];
            kucuk[0] = array[0];
            kucuk[1] = array[1];
            kucuk[2] = array[2];
            
           int[] buyuk = new int[3];
           buyuk[0] = array[19];
           buyuk[1] = array[18];
           buyuk[2] =array[17];

            double kucukort=0, buyukort=0;
            foreach (var sayi in kucuk)
            {
                kucukort+=sayi;
                kucukort=kucukort/3;
            }
               foreach (var sayi in buyuk)
            {
                buyukort+=sayi;
                buyukort=buyukort/3;
            }

            Console.WriteLine("En küçük 3 sayının ortalaması: "+kucukort);
            Console.WriteLine("En büyük 3 sayının ortalaması: "+buyukort);
            Console.WriteLine("Her iki ortalamanın toplamı: "+(kucukort+buyukort));

        }
    }
}
