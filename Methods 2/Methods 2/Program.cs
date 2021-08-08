using System;

namespace Methods_2
{
    class Program
    {
        private static void print(string bilgi)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(bilgi);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Metni giriniz : ");
            string b;
            b = Console.ReadLine();
            print(b);

            Console.ReadKey();
        }
    }
}
