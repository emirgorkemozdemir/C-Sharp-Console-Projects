using System;

namespace Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int kenar, alan, çevre;

            Console.WriteLine("Bir kenar uzunluğunu giriniz : ");

            kenar = Convert.ToInt32(Console.ReadLine());

            alan = kenar * kenar;

            çevre = kenar * 4;

            Console.WriteLine("Alan : " + alan);

            Console.WriteLine("Çevre : " + çevre);

            Console.ReadKey();
        }
    }
}
