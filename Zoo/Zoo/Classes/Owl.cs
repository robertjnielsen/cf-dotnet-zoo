using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public class Owl : Bird
    {
        /// <summary>
        /// Determines that Owl objects are Nocturnal.
        /// </summary>
        public override bool Nocturnal { get => base.Nocturnal; set => base.Nocturnal = true; }

        /// <summary>
        /// Determines that Own objects are not Social.
        /// </summary>
        public override bool Social { get => base.Social; set => base.Social = false; }

        /// <summary>
        /// Constructor method to instantiate a new Owl object.
        /// </summary>
        /// <param name="name">The name of the new Owl object.</param>
        /// <param name="lifeSpan">The lifespan of the new Owl object in years.</param>
        public Owl(string name, int lifeSpan)
        {
            this.Name = name;
            this.Lifespan = lifeSpan;
        }

        /// <summary>
        /// Tells the Owl object to fly.
        /// </summary>
        /// <returns>Returns a string about the Owl object flying.</returns>
        public override string Fly()
        {
            return $"{this.Name} flies through the night sky...";
        }

        /// <summary>
        /// Tells the Owl object to eat.
        /// </summary>
        /// <returns>Returns a string about the Owl object eating.</returns>
        public override string Eat()
        {
            return $"{base.Eat()} some field mice!";
        }

        /// <summary>
        /// Tells the Owl object to hoot.
        /// </summary>
        /// <returns>Returns a string about the Owl object hooting.</returns>
        public string Hoot()
        {
            return $"{this.Name} hoots ominously...";
        }
    }
}
