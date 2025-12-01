using System;

class Program
{
    static void Main()
    {
        // Make a large shirt with the default message
        MakeShirt();

        // Make a medium shirt with the default message
        MakeShirt("Medium");

        // Make a shirt of any size with a custom message
        MakeShirt("Small", "Hello World!");

        // Bonus: Use named arguments
        MakeShirt(text: "C# is awesome!", size: "Extra Large");
    }

    static void MakeShirt(string size = "Large", string text = "I love C#")
    {
        Console.WriteLine($"The size of the shirt is {size} and the text is '{text}'.");
    }
}
