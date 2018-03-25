using System;

namespace Problem_1._Debit_Card_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int FirstInteger = int.Parse(Console.ReadLine());
            int SecondInteger = int.Parse(Console.ReadLine());
            int ThirdInteger = int.Parse(Console.ReadLine());
            int ForthInteger = int.Parse(Console.ReadLine());

            Console.WriteLine($"{FirstInteger:d4} {SecondInteger:d4} {ThirdInteger:d4} {ForthInteger:d4}");


        }
    }
}
