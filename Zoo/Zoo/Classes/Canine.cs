using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Canine : Mammal
    {
        /// <summary>
        /// Determines that Canine objects are domesticated.
        /// </summary>
        public override bool IsDomesticated { get => base.IsDomesticated; set => base.IsDomesticated = true; }

        /// <summary>
        /// Determines if Canine objects are lazy or not.
        /// </summary>
        public abstract bool IsLazy { get; set; }

        /// <summary>
        /// Tells the Canine object to bark.
        /// </summary>
        /// <returns>Returns a string about the Canine object barking.</returns>
        public abstract string Bark();

        /// <summary>
        /// Tells the Canine object to fetch.
        /// </summary>
        /// <returns>Returns a string about the Canine object fetching.</returns>
        public abstract string Fetch();

        /// <summary>
        /// Tells the Canine object to pet you.
        /// </summary>
        /// <returns>Returns a string about the Canine object petting you.</returns>
        public override string PetHuman()
        {
            return $"{base.PetHuman()} with all the love of Man's Best Friend!";
        }
    }
}
