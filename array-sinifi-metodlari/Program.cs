﻿using System;

namespace array_sinifi_metodlari
{
    class Program
    {
        static void Main(string[] args)
        {
           //sort 
           int[] sayiDizisi= {23,12,86,72,3,11,17};

           Console.WriteLine("*** Sırasız Dizi ***");
           foreach(var sayi in sayiDizisi)
           {
               Console.WriteLine(sayi);
           }

           Console.WriteLine("*** Sıralı Dizi ***");
           Array.Sort(sayiDizisi);
           foreach(var sayi in sayiDizisi)
           {
               Console.WriteLine(sayi);
           }

           //clear 
           //sayidizisi elemanlarını kullanarak 2.indexten itibaren 2 tane elemanı 0'lar.
           Console.WriteLine("*** Array Clear ***");
           Array.Clear(sayiDizisi,2,2);
           foreach(var sayi in sayiDizisi)
           {
               Console.WriteLine(sayi);
           }

           //reverse
           Console.WriteLine("*** Array Reverse ***");
           Array.Reverse(sayiDizisi);
           foreach(var sayi in sayiDizisi)
           {
               Console.WriteLine(sayi);
           }

           //indexof
            Console.WriteLine("*** Array IndexOf ***");
            Console.WriteLine(Array.IndexOf(sayiDizisi,23));
           
           //Resize
            Console.WriteLine("*** Array Resize ***");
            Array.Resize<int>(ref sayiDizisi,9);
            sayiDizisi[8] = 00;
            foreach(var sayi in sayiDizisi)
            {
               Console.WriteLine(sayi);
            }

        }
    }
}
