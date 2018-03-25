using System;

namespace Problem_2._Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialising variables
            double RectangleWeight = double.Parse(Console.ReadLine());
            double RectangleHeight = double.Parse(Console.ReadLine());
            double RectangleArea = RectangleHeight * RectangleWeight;

            //Printing on the console
            Console.WriteLine($"{RectangleArea:f2}");
        }
    }
}
