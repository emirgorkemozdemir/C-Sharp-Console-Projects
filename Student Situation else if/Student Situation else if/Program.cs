using System;

namespace Student_Situation_else_if
{
    class Program
    {
        static void Main(string[] args)
        {
            int exam1, exam2, average;

            Console.Write("Enter Exam 1 : ");

            exam1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Exam 2 : ");

            exam2 = Convert.ToInt32(Console.ReadLine());

            average = (exam1 + exam2) / 2;

            Console.WriteLine("Your Average is : " + average);

            if (average > 0 && average < 30)
            {
                Console.Write("Durumun vasat");
            }
            else if (average >= 30 && average < 50)
            {
                Console.Write("Durumun kötü");
            }
            else if (average >= 50 && average < 75)
            {
                Console.Write("Durumun orta ");
            }
            else if (average >= 75 && average < 100)
            {
                Console.Write("Durumun çoh iyi");
            }
            else if (average > 100)
            {
                Console.Write("Sayıları yanlış girdin");
            }
            else if (average < 0)
            {
                Console.Write("Sayıları yanlış girdin");
            }

            Console.ReadKey();

        }
    }
}
