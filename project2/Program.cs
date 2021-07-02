using System;

namespace project2
{
    class Program
    {
        static void Main(string[] args)
        {
            IslemManager manager = new IslemManager();
        Start:
            try
            {
                Console.WriteLine("(1) Board Listelemek");
                Console.WriteLine("(2) Board'a Kart Eklemek");
                Console.WriteLine("(3) Board'dan Kart Silmek");
                Console.WriteLine("(4) Kart Taşımak");
                Console.Write("Lütfen yapmak istediğiniz işlemi seçiniz :");

                int islem = Convert.ToInt32(Console.ReadLine());

                switch (islem)
                {
                    case 1:
                        manager.GetList();
                        break;

                    case 2:
                        manager.AddCart();
                        break;

                    case 3:
                        manager.DeleteCart();
                        break;

                    case 4:
                        manager.MoveCart();
                        break;
                }

                goto Start;
            }
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
                goto Start;
            }

        }
    }
}
