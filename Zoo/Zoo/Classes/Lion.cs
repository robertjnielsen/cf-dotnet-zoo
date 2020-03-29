using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public class Lion : Feline
    {
        /// <summary>
        /// Determines if the Lion object is the KingOfTheJungle.
        /// </summary>
        public bool KingOfTheJungle { get; set; }

        /// <summary>
        /// Constructor method to initiate a new Lion object.
        /// </summary>
        /// <param name="name">The name of the Lion object.</param>
        /// <param name="lifeSpan">The lifespan of the Lion object.</param>
        public Lion(string name, int lifeSpan)
        {
            this.Name = name;
            this.Lifespan = lifeSpan;
            this.KingOfTheJungle = true;
        }

        /// <summary>
        /// Tells the Lion object to climb.
        /// </summary>
        /// <returns>Returns a string about the Lion object climbing.</returns>
        public override string Climb()
        {
            return $"{this.Name} does not like to climb...";
        }

        /// <summary>
        /// Tells the Lion object to purr.
        /// </summary>
        /// <returns>Returns a string about the Lion object purring.</returns>
        public override string Purr()
        {
            return $"{this.Name} purrs with a calm ferocity...";
        }

        /// <summary>
        /// Tells the Lion object to eat.
        /// </summary>
        /// <returns>Returns a string about the Lion object eating.</returns>
        public override string Eat()
        {
            return $"{base.Eat()} a chunk of Squarble meat!";
        }
    }
}
