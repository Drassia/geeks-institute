using System;

class Program
{
    static void Main()
    {
        CompareNumbers(42); // Example call
        CompareNumbers(100);
        CompareNumbers(1);
    }

    static void CompareNumbers(int userNumber)
    {
        if (userNumber < 1 || userNumber > 100)
        {
            Console.WriteLine("Please enter a number between 1 and 100.");
            return;
        }

        Random random = new Random();
        int randomNumber = random.Next(1, 101); // Generates a number from 1 to 100

        if (userNumber == randomNumber)
        {
            Console.WriteLine("Success! The numbers match.");
        }
        else
        {
            Console.WriteLine($"Fail! Your number: {userNumber}, Random number: {randomNumber}");
        }
    }
}