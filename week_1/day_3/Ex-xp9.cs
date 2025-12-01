using System;
using System.Collections.Generic;
using System.Linq;

class Cat
{
    public string catName;
    public int catAge;

    public Cat(string catName, int catAge)
    {
        this.catName = catName;
        this.catAge = catAge;
    }
}

class Program
{
    static void Main()
    {
        // Instantiate three Cat objects
        Cat cat1 = new Cat("Whiskers", 5);
        Cat cat2 = new Cat("Fluffy", 8);
        Cat cat3 = new Cat("Shadow", 3);

        // Find the oldest cat
        Cat oldestCat = FindOldestCat(new List<Cat> { cat1, cat2, cat3 });

        // Print the result
        Console.WriteLine($"The oldest cat is {oldestCat.catName}, and is {oldestCat.catAge} years old.");
    }

    static Cat FindOldestCat(List<Cat> cats)
    {
        return cats.OrderByDescending(c => c.catAge).First();
    }
}