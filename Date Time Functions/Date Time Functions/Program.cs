using System;

namespace Date_Time_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime zaman1 = DateTime.Now;

            Console.WriteLine("Zaman : {0}", zaman1);

            int gün = zaman1.Day;
            int ay = zaman1.Month;
            int yıl = zaman1.Year;

            Console.WriteLine("Gün : {0}", gün);
            Console.WriteLine("Ay : {0}", ay);
            Console.WriteLine("Yıl : {0}", yıl);

            DateTime zaman2 = DateTime.Now;

            Console.WriteLine("Tarih Formatı 1 : {0:d}", zaman2); //Kısa tarih formatı
            Console.WriteLine("Tarih Formatı 2 : {0:D}", zaman2);
            Console.WriteLine("Tarih Formatı 3 : {0:f}", zaman2);
            Console.WriteLine("Tarih Formatı 4 : {0:F}", zaman2);
            Console.WriteLine("Tarih Formatı 5 : {0:g}", zaman2);
            Console.WriteLine("Tarih Formatı 6 : {0:G}", zaman2);
            Console.WriteLine("Tarih Formatı 7 : {0:r}", zaman2);
            Console.WriteLine("Tarih Formatı 8 : {0:s}", zaman2);
            Console.WriteLine("Sadece Saat 1 : {0:t}", zaman2);
            Console.WriteLine("Sadece Saat 2 : {0:T}", zaman2);
            Console.WriteLine("Ay : {0:m}", zaman2);
            Console.WriteLine("Yıl ve Ay : {0:y}", zaman2);
            

            Console.ReadKey();
        }
    }
}
