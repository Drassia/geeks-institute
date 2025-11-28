using System;

class Program
{
    static void SayHello(string name)
    {
        Console.WriteLine("Hello, " + name + "!");
    }
    static void Main(string[] args)
    {
        SayHello("Hassan");
        SayHello("Zakaria");
        SayHello("Issam");
    }
}