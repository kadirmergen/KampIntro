using System;

namespace RefVeOutKullanımı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            int number1 = 20;
            int number2 = 100;
            var result2=Add3(ref number1,number2);

            Console.WriteLine(number1);
            
            Console.WriteLine(result2);
            Console.ReadLine();
            
        }
       
        static int Add3(ref int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }
    }
}
