using System;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";

            // şeklinde her kurs geldiğinde buraya eklemek yerine
            // biz array leri yani dizileri kullanırız.

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı",
                "Programlamaya başlangıç için temel kurs", "Java","Pyhton","C++" };
            
            for (int i=0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            //bir başka döngü yöntemi

            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
