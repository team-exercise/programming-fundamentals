using System;

namespace Problem_4._Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            string ProductName = Console.ReadLine();
            int ProductVolume = int.Parse(Console.ReadLine()); //ml
            int ProductEnergyContentPer100ml = int.Parse(Console.ReadLine()); //kcal
            int ProductSugarContentPer100ml = int.Parse(Console.ReadLine()); //g

            double ProductEnergyContentPer1ml = ProductEnergyContentPer100ml / 100.0;
            double ProductSugarContentPer1ml = ProductSugarContentPer100ml / 100.0;

            double ProductEnergyContent = ProductVolume * ProductEnergyContentPer1ml;
            double ProductSugarContent = ProductVolume * ProductSugarContentPer1ml;

            Console.WriteLine($"{ProductVolume}ml {ProductName}:");
            Console.WriteLine($"{ProductEnergyContent}kcal, {ProductSugarContent}g sugars");


        }
    }
}
