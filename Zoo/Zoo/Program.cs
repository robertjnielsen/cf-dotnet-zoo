using System;
using Zoo.Classes;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Fish newFish = new Fish("Nemo", false, 4);
            Crow newCrow = new Crow("Poe", 14, "black");
            Owl newOwl = new Owl("Hedwig", 24);
            Leopard newLeopard = new Leopard("Treecat", 11, true);
            Lion newLion = new Lion("Alex", 16);
            Hound newHound = new Hound("Sam", 10);
            Labrador newLab = new Labrador("Bo", 12);

            Console.WriteLine(newFish.Swim());

            Console.WriteLine(newCrow.Fly());

            Console.WriteLine(newOwl.Sleep());

            Console.WriteLine(newLeopard.PetHuman());

            Console.WriteLine(newLion.Purr());

            Console.WriteLine(newHound.Poop());

            Console.WriteLine(newLab.Bark());
        }
    }
}
