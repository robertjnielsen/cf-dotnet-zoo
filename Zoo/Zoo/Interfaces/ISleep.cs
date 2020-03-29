using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Interfaces
{
    interface ISleep
    {
        /// <summary>
        /// Tells the object to sleep.
        /// </summary>
        /// <returns>Returns a string about the object sleeping.</returns>
        public string Sleep();

        /// <summary>
        /// Tells the object to wake up.
        /// </summary>
        /// <returns>Returns a string about the object waking up.</returns>
        public string WakeUp();
    }
}
