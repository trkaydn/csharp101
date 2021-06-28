using System;

namespace console1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Pozitif bir tam sayı giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];

            for (int i=0;i<n;i++)
            {
                Console.Write(i+1 + ". sayıyı girin: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach(var number in array)
            {
                if (number%2==0)
                Console.WriteLine(number);
            }
        }
    }
}
