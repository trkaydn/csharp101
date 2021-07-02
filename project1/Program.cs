using System;
using System.Collections.Generic;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            List<Kisi> kisiler = KisiListesi.VarsayilanKisiler();
            Start:
             try{
            int islem = IslemSec.Sec();
            
            switch(islem)
            {
                case 1:
                kisiler.Add(KisiKaydet.Kaydet());
                Console.Clear();
                Console.WriteLine("Kişi kaydedildi.");
                break;

                case 2:
                Kisi silinecek = KisiSil.Sil(kisiler);
                if(silinecek!=null)
                {
                    Console.Write("{0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz? (y/n): ",silinecek.Isim);
                    string cevap = Console.ReadLine();
                    if (cevap=="y")
                    {   
                        kisiler.Remove(silinecek);
                        Console.Clear();
                        Console.WriteLine("Kişi silindi.");
                    }
                }
                break;

                case 3:
                Kisi guncellenecek = KisiGuncelle.Guncelle(kisiler);
                if (guncellenecek!=null)
                {
                    Console.WriteLine("Eski numara: "+guncellenecek.Telefon);
                    Console.Write("Yeni numara: ");
                    guncellenecek.Telefon=Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Kişi güncellendi.");
                }
                break;

                case 4:
                Console.Clear();
                KisiListele.Listele(kisiler);
                break;

                case 5:
                int secim = Arama.AramaYontemi();
                Console.Clear();
                if(secim==1)
                    Arama.IsmeGoreBul(kisiler);
                else if (secim==2)
                Arama.NumarayaGoreBul(kisiler);
                break;
                
            }
            Console.WriteLine();
            goto Start;
            }

            catch(Exception e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
                goto Start;
            }
         
        }
    }
}
