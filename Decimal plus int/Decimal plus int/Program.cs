using System;

namespace Decimal_plus_int
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal dec1;

            dec1 = 2.54M;

            int reel1;

            reel1 = 5;

            decimal total;

            total = dec1 + reel1  ;

            Console.WriteLine("Total : " + total);

            Console.ReadKey();



        }
    }
}
