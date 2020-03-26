using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public class Crow : Bird
    {
        /// <summary>
        /// Determines the color of the Crow object.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Constructor method to instantiate a new Crow object.
        /// </summary>
        /// <param name="name">The name of the new Crow object.</param>
        /// <param name="lifeSpan">The lifespan of the new Crow object.</param>
        /// <param name="color">The color of the new Crow object.</param>
        public Crow(string name, int lifeSpan, string color)
        {
            this.Name = name;
            this.Lifespan = lifeSpan;
            this.Color = color;
        }

        /// <summary>
        /// Tells the Crow object to fly.
        /// </summary>
        /// <returns>Returns a string about the Crow object flying.</returns>
        public override string Fly()
        {
            return $"{this.Name} flies with a Murder...";
        }

        /// <summary>
        /// Tells the Crow object to eat.
        /// </summary>
        /// <returns>Returns a string about the Crow object eating.</returns>
        public override string Eat()
        {
            return $"{base.Eat()} a worm from your backyard!";
        }

        /// <summary>
        /// Tells the Crow object to caw.
        /// </summary>
        /// <returns>Returns a string about the Crow object cawing.</returns>
        public string Caw()
        {
            return $"{this.Name} caws loudly outside of your window.";
        }
    }
}
