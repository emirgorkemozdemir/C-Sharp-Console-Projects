using System;

namespace _3_students_exam1_exam_2_average_name_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[3];
            int[] sınav1 = new int[3];
            int[] sınav2= new int[3];
            int[] ortalama = new int[3];

            for (int i = 0; i<3; i++)
            {
                Console.Clear();

                Console.Write(i + 1 + ". Öğrencinin adı: ");

                isimler[i] = Console.ReadLine();

                Console.Write(i + 1 + ". Öğrencinin 1. sınavı : ");

                sınav1[i] = Convert.ToInt32(Console.ReadLine());

                Console.Write(i + 1 + ". Öğrencinin 2. sınavı : ");

                sınav2[i] = Convert.ToInt32(Console.ReadLine());

                ortalama[i] = (sınav1[i] + sınav2[i]) / 2;





            }

            Console.Write("Öğrenci  Sınav1  Sınav2  Ortalama");
            Console.WriteLine();

            for(int i = 0; i<3; i++)
            {


                Console.WriteLine("  " + isimler[i] + "  " + sınav1[i] + "  " + sınav2[i] + "  " + ortalama[i]);



            }

            Console.ReadKey();

        }
    }
}
