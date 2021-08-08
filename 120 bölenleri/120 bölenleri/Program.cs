using System;

namespace _120_bölenleri
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayı = 120;

            for (int i = 1; i <= 120; i++)
            {
                if (sayı % i == 0)
                {
                    Console.WriteLine(i);
                }
            }


            Console.ReadKey();



        }
    }
}
