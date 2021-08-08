using System;

namespace Switch_case_day_num
{
    class Program
    {
        static void Main(string[] args)
        {

            int sayı;
            Console.Write(" 1 ile 7 arasında bir sayı giriniz : ");
            sayı = Convert.ToInt16(Console.ReadLine());

            switch (sayı)
            {
                case 1: Console.Write("1. GÜN PAZARTESİ");
                    break;

                case 2: Console.Write("2. GÜN SALI");
                    break;

                case 3: Console.Write("3. GÜN ÇARŞAMBA");
                    break;

                case 4: Console.Write("4. GÜN PERŞEMBE");
                    break;

                case 5: Console.Write("5. GÜN CUMA");
                    break;

                case 6: Console.Write("6. GÜN CUMARTESİ");
                    break;

                case 7: Console.Write("7. GÜN PAZAR ");
                    break;












            }

            Console.ReadKey();



        }
    }
}
