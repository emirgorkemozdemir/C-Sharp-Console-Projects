using System;

namespace Print_cities_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] şehirler = new string[3];

            for (int i=0; i<3;i++)
            {
                Console.Write("Şehir : ");
                şehirler[i] = Console.ReadLine();

            }

            for(int i = 0; i<3; i++)
            {
                Console.WriteLine(şehirler[i]);
            }

            Console.Read();


        }
    }
}
