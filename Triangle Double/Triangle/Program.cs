using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double kenar, alan, çevre;

            Console.WriteLine(" Eşkenar üçgenin bir kenarını giriniz : ");

            kenar = Convert.ToDouble(Console.ReadLine());

            alan = kenar*kenar * 3*1/2 /4;
                
            çevre = (kenar * 3);

            Console.WriteLine("Alan : " + alan);

            Console.WriteLine("Çevre : " + çevre);

            Console.ReadKey();
        }
    }
}
