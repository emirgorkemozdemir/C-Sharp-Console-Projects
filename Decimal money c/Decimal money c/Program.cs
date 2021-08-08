using System;

namespace Decimal_money_c
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a;

            a = 3.884m;

            Console.WriteLine("Money1 {0:C}", a );

            decimal b;

            b = 3.996m;

            Console.WriteLine("Money2 {0:C} ", b);

            Console.ReadKey();

        }
    }
}
