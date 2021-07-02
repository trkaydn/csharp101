using System.Collections.Generic;
using System;
namespace project2
{
    public class IslemManager : IIslem
    {
        List<Card> Todo = new List<Card>();
        List<Card> InProgress = new List<Card>();
        List<Card> Done = new List<Card>();

        List<Kisi> uyeler = new List<Kisi>();
        public IslemManager()
        {
            Todo.Add(new Card()
            {
                Baslik = "test1 başlık",
                Icerik = "test1 içerik",
                KisiID = 1,
                Size = CardSize.XS
            });

            Todo.Add(new Card()
            {
                Baslik = "test2 başlık",
                Icerik = "test2 içerik",
                KisiID = 2,
                Size = CardSize.M
            });

            Todo.Add(new Card()
            {
                Baslik = "test3 başlık",
                Icerik = "test3 içerik",
                KisiID = 1,
                Size = CardSize.L
            });

            uyeler.Add(new Kisi()
            {
                KisiID = 1
            });

            uyeler.Add(new Kisi()
            {
                KisiID = 2
            });

            uyeler.Add(new Kisi()
            {
                KisiID = 3
            });

        }
        public void AddCart()
        {
            Card newCard = new Card();
            Console.Write("Başlık Giriniz: ");
            newCard.Baslik = Console.ReadLine();
            Console.Write("İçerik Giriniz: ");
            newCard.Icerik = Console.ReadLine();
            Console.Write("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  :");
            int number = Convert.ToInt32(Console.ReadLine());
            newCard.Size = (CardSize)number;
            Console.Write("Kişi seçiniz: ");
            int kisino = Convert.ToInt32(Console.ReadLine());
            foreach (var kisi in uyeler)
            {
                if (kisi.KisiID == kisino)
                    newCard.KisiID = kisino;
            }
            if (newCard.KisiID == 0)
            {
                Console.WriteLine("Hatalı girişler yaptınız!");
                return;
            }
            Todo.Add(newCard);

        }

        public void DeleteCart()
        {
            Console.Write(" Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.\nLütfen kart başlığını yazınız: ");
            string text = Console.ReadLine();
            bool a = false;

            var todo = Todo.Find(x => x.Baslik == text);
            if (todo != null)
            {
                Todo.Remove(todo);
                a = true;
            }

            var inprogress = InProgress.Find(x => x.Baslik == text);
            if (inprogress != null)
            {
                InProgress.Remove(inprogress);
                a = true;
            }

            var done = Done.Find(x => x.Baslik == text);
            if (done != null)
            {
                Done.Remove(done);
                a = true;
            }

            if (!a)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız. \n  * Silmeyi sonlandırmak için : (1) \n* Yeniden denemek için : (2)");
                int cevap = Convert.ToInt32(Console.ReadLine());
                if (cevap == 2)
                    DeleteCart();
            }


        }

        public void GetList()
        {
            Console.WriteLine("\nTODO Line \n*************");
            if (Todo.Count < 1)
                Console.WriteLine(" ~ BOŞ ~");
            else
            {
                foreach (var item in Todo)
                {
                    Console.WriteLine("Başlık: " + item.Baslik);
                    Console.WriteLine("İçerik: " + item.Icerik);
                    Console.WriteLine("Atanan Kişi: " + item.KisiID);
                    Console.WriteLine("Büyüklük: " + item.Size);
                    Console.WriteLine();
                }
            }

            Console.WriteLine("\nIN PROGRESS Line \n*************");
            if (InProgress.Count < 1)
                Console.WriteLine(" ~ BOŞ ~");
            else
            {
                foreach (var item in InProgress)
                {
                    Console.WriteLine("Başlık: " + item.Baslik);
                    Console.WriteLine("İçerik: " + item.Icerik);
                    Console.WriteLine("Atanan Kişi: " + item.KisiID);
                    Console.WriteLine("Büyüklük: " + item.Size);
                    Console.WriteLine();

                }
            }

            Console.WriteLine("\nDone LINE \n*************");
            if (Done.Count < 1)
                Console.WriteLine(" ~ BOŞ ~");
            else
            {
                foreach (var item in Done)
                {
                    Console.WriteLine("Başlık: " + item.Baslik);
                    Console.WriteLine("İçerik: " + item.Icerik);
                    Console.WriteLine("Atanan Kişi: " + item.KisiID);
                    Console.WriteLine("Büyüklük: " + item.Size);
                    Console.WriteLine();

                }
            }
        }

        public void MoveCart()
        {
            Console.Write(" Öncelikle taşımak taşımak kartı seçmeniz gerekiyor.\nLütfen kart başlığını yazınız: ");
            string text = Console.ReadLine();

            var todo = Todo.Find(x => x.Baslik == text);
            var done = Done.Find(x => x.Baslik == text);
            var inprogress = InProgress.Find(x => x.Baslik == text);


            if (todo != null)
            {
                Console.WriteLine("Bulunan Kart Bilgileri:\n**************************************");
                Console.WriteLine("Başlık :" + todo.Baslik);
                Console.WriteLine("İçerik :" + todo.Icerik);
                Console.WriteLine("Atanan Kişi :" + todo.KisiID);
                Console.WriteLine("Büyüklük: " + todo.Size);
                Console.WriteLine("Line: TODO");
                Console.WriteLine();

                Console.WriteLine("(1) TODO \n (2) IN PROGRESS \n (3) DONE");
                Console.Write("Lütfen taşımak istediğiniz Line'ı seçiniz:");
                int line = Convert.ToInt32(Console.ReadLine());
                if (line == 1)
                    return;

                else if (line == 2)
                {
                    InProgress.Add(todo);
                    Todo.Remove(todo);
                }

                else if (line == 3)
                {
                    Done.Add(todo);
                    Todo.Remove(todo);
                }

            }

            else if (inprogress != null)
            {
                Console.WriteLine("Bulunan Kart Bilgileri:\n**************************************");
                Console.WriteLine("Başlık :" + todo.Baslik);
                Console.WriteLine("İçerik :" + todo.Icerik);
                Console.WriteLine("Atanan Kişi :" + todo.KisiID);
                Console.WriteLine("Büyüklük: " + todo.Size);
                Console.WriteLine("Line: TODO");
                Console.WriteLine();

                Console.WriteLine("(1) TODO \n (2) IN PROGRESS \n (3) DONE");
                Console.Write("Lütfen taşımak istediğiniz Line'ı seçiniz:");
                int line = Convert.ToInt32(Console.ReadLine());
                if (line == 1)
                {
                    Todo.Add(inprogress);
                    InProgress.Remove(inprogress);
                }

                else if (line == 2)
                    return;


                else if (line == 3)
                {
                    Done.Add(inprogress);
                    InProgress.Remove(inprogress);
                }
            }

            else if (done != null)
            {
                Console.WriteLine("Bulunan Kart Bilgileri:\n**************************************");
                Console.WriteLine("Başlık :" + todo.Baslik);
                Console.WriteLine("İçerik :" + todo.Icerik);
                Console.WriteLine("Atanan Kişi :" + todo.KisiID);
                Console.WriteLine("Büyüklük: " + todo.Size);
                Console.WriteLine("Line: TODO");
                Console.WriteLine();

                Console.WriteLine("(1) TODO \n (2) IN PROGRESS \n (3) DONE");
                Console.Write("Lütfen taşımak istediğiniz Line'ı seçiniz:");
                int line = Convert.ToInt32(Console.ReadLine());
                if (line == 1)
                {
                    Todo.Add(done);
                    Done.Remove(done);
                }

                else if (line == 2)
                {
                    InProgress.Add(done);
                    Done.Remove(done);
                }


                else if (line == 3)
                    return;
            }
            else
            {
                Console.WriteLine("Aradığınız kriterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız. \n  * Taşımayı sonlandırmak için : (1) \n* Yeniden denemek için : (2)");
                int cevap = Convert.ToInt32(Console.ReadLine());
                if (cevap == 2)
                    MoveCart();
            }


        }
    }
}
