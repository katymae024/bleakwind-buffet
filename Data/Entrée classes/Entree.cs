using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrée_classes
{
    public abstract class Entree
    {
        /// <summary>
        /// Price of the drink
        /// </summary>
        /// <value>
        /// in the US Dollars
        /// </value>
        public abstract double Price { get; }

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
