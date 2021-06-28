using System;
using System.Collections.Generic;

namespace console1
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.Write("Cümleyi giriniz: ");
           string cumle = Console.ReadLine();

          string sesli = "aeıioöuü";
          List<string> cumledekiSesliler = new List<string>();

            for (int i = 0; i < cumle.Length; i++)
            {
                if(sesli.Contains(cumle[i]))
                {
                    cumledekiSesliler.Add(cumle[i].ToString());
                }
            }

            cumledekiSesliler.Sort();
            Console.WriteLine("Cümledeki sesli harfler:");
            foreach(var harf in cumledekiSesliler)
            Console.Write(harf+" ");

        }
    }
}
