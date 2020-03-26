using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public class Labrador : Canine
    {
        /// <summary>
        /// Determines that the Labrador object is not lazy.
        /// </summary>
        public override bool IsLazy { get; set; } = false;

        /// <summary>
        /// Constructor method to instantiate a new Labrador object.
        /// </summary>
        /// <param name="name">The name of the new Labrador object.</param>
        /// <param name="lifeSpan">The lifespan of the new Labrador object in years.</param>
        public Labrador(string name, int lifeSpan)
        {
            this.Name = name;
            this.Lifespan = lifeSpan;
        }

        /// <summary>
        /// Tells the Labrador object to bark.
        /// </summary>
        /// <returns>Returns a string about the Labrador object barking.</returns>
        public override string Bark()
        {
            return $"{this.Name} barks excitedly for the ball!";
        }

        /// <summary>
        /// Tells the Labrador object to fetch.
        /// </summary>
        /// <returns>Returns a string about the Labrador object fetching.</returns>
        public override string Fetch()
        {
            return $"{this.Name} fetches the ball with so fast! Much wow, heckin amaze...";
        }

        /// <summary>
        /// Tells the Labrador object to eat.
        /// </summary>
        /// <returns>Returns a string about the Labrador object eating.</returns>
        public override string Eat()
        {
            return $"{base.Eat()} too fast to even taste the food!";
        }
    }
}
