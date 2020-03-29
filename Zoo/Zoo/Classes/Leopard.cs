using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    class Leopard : Feline
    {
        /// <summary>
        /// Determines if the Leopard object is a Snow Leopard.
        /// </summary>
        public bool IsSnowLeopard { get; set; }

        /// <summary>
        /// Constructor method to instantiate a new Leopard object.
        /// </summary>
        /// <param name="name">The name of the Leopard object.</param>
        /// <param name="lifeSpan">The lifespan of the Leopard object.</param>
        /// <param name="isSnowLeopard">Is the Leopard object a Snow Leopard?</param>
        public Leopard(string name, int lifeSpan, bool isSnowLeopard)
        {
            this.Name = name;
            this.Lifespan = lifeSpan;
            this.IsSnowLeopard = isSnowLeopard;
        }

        /// <summary>
        /// Tells the Leopard object to climb.
        /// </summary>
        /// <returns>Returns a string about the Leopard object climbing.</returns>
        public override string Climb()
        {
            return $"{this.Name} climbs trees just for the hell of it...";
        }

        /// <summary>
        /// Tells the Leopard object to purr.
        /// </summary>
        /// <returns>Returns a string about the Leopard object purring.</returns>
        public override string Purr()
        {
            return $"{this.Name} is purring from above you...";
        }

        /// <summary>
        /// Tells the Leopard object to eat.
        /// </summary>
        /// <returns>Returns a string about the Leopard object eating.</returns>
        public override string Eat()
        {
            return $"{base.Eat()} a bag of oranges..?";
        }
    }
}
