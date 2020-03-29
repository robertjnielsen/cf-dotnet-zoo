using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    public class Owl : Bird, ISleep, IPoop
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

        /// <summary>
        /// Tells the Owl object to sleep.
        /// </summary>
        /// <returns>Returns a string about the Owl object sleeping.</returns>
        public string Sleep()
        {
            return $"{this.Name} is sleeping through the day...";
        }

        /// <summary>
        /// Tells the Owl object to wake up.
        /// </summary>
        /// <returns>Returns a string about the Owl object waking up.</returns>
        public string WakeUp()
        {
            return $"{this.Name} wakes up as the sun falls, preparing to hunt...";
        }

        /// <summary>
        /// Tells the Owl object to poop.
        /// </summary>
        /// <returns>Returns a string about the Owl object pooping.</returns>
        public string Poop()
        {
            return $"{this.Name} is both pooping, and regurgitating pellets. Gross!";
        }
    }
}
