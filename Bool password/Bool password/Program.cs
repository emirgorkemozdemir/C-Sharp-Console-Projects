using System;

namespace Bool_password
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Şifreyi giriniz : ");

            int şifre;

            şifre = Convert.ToInt32(Console.ReadLine());

            bool durum = şifre == 123 ;

            Console.WriteLine("Şifre doğru mu {0}", durum);

            Console.ReadKey();


                





        }
    }
}
