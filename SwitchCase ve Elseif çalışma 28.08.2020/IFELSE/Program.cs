using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFELSE
{
    class Program
    {
        static void Main(string[] args)
        {
            string password;

            Console.WriteLine("Şifrenizi giriniz :");

            password = Console.ReadLine();

            if (password=="emir")
            {
                Console.Write("Giriş Başarılı");
            }
            else
            {
                Console.Write("Giriş Başarısız");
            }

            Console.ReadKey();
        }
    }
}
