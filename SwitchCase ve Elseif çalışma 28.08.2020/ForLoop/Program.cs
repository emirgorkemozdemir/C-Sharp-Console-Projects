using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayı;
            Console.Write("Faktöriyelini bulmak istediğiniz sayıyı giriniz: ");
            sayı =Convert.ToInt32( Console.ReadLine());

            int çarpım = 1;

            for (int i = 1; i <= sayı; i++)
            {
                çarpım = çarpım * i;
            }

            Console.WriteLine($"Faktöriyel: {çarpım}");


            Console.ReadKey();
        }
    }
}
