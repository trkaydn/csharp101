using System;

namespace console1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Pozitif bir tam sayı giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());

            string[] array = new string[n];

            for (int i=0;i<n;i++)
            {
                Console.Write(i+1 + ". kelimeyi girin: ");
                array[i] = Console.ReadLine();
            }

            Array.Reverse(array);

            foreach(var text in array)
            {
                Console.WriteLine(text);
            }
        }
    }
}
