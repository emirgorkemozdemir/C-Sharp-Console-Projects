using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayı;
            Console.Write("Sayıyı giriniz : ");
            sayı = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mutlak değerli hali : "+Math.Abs(sayı));
            Console.Read();
            

        }
    }
}
