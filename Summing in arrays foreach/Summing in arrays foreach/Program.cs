using System;

namespace Summing_in_arrays_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayılar = { 45, 68, 56, 568, 44 };

            int toplam = 0;

            foreach (int sayı in sayılar)
            {
                toplam = toplam + sayı;




            }

            Console.Write("Toplamınız :" + toplam);

            Console.Read();




        }
    }
}
