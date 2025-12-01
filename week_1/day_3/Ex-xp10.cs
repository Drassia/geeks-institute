using System;

class Dog
{
    public string name;
    public int height;

    public Dog(string name, int height)
    {
        this.name = name;
        this.height = height;
    }

    public void Bark()
    {
        Console.WriteLine($"{name} goes woof!");
    }

    public void Jump()
    {
        int jumpHeight = height * 2;
        Console.WriteLine($"{name} jumps {jumpHeight} cm high!");
    }
}

class Program
{
    static void Main()
    {
        // Create davidsDog and call Bark() and Jump()
        Dog davidsDog = new Dog("Rex", 50);
        davidsDog.Bark();
        davidsDog.Jump();

        // Create sarahsDog and call Bark() and Jump()
        Dog sarahsDog = new Dog("Teacup", 20);
        sarahsDog.Bark();
        sarahsDog.Jump();

        // Check which dog is taller and print its name
        if (davidsDog.height > sarahsDog.height)
        {
            Console.WriteLine($"{davidsDog.name} is taller.");
        }
        else
        {
            Console.WriteLine($"{sarahsDog.name} is taller.");
        }
    }
}