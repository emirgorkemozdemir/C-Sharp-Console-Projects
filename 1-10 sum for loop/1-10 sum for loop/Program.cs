﻿using System;

namespace _1_10_sum_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int toplam = 0;

            for (i=1;i<=10;i++)
            {
                toplam = toplam + i;
            }

            Console.Write(toplam);

            Console.Read();
        }
    }
}
