using System;

namespace String_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //concat metodu stringleri birleştirir
            string x = "Emir ";
            string y = "Görkem ";
            string z = "Özdemir";
            string name = string.Concat(x, y, z);
            Console.WriteLine(name);

            //compare metodu iki stringi karşılaştırır,ilki büyükse  1 ,eşitlerse 0 ,ikinci büyükse -1 değerini alır
            int t = String.Compare(x, y);
            Console.WriteLine(t);

            //lenght metodu stringin karakter olara uzunluğunu bulur
            int stringlenght = z.Length;
            Console.WriteLine(stringlenght);

            // indexof stringin içinde ifade arayıp başlama sırasını verir,yoksa -1 verir
            int tryindexof = z.IndexOf("demir");
            Console.WriteLine(tryindexof);

            // lastindexof indexof un aynısıdır fakat aramaya tersten başlar ve ona göre index sayısı verir

            // indexofany stringin içinde istenen ifadeyi arar,yoksa -1 verir 
            char[] indexofanytry = { 'm', 'r' };
            int l= z.IndexOfAny(indexofanytry);
            Console.WriteLine(l);

            // lastindexofany , indexofany nin aynısıdır sadece tersten başlatıp ona göre değer verir

            //startswith metodu stringin başladığı ifadeyi kontrol eder, endswith metodu bittiği ifadeyi kontrol eder 
            // ikisi de bool olarak çıktı verir , true veya false !
            bool trystartswith = z.StartsWith("Öz");
            Console.WriteLine(trystartswith);

            //trim metodu baştaki ve sondaki boşlukları veya karakterleri silmeye yarar

            //ToUpper metodu tüm harfleri büyütür

            //ToLower metodu tüm harfleri küçültür

            //Remove metodu belirtilen değer de dahil olmaz üzere sonraki tüm karakterleri siler
            string newz = z.Remove(2);
            Console.WriteLine(newz);

            //Insert metodu belirtilen ifadeden itibaren başka bir string ekler 
            string newx = x.Insert(0, "Selin");
            Console.WriteLine(newx);

            // Replace metodu stringteki bir değeri  değiştirir string b = a.Replace(‘değiştirilecek ifade’, ‘yeni ifade’ );
            string newy = y.Replace('r', 't');
            Console.WriteLine(newy);

            //substring metodu stringin belirtilen yerden sonraki kısmını alır
            string newnewz = z.Substring(2);
            Console.WriteLine(newnewz);

            //split metodu ifadenin içindeki bir karaktere göre stringi ayırır
            string website = "www.emirozdemir.com";
            string [] seperatedwebsite = website.Split('.');
            foreach (var item in seperatedwebsite)
            {
                Console.WriteLine(item);
            }

            //join metodu splitin tersi gibi düşünülebilir , bir karakter eklemek için kullanılır

            //copy metodu string değeri kopyalar

            //IsNullOrEmpty metodu stringin içi boş mu kontrol eder bool değer döndürür

            //Contains metodu stringin içinde bir karakterin olup olmadığını kontrol ede , bool değer döndürür
            bool controlcontain = z.Contains("demir");
            Console.WriteLine(controlcontain);




            Console.Read();
        }
    }
}
