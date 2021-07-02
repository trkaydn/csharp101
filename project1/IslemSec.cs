using System;
using System.Collections.Generic;

namespace project1
{
    public static class IslemSec
    {  
        public static int Sec()
        {
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");
            Console.WriteLine("*************************");
            Console.Write("Lütfen yapmak istediğiniz işlemi seçiniz: ");
            int islem= Convert.ToInt32(Console.ReadLine());
            return islem;
           
        }

        

    }
}
