using System;
using System.Linq;
using System.Collections.Generic;
namespace PhoneShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfPhones = Console.ReadLine().Split(", ").ToList();
            string input = Console.ReadLine();
            while (input != "End")
            {
                var command = input.Split(" - ").ToList();
                string tokens = command[0];

                switch (tokens)
                {
                    case "Add":
                        if (!listOfPhones.Contains(command[1]))
                        {
                            listOfPhones.Add(command[1]);
                        }
                        break;
                    case "Remove":
                        if (listOfPhones.Contains(command[1]))
                        {
                            listOfPhones.Remove(command[1]);
                        }
                        break;
                    case "Bonus phone":
                        var phones = command[1].Split(":").ToList();
                        if (listOfPhones.Contains(phones[0]))
                        {
                            int index = listOfPhones.IndexOf(phones[0]);
                            listOfPhones.Insert(index + 1, phones[1]);
                        }
                        break;
                    case "Last":
                        if (listOfPhones.Contains(command[1]))
                        {
                            listOfPhones.Remove(command[1]);
                            listOfPhones.Add(command[1]);
                        }
                        break;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", listOfPhones));
        }
    }
}
//SamsungA50, MotorolaG5, IphoneSE
//Add - Iphone10
//Remove - IphoneSE
//End

//HuaweiP20, XiaomiNote
//Remove - Samsung
//Bonus phone - XiaomiNote:Iphone5
//End

//SamsungA50, MotorolaG5, HuaweiP10
//Last - SamsungA50
//Add - MotorolaG5
//End