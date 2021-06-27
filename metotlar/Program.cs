using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //erisim_belirtici geri_donustipi metot_adı(parametreListesi/arguman)
            //{
                //komutlar;
                //return;
            //}

            int a=2;
            int b=3;
            Console.WriteLine(a+b);
            int sonuc = Topla(a,b);
            Console.WriteLine(sonuc);

            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdir(sonuc.ToString());

            int sonuc2=ornek.ArtirVeTopla(ref a,ref b);
            ornek.EkranaYazdir(sonuc2.ToString());
        }
            static int Topla(int x,int y)
            {
                return x+y;
            }
    }
    class Metotlar
    {
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public int ArtirVeTopla(ref int deger1,ref int deger2)
        {
            deger1+=1;
            deger2+=1;
            return deger1+deger2;
        }
    }
}
