using System;

namespace Matris_Toplam_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Satır Sayısı");

            int satır = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sütun Sayısı");

            int toplam = 0;

            int sütun = Convert.ToInt32(Console.ReadLine());

            int [,] matris = new int[satır, sütun];

            Random rnd = new Random();

            for (int i = 0; i < satır; i++)
            {
                for (int k = 0; k < sütun; k++)
                {
                    matris[i, k] = rnd.Next(50);
                    Console.Write(matris[i, k] + " ");
                }
                Console.WriteLine();
            }

            for (int m = 0; m < satır; m++)
            {
                for (int n = 0; n < sütun; n++)
                {
                    toplam += matris[m, n];
                }
            }

            Console.Write(toplam);

            Console.ReadKey();
        }
    }
}
