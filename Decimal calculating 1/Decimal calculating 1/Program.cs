using System;

namespace Decimal_calculating_1
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal p1, p2, total;


            int ad1, ad2;

            p1 = 14.85m;

            p2 = 22.88m;

            Console.WriteLine("1.ürünün adetini giriniz : ");

            ad1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("2. ürünün adetini giriniz : ");

            ad2 = Convert.ToInt32(Console.ReadLine());

            total = ad1 * p1 + ad2 * p2;

            Console.WriteLine("Toplam : " + total);

            Console.ReadKey();


        }
    }
}
