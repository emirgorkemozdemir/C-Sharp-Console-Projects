using System;

namespace Calculating_Exam_Average_Double
{
    class Program
    {
        static void Main(string[] args)
        {
            double exam1, exam2, project, average;

            Console.WriteLine("Enter Exam 1 : ");

            exam1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Exam 2 : ");

            exam2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Project : ");

            project = Convert.ToDouble(Console.ReadLine());

            average = (exam1 + exam2 + project) / 3;

            Console.WriteLine("Your average is : " + average);

            Console.ReadKey();





        }
    }
}
