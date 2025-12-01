using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> family = new Dictionary<string, int>();
        string name;
        int age;
        int totalCost = 0;

        Console.WriteLine("Enter names and ages (type 'done' to finish):");

        while (true)
        {
            Console.Write("Name: ");
            name = Console.ReadLine();
            if (name.ToLower() == "done") break;

            Console.Write("Age: ");
            if (int.TryParse(Console.ReadLine(), out age))
            {
                family[name] = age;
            }
            else
            {
                Console.WriteLine("Invalid age. Please enter a number.");
            }
        }

        foreach (var member in family)
        {
            string memberName = member.Key;
            int memberAge = member.Value;
            int price = 0;

            if (memberAge < 3)
                price = 0;
            else if (memberAge >= 3 && memberAge <= 12)
                price = 10;
            else
                price = 15;

            Console.WriteLine($"{memberName} pays ${price}");
            totalCost += price;
        }

        Console.WriteLine($"Total cost for the family: ${totalCost}");
    }
}