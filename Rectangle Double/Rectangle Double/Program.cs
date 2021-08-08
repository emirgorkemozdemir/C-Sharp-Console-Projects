using System;

namespace Rectangle_Double
{
    class Program
    {
        static void Main(string[] args)
        {
            double kk, uk, alan, çevre;

            Console.WriteLine("Kısa kenarı giriniz : ");

            kk = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" Uzun kenarı giriniz : ");

            uk = Convert.ToDouble(Console.ReadLine());

            alan = uk * kk;

            çevre = (uk + kk) * 2;

            Console.WriteLine(" Çevre : " + çevre);

            Console.WriteLine(" Alan : " + alan);

            Console.ReadKey();
                

              




        }
    }
}
