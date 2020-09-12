/*
* Author: Katayoun Katy Davoudi
* Class name: Side.cs
* Purpose: All entrees derive from this class
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Interfaces;

namespace BleakwindBuffet.Data.Side_Classes
{
    /// <summary>
    /// a base class representing the common properties of sides
    /// </summary>
    public abstract class Side : IOrderItem
    {
        /// <summary>
        /// The size of the side
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// Price of the side
        /// </summary>
        /// <value>
        /// in the US Dollars
        /// </value>
        public abstract double Price { get; }
        /// <summary>
        /// Calories of the side
        /// </summary>
        public abstract uint Calories { get; }
        /// <summary>
        /// special instruction to prepare the side
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
