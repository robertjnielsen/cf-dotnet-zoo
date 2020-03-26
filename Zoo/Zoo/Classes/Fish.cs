using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public class Fish : Animal
    {
        /// <summary>
        /// Determines if the Fish is a freshwater Fish or not.
        /// </summary>
        public bool Freshwater { get; set; }

        /// <summary>
        /// Constructor method to instantiate a new Fish object.
        /// </summary>
        /// <param name="name">The name of the new Fish object.</param>
        /// <param name="freshWater">Whether the new Fish object is a freshwater Fish or not.</param>
        /// <param name="lifeSpan">The lifespan of the new Fish object in years.</param>
        public Fish(string name, bool freshWater, int lifeSpan)
        {
            this.Name = name;
            this.Freshwater = freshWater;
            this.Lifespan = lifeSpan;
        }

        /// <summary>
        /// Tells the Fish object to swim.
        /// </summary>
        /// <returns>Returns a string about the Fish swimming.</returns>
        public string Swim()
        {
            return $"{this.Name} is just swimming along.";
        }

        /// <summary>
        /// Tell the Fish object to eat.
        /// </summary>
        /// <returns>Returns a string about the Fish eating.</returns>
        public override string Eat()
        {
            return $"{base.Eat()} all of the fish flakes!";
        }
    }
}
