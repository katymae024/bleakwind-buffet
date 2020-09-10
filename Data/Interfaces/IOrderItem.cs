using System;
using System.Collections.Generic;
using System.Text;


namespace BleakwindBuffet.Data.Interfaces
{
    public interface IOrderItem
    {
        /// <summary>
        /// Price of the drink
        /// </summary>
        /// <value>
        /// in the US Dollars
        /// </value>
        double Price { get; }
        /// <summary>
        /// Calories of the drink
        /// </summary>
        uint Calories { get; }
        /// <summary>
        /// special instruction to prepare the drink
        /// </summary>
        List<string> SpecialInstructions { get; }
    }
}
