using System;

namespace console_programlama
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
           Console.WriteLine("isminizi girin");
            string name = Console.ReadLine();
            Console.WriteLine("soyisminizi girin");
            string surname = Console.ReadLine();
            Console.WriteLine("Merhaba" +" "+name + " " + surname);
        }
    }
}
