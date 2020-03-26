using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Mammal : Animal
    {
        /// <summary>
        /// Determines whether the Mammal object is domesticated or not.
        /// </summary>
        public virtual bool IsDomesticated { get; set; } = false;

        /// <summary>
        /// Tells the Mammal object to pet you.
        /// </summary>
        /// <returns>Returns a string about the Mammal object petting you.</returns>
        public virtual string PetHuman()
        {
            return $"{this.Name} pets you...";
        }
    }
}
