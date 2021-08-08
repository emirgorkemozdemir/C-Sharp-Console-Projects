using System;

namespace Summing_4x4_2_matrisis
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matris1 = { { 10, 15, 25, 36 }, { 14, 58, 56, 33 }, { 55, 222, 11, 86 }, { 232, 44, 78, 65 } };

            int[,] matris2 = { { 1056, 215, 5, 56 }, { 44, 22, 34, 7}, { 55, 222, 11, 86 }, { 4444, 5, 312, 635 } };

            int[,] toplam = new int [4,4];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    toplam[i, j] = (matris1[i, j] + matris2[i, j]);

                }


            }

            for (int k = 0; k < 4; k++)
            {
                Console.WriteLine();
                for (int m = 0; m < 4; m++)
                {
                    Console.WriteLine();
                    Console.Write(toplam[k, m]);
                }
            }

            Console.Read();


        }
    }
}
