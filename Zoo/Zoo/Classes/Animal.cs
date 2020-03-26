using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Animal
    {
        /// <summary>
        /// The name of the Animal.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The lifespan of the Animal in years.
        /// </summary>
        public int Lifespan { get; set; }

        /// <summary>
        /// Whether or not the Animal is nocturnal.
        /// </summary>
        public virtual bool Nocturnal { get; set; } = false;

        /// <summary>
        /// Tells the Animal object to eat.
        /// </summary>
        /// <returns>Returns a string about the Animal eating.</returns>
        public virtual string Eat()
        {
            return $"{this.Name} is eating...";
        }
    }
}
