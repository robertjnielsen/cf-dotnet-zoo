using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Bird : Animal
    {
        /// <summary>
        /// Determines if the Bird is social or not.
        /// </summary>
        public virtual bool Social { get; set; } = true;

        /// <summary>
        /// Tells the Bird object to fly.
        /// </summary>
        /// <returns>Returns a string about the Bird object flying.</returns>
        public abstract string Fly();
    }
}
