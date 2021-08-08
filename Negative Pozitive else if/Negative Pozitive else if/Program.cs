using System;

namespace Negative_Pozitive_else_if
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayı;

            Console.Write("Sayıyı Giriniz : ");

            sayı = Convert.ToInt32(Console.ReadLine());

            if (sayı >= 0)
            {
                Console.Write("Sayıf pozitif ");

            }
            else
            {

                Console.Write("Sayı negatif");
            }

            Console.ReadKey();



        }
    }
}
