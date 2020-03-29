using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Feline : Mammal
    {
        /// <summary>
        /// Sets the Feline object as Nocturnal.
        /// </summary>
        public override bool Nocturnal { get; set; } = true;

        /// <summary>
        /// Tells the Feline object to Purr.
        /// </summary>
        /// <returns>Returns a string about the Feline object purring.</returns>
        public abstract string Purr();

        /// <summary>
        /// Tells the Feline object to Climb.
        /// </summary>
        /// <returns>Returns a string about the Feline object climbing.</returns>
        public abstract string Climb();

        /// <summary>
        /// Tells the Feline object to pet you.
        /// </summary>
        /// <returns>Returns a string about the Feline object petting you.</returns>
        public override string PetHuman()
        {
            return $"{base.PetHuman()} with a look of hunger in its eyes!";
        }
    }
}
