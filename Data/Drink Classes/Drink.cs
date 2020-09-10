using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drink_Classes
{
    /// <summary>
    /// a base class representing the common properties of drinks
    /// </summary>
    public abstract class Drink
    {
        /// <summary>
        /// The size of the drink
        /// </summary>
        public virtual Size Size { get; set; }
        /// <summary>
        /// Price of the drink
        /// </summary>
        /// <value>
        /// in the US Dollars
        /// </value>
        public abstract double Price { get;}
        /// <summary>
        /// Calories of the drink
        /// </summary>
        public abstract uint Calories { get; }
        /// <summary>
        /// special instruction to prepare the drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }



    }
}
