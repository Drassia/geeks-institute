using System;

class Program
{
    static void Main()
    {
        DescribeCity("Reykjavik");        // Output: Reykjavik is in Iceland.
        DescribeCity("Paris", "France");   // Output: Paris is in France.
        DescribeCity("Tokyo", "Japan");    // Output: Tokyo is in Japan.
        DescribeCity("New York");          // Output: New York is in Iceland.
    }

    static void DescribeCity(string city, string country = "Iceland")
    {
        Console.WriteLine($"{city} is in {country}.");
    }
}