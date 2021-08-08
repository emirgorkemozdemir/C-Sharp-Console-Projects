using System;

namespace Name_control_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            string isim;

            Console.Write("İsim giriniz : ");

            isim = Console.ReadLine();


            if (isim == "emir") 
            {
                Console.Write("İsim doğru");
            }
            else
            {
                Console.Write("İsim hatalı");
            }


            Console.ReadKey();
        }
    }
}
