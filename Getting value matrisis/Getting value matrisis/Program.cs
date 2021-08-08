using System;

namespace Getting_value_matrisis
{
    class Program
    {
        static void Main(string[] args)
        {
            int satır, sütun;

            Console.Write("Satır sayısı giriniz : ");
            satır = Convert.ToInt16(Console.ReadLine());

            Console.Write("Sütun sayısı giriniz : ");
            sütun = Convert.ToInt16(Console.ReadLine());

            int[,] matris = new int[satır, sütun];

            for (int i = 0; i < satır; i++)
            {
                for (int k = 0; k < sütun; k++)
                {
                    Console.Write("Matrisin "+(i+1)+".satırını ve "+(k+1)+".sütununu giriniz : ");
                    matris[i, k] = Convert.ToInt32(Console.ReadLine());

                }
            }

            for (int e = 0; e < satır; e++)
            {
                Console.WriteLine();
                for (int a = 0; a < sütun; a++)
                {
                    Console.Write(matris[e, a]+"");

                }
            }

            Console.Read();



        }
    }
}
