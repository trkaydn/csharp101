using System;

namespace console1
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.Write("Pozitif bir sayı girin: ");
           int n=Convert.ToInt32(Console.ReadLine());

           Console.Write("Pozitif bir sayı daha girin: ");
           int m=Convert.ToInt32(Console.ReadLine());

           int[] array = new int[n];

           for(int i=0;i<n;i++)
           {
               Console.Write(i+1 + ". sayıyı girin: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
           }

           foreach(var number in array)
           {
               if (number==m)
               Console.WriteLine(number);
               else if(number % m ==0)
               Console.WriteLine(number);
           }
        }
    }
}
