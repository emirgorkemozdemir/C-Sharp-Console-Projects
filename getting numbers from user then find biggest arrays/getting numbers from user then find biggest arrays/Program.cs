using System;

namespace getting_numbers_from_user_then_find_biggest_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayılar = new int[4];

            for (int i =0; i<4;i++)
            {
                Console.Write("Sayı giriniz : ");

                sayılar[i] = Convert.ToInt32(Console.ReadLine());


            }

            int maxnum;

            maxnum = sayılar[0];

            for (int i =0; i<4;i++)
            {
                if (sayılar[i]>maxnum)
                {
                    maxnum = sayılar[i];
                }
            }

            Console.Write(maxnum);

            Console.Read();
        }
    }
}
