using System;

namespace TheHuntingGames
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int numPlayers = int.Parse(Console.ReadLine());
            double groupEnergy = double.Parse(Console.ReadLine());
            double waterForOne = double.Parse(Console.ReadLine());
            double foodForOne = double.Parse(Console.ReadLine());
            double sumWater = numPlayers * waterForOne * N;
            double sumFood = numPlayers * foodForOne * N;
            int daysCount = 0;
            for (int i = 0; i < N; i++)
            {
                double energyLoss = double.Parse(Console.ReadLine());
                groupEnergy = groupEnergy - energyLoss;
                daysCount++;
                if (daysCount % 2 == 0)
                {
                    groupEnergy = groupEnergy + groupEnergy * 0.05;
                    sumWater = sumWater - sumWater * 0.3;
                }
                if (daysCount % 3 == 0)
                {
                    sumFood = sumFood - (sumFood / numPlayers);
                    groupEnergy = groupEnergy + groupEnergy * 0.1;
                }
                if (groupEnergy <= 0)
                {
                    break;
                }
            }
            if (groupEnergy > 0)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {groupEnergy:f2} energy!");
            }
            else
            {
                Console.WriteLine($"You will run out of energy. You will be left with {sumFood:f2} food and {sumWater:f2} water.");
            }
        }
    }
}
//10
//7
//5035.5
//11.3
//7.2
//942.3
//500.57
//520.68
//540.87
//505.99
//630.3
//784.20
//321.21
//456.8
//330



//12
//6
//4430
//9.8
//5.5
//620.3
//840.2
//960.1
//220
//340
//674
//365
//345.5
//212
//412.12
//258