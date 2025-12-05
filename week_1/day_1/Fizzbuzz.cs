using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number between 1 and 100: ");
        string input = Console.ReadLine();
        
        if (!int.TryParse(input, out int number) || number < 1 || number > 100)
        {
            Console.WriteLine("Invalid input. Please enter an integer between 1 and 100.");
            return;
        }

        if (number % 3 == 0 && number % 5 == 0)
        {
            Console.WriteLine("FizzBuzz");
        }
        else if (number % 3 == 0)
        {
            Console.WriteLine("Fizz");
        }
        else if (number % 5 == 0)
        {
            Console.WriteLine("Buzz");
        }
        else
        {
            Console.WriteLine(number);
        }
    }
}