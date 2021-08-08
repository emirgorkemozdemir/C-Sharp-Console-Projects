using System;

namespace Sorting_Array
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] sayılar = new int[10];

            for (int i = 0; i <10; i++)
            {
                Console.Write(i + 1 + ". Sayıyı Giriniz: ");

                sayılar[i] = Convert.ToInt32(Console.ReadLine());
                 

            }

            Array.Sort(sayılar);

            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine(sayılar[i]);
                

            }
            
            Console.Read();


        }
    }
}
