using System;

namespace console1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir cümle girin: ");
            string text = Console.ReadLine();

            string[] words = text.Split(' ');
            int lettercount = text.Trim().Replace(" ", string.Empty).Length;
            int wordscount = words.Length;

            Console.WriteLine("Toplam kelime sayısı: {0}, Toplam harf sayısı: {1}",wordscount,lettercount);

        }
    }
}
