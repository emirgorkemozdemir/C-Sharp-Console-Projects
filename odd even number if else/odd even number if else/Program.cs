using System;

namespace odd_even_number_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayı;

            Console.Write("Sayıyı giriniz : ");

            sayı = Convert.ToInt32(Console.ReadLine());

            if (sayı % 2 == 0)
            {
                Console.Write("Sayı Çift");
            }
            else
            {
                Console.Write("Sayı Tek");
            }

            Console.ReadKey();






        }
    }
}
