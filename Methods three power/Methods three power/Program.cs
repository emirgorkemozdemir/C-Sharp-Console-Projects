using System;

namespace Methods_three_power
{
    class Program
    {
        private static int küp( int sayı)
        {
            int küpsonuç;

            küpsonuç = sayı * sayı * sayı;

            return küpsonuç;


        }
            

            static void Main(string[] args)
        {
            Console.Write("Sayıyı giriniz : ");
            int num;
            num = Convert.ToInt32(Console.ReadLine());

            Console.Write("Sonucunuz : " + küp(num));

            Console.ReadKey();

        }
    }
}
