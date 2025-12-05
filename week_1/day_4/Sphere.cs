using System;
using System.Collections.Generic;

namespace SphereDemo
{
    public class Sphere : IComparable<Sphere>
    {
        public double Radius { get; }

        public double Volume => 4.0 / 3.0 * Math.PI * Math.Pow(Radius, 3);
        public double SurfaceArea => 4.0 * Math.PI * Math.Pow(Radius, 2);

        public Sphere(double radius)
        {
            if (radius < 0)
                throw new ArgumentOutOfRangeException(nameof(radius), "Radius must be non‑negative.");
            Radius = radius;
        }

        public override string ToString()
        {
            return $"Sphere: Radius = {Radius:F2}, Volume = {Volume:F2}, SurfaceArea = {SurfaceArea:F2}";
        }

        public static Sphere operator +(Sphere a, Sphere b)
        {
            if (a is null || b is null)
                throw new ArgumentNullException();
            return new Sphere(a.Radius + b.Radius);
        }

        public static bool operator >(Sphere a, Sphere b)
        {
            if (a is null || b is null)
                throw new ArgumentNullException();
            return a.Volume > b.Volume;
        }

        public static bool operator <(Sphere a, Sphere b)
        {
            if (a is null || b is null)
                throw new ArgumentNullException();
            return a.Volume < b.Volume;
        }

        public static bool operator ==(Sphere a, Sphere b)
        {
            if (ReferenceEquals(a, b)) return true;
            if (a is null || b is null) return false;
            return a.Radius == b.Radius;
        }

        public static bool operator !=(Sphere a, Sphere b) => !(a == b);

        public override bool Equals(object obj)
        {
            return obj is Sphere s && this == s;
        }

        public override int GetHashCode()
        {
            return Radius.GetHashCode();
        }

        public int CompareTo(Sphere other)
        {
            if (other is null) return 1;
            return Radius.CompareTo(other.Radius); // or Volume.CompareTo(other.Volume)
        }
    }

    class Program
    {
        static void Main()
        {
            var s1 = new Sphere(2);
            var s2 = new Sphere(3);

            Console.WriteLine("Spheres:");
            Console.WriteLine(s1);
            Console.WriteLine(s2);

            var s3 = s1 + s2;
            Console.WriteLine("\nAdded sphere (s1 + s2):");
            Console.WriteLine(s3);

            Console.WriteLine($"\nIs s2 bigger than s1 (by volume)? {s2 > s1}");
            Console.WriteLine($"Do s1 and s2 have equal radius? {s1 == s2}");

            var list = new List<Sphere> { s1, s2, s3 };
            list.Sort(); // uses IComparable<Sphere>, sorts by radius

            Console.WriteLine("\nSorted spheres by radius:");
            foreach (var s in list)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}