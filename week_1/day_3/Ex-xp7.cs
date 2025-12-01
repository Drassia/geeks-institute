using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a season (winter, spring, summer, autumn) or a month number (1-12): ");
        string input = Console.ReadLine();

        string season;
        if (int.TryParse(input, out int month))
        {
            season = GetSeasonFromMonth(month);
        }
        else
        {
            season = input.ToLower();
        }

        double temperature = GetRandomTemp(season);
        Console.WriteLine($"The temperature is {temperature:F1}°C.");

        // Give advice based on temperature
        if (temperature < 0)
        {
            Console.WriteLine("It's freezing! Wear warm clothes.");
        }
        else if (temperature < 15)
        {
            Console.WriteLine("It's cold. Don't forget a jacket.");
        }
        else if (temperature < 25)
        {
            Console.WriteLine("It's pleasant. Enjoy the weather.");
        }
        else
        {
            Console.WriteLine("It's hot. Stay hydrated and wear light clothes.");
        }
    }

    static string GetSeasonFromMonth(int month)
    {
        switch (month)
        {
            case 12:
            case 1:
            case 2:
                return "winter";
            case 3:
            case 4:
            case 5:
                return "spring";
            case 6:
            case 7:
            case 8:
                return "summer";
            case 9:
            case 10:
            case 11:
                return "autumn";
            default:
                return "unknown";
        }
    }

    static double GetRandomTemp(string season)
    {
        Random rnd = new Random();
        double min = -10, max = 40;

        switch (season.ToLower())
        {
            case "winter":
                min = -10; max = 16;
                break;
            case "spring":
            case "autumn":
                min = 0; max = 23;
                break;
            case "summer":
                min = 16; max = 40;
                break;
            default:
                min = -10; max = 40;
                break;
        }

        return min + (rnd.NextDouble() * (max - min));
    }
}