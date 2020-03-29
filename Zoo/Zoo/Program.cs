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

            newFish.Swim();

            newCrow.Fly();

            newOwl.Sleep();

            newLeopard.PetHuman();

            newLion.Purr();

            newHound.Poop();

            newLab.Bark();
        }
    }
}
