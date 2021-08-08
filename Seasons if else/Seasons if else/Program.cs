using System;

namespace Seasons_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            string mevsim;

            Console.Write("Mevsimi Giriniz : ");

            mevsim = Console.ReadLine();

            if (mevsim == "Kış")
            {
                Console.Write("Aralık,Ocak,Şubat");
            }
            else if (mevsim == "Yaz")
            {
                Console.Write("Haziran,Temmuz,Ağustos");
            }
            else if (mevsim == "İlkbahar")
            {
                Console.Write("Mart,Nisan,Mayıs");
            }
            else if (mevsim == "Sonbahar")
            {
                Console.Write("Eylül,Ekim,Kasım");
            }

            Console.ReadKey();






        }
    }
}
