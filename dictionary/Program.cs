using System;
using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //system.collection.generic
            Dictionary<int,string> kullanicilar = new Dictionary<int, string>();

            kullanicilar.Add(10,"Ayşe Yılmaz");
            kullanicilar.Add(12,"Ahmet Yılmaz");
            kullanicilar.Add(18,"Deniz Arda");
            kullanicilar.Add(20,"Özcan Coşar");

            //dizinin elemanlarına erişim
            Console.WriteLine("*** Elemenlara Erişim ***");
            Console.WriteLine(kullanicilar[12]);
            foreach (var item in kullanicilar)
                Console.WriteLine(item);

            //count
            Console.WriteLine(kullanicilar.Count);

            //contains
            Console.WriteLine(kullanicilar.ContainsKey(12));
            Console.WriteLine(kullanicilar.ContainsValue("Tarık Aydın"));

            //remove
            Console.WriteLine("*** Remove ***");
            kullanicilar.Remove(12);
            foreach (var item in kullanicilar)
                Console.WriteLine(item);

            //keys
            Console.WriteLine("*** Keys ***");
             foreach (var item in kullanicilar.Keys)
                Console.WriteLine(item);

            //values
            Console.WriteLine("*** Values ***");
            foreach (var item in kullanicilar.Values)
                Console.WriteLine(item);
        }
    }
}
