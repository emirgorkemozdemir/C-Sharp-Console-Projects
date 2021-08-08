using System;

namespace Printing_2x2_Matris
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] matris1 = new int[2, 2];

            matris1[0, 0] = 55;
            matris1[0, 1] = 18;
            matris1[1, 0] = 888;
            matris1[1, 1] = 525;

            Console.WriteLine();
            for (int i = 0; i < 2; i++)
            {
                

                for (int j = 0; j < 2; j++)

                    Console.Write("{0} ", matris1[i, j]);
                Console.WriteLine();


            }

            Console.Read();






        }
    }
}
