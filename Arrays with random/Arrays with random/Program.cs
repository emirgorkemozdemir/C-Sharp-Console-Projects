using System;

namespace Arrays_with_random
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rastgele = new Random();

            string[] şehirler = { "Gaziantep", "Mersin", "İstanbul" };

            int a;

            a = rastgele.Next(0, şehirler.Length);

            Console.WriteLine(a+1);

            Console.Write(şehirler[a]);

            Console.Read();
                



        }
    }
}
