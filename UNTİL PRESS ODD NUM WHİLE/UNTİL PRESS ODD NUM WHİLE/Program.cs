using System;

namespace UNTİL_PRESS_ODD_NUM_WHİLE
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayı;
            Console.Write("Lütfen sayı giriniz : ");
            sayı=Convert.ToInt32(Console.ReadLine());

            while (sayı % 2 == 0) 
            {
                Console.Write("Lütfen sayı giriniz : ");
                sayı = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Tek sayı girdiniz");
            Console.ReadKey();

        }
    }
}
