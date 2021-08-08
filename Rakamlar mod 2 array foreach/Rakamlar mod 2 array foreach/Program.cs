using System;

namespace Rakamlar_mod_2_array_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rakamlar = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int toplam = 0;
            
            foreach (int x in rakamlar)
            {
                if (x%2==0)
                {
                    toplam = toplam + x;
                }



            }

            Console.Write("Toplamınız : " + toplam);

            Console.Read();


        }
    }
}
