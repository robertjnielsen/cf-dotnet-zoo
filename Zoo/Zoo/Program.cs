using System;
using Zoo.Classes;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine();

            Fish guppy = new Fish("Bubbles", true, 2);

            Console.WriteLine($"{guppy.Eat()}");
            Console.WriteLine($"{guppy.Swim()}");
        }
    }
}
