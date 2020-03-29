using System;
using Xunit;
using Zoo.Classes;

namespace ZooTests
{
    public class ZooTest
    {
        [Fact]
        public void FishCanProveInheritedEatBehavior()
        {
            Fish newFish = new Fish("Nemo", false, 5);

            string expected = "Nemo is eating... all of the fish flakes!";

            Assert.Equal(expected, newFish.Eat());
        }

        [Fact]
        public void CrowCanProveInheritedFlyBehavior()
        {
            Crow newCrow = new Crow("Poe", 17, "black");

            string expected = "Poe flies with a Murder...";

            Assert.Equal(expected, newCrow.Fly());
        }

        [Fact]
        public void OwlCanProveInheritedPoopBehavior()
        {
            Owl newOwl = new Owl("Hedwig", 24);

            string expected = "Hedwig is both pooping, and regurgitating pellets. Gross!";

            Assert.Equal(expected, newOwl.Poop());
        }
    }
}
