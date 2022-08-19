using System;
using System.Linq;
using System.Collections.Generic;
namespace SpaceTravel
{
    class Program
    {
        static void Main(string[] args)
        {
            var route = Console.ReadLine().Split("||").ToList();
            double fuel = double.Parse(Console.ReadLine());
            double ammunition = double.Parse(Console.ReadLine());
            for (int i = 0; i < route.Count; i++)
            {
                string command = route[i];
                string[] tokens = command.Split(" ");
                switch (tokens[0])
                {
                    case "Travel":
                        int yearsTravelled = int.Parse(tokens[1]);
                        if (fuel > yearsTravelled)
                        {
                            Console.WriteLine($"The spaceship travelled {yearsTravelled} light-years.");
                            fuel = fuel - yearsTravelled;
                        }
                        else
                        {
                            Console.WriteLine("Mission failed.");
                            return;
                        }
                        break;
                    case "Enemy":
                        int enemyArmour = int.Parse(tokens[1]);
                        if (ammunition >= enemyArmour)
                        {
                            ammunition = ammunition - enemyArmour;
                            Console.WriteLine($"An enemy with {enemyArmour} armour is defeated.");
                        }
                        else if (ammunition < enemyArmour && fuel > enemyArmour * 2)
                        {
                            Console.WriteLine($"An enemy with {enemyArmour} armour is outmaneuvered.");
                        }
                        else
                        {
                            Console.WriteLine("Mission failed.");
                            return;
                        }
                        break;
                    case "Repair":
                        int numberOfAmmunitionAndFuel = int.Parse(tokens[1]);
                        ammunition = numberOfAmmunitionAndFuel * 2 + ammunition;
                        fuel = fuel + numberOfAmmunitionAndFuel;
                        Console.WriteLine($"Ammunitions added: {numberOfAmmunitionAndFuel * 2}.");
                        Console.WriteLine($"Fuel added: {numberOfAmmunitionAndFuel}.");
                        break;
                    case "Titan":
                        Console.WriteLine("You have reached Titan, all passengers are safe.");
                        return;
                }
            }
        }
    }
}
//Travel 10||Enemy 30||Repair 15||Titan
//50
//80


//Travel 20||Enemy 50||Enemy 50||Enemy 10||Repair 15||Enemy 50||Titan
//60
//100
//Travel 20||Enemy 150||Enemy 50||Enemy 10||Repair 15||Enemy 50||Titan
//60
//100