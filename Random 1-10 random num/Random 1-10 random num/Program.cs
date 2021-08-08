using System;

namespace Random_1_10_random_num
{
    class Program
    {
        static void Main(string[] args)
        {

            Random sayılar = new Random();

            int a = sayılar.Next(0, 11);

            Console.WriteLine(a);

            Console.Read();


        }
    }
}
