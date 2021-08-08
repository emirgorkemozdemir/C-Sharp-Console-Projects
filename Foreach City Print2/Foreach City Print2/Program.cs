using System;

namespace Foreach_City_Print2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] şehirler = { "Gaziantep", "Mersin", "Ankara" };

            foreach (string x in şehirler)
            {
                Console.WriteLine(x);

                Console.WriteLine();
            }
            Console.Read();





        }
    }
}
