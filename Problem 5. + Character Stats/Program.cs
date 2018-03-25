using System;

namespace Problem_5.___Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            string CharactarName = Console.ReadLine();
            int CurrentHealth = int.Parse(Console.ReadLine());
            int MaximumHealth = int.Parse(Console.ReadLine());
            int CurrentEnergy = int.Parse(Console.ReadLine());
            int MaximumEnergy = int.Parse(Console.ReadLine());

            string HealthBar = '|' + new string('|', CurrentHealth) + new string('.', MaximumHealth - CurrentHealth) + '|';
            string EnergyBar = '|' + new string('|', CurrentEnergy) + new string('.', MaximumEnergy - CurrentEnergy) + '|';

            Console.WriteLine($"Name: {CharactarName}");
            Console.WriteLine($"Health: {HealthBar}");
            Console.WriteLine($"Energy: {EnergyBar}");
        }
    }
}
