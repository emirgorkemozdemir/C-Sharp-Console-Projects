using System;

namespace Mehods_summing_2_nums
{
    class Program
    {
        private static int Topla (int s1,int s2)
        {
            int t;
            t = s1 + s2;

            return t;
        }


        static void Main(string[] args)
        {
            int sayı1, sayı2;
            Console.Write("1. sayıyı giriniz : ");
            sayı1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. sayıyı giriniz : ");
            sayı2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Toplamınız : " + Topla(sayı1, sayı2));

            Console.ReadKey();
        }
    }
}
