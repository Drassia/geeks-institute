using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter temperature in Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());
        double fahrenheit = celsius * 9.0 / 5.0 +32;
        Console.WriteLine("Temerature in Fahrenheit: " + fahrenheit);
    }
}