using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public class Hound : Canine
    {
        /// <summary>
        /// Determines that the Hound object is not lazy.
        /// </summary>
        public override bool IsLazy { get; set; } = true;

        /// <summary>
        /// Constructor method to instantiate a new Hound object.
        /// </summary>
        /// <param name="name">The name of the new Hound object.</param>
        /// <param name="lifeSpan">The lifespan of the new Hound object in years.</param>
        public Hound(string name, int lifeSpan)
        {
            this.Name = name;
            this.Lifespan = lifeSpan;
        }

        /// <summary>
        /// Tells the Hound object to bark.
        /// </summary>
        /// <returns>Returns a string about the Hound object barking.</returns>
        public override string Bark()
        {
            return $"{this.Name} barks in a whiny tone...";
        }

        /// <summary>
        /// Tells the Hound object to fetch.
        /// </summary>
        /// <returns>Returns a string about the Hound object fetching.</returns>
        public override string Fetch()
        {
            return $"{this.Name} watches the ball, but decides to just lay down...";
        }

        /// <summary>
        /// Tells the Hound object to eat.
        /// </summary>
        /// <returns>Returns a string about the Hound object eating.</returns>
        public override string Eat()
        {
            return $"{base.Eat()} but sooooo slooooowly...";
        }
    }
}
