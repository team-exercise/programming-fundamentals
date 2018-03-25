using System;

namespace Problem_3._Miles_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            double Miles = double.Parse(Console.ReadLine());
            double Kilometers = Miles * 1.60934;

            Console.WriteLine($"{Kilometers:f2}");
        }
    }
}
