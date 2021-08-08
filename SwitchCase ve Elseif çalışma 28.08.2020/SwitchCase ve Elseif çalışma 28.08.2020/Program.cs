using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase_ve_Elseif_çalışma_28._08._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            int keynum = -1;

            Console.WriteLine("Hangi aya ait olduğunu öğrenmek istediğiniz sayıyı giriniz: ");

            keynum = Convert.ToInt32(Console.ReadLine());

            switch (keynum)
            {
                case 1 : Console.WriteLine("Ay Ocak");
                    break;

                case 2: Console.WriteLine("Ay Şubat");
                    break;

                case 3:
                    Console.WriteLine("Ay Mart");
                    break;

                case 4:
                    Console.WriteLine("Ay Nisan");
                    break;

                case 5:
                    Console.WriteLine("Ay Mayıs");
                    break;

                case 6:
                    Console.WriteLine("Ay Haziran");
                    break;

                case 7:
                    Console.WriteLine("Ay Temmuz");
                    break;

                case 8:
                    Console.WriteLine("Ay Ağustos");
                    break;

                case 9:
                    Console.WriteLine("Ay Eylül");
                    break;

                case 10:
                    Console.WriteLine("Ay Ekim");
                    break;

                case 11:
                    Console.WriteLine("Ay Kasım");
                    break;

                case 12:
                    Console.WriteLine("Ay Aralık");
                    break;

            }

            Console.ReadLine();

        }
    }
}
