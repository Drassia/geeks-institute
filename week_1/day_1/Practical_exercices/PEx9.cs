using System;

class Program
{
    static void Main(string[] args)
    {
        int a = 4;
        int b = 8;
        int temp;

        temp = a;
        a = b;
        b = temp;

        Console.WriteLine("a: " + a);
        Console.WriteLine("b: " + b);
    }
}