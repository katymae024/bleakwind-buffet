/*
* Author: Katayoun Katy Davoudi
* Class name: IOrderItem.cs
* Purpose: This interface implements all entrees, drinks, and sides
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;


namespace BleakwindBuffet.Data.Interfaces
{
    /// <summary>
    /// a base class representing the common properties of IOrderItem
    /// </summary>
    public interface IOrderItem: INotifyPropertyChanged
    {
        /// <summary>
        /// Price of the drink, entree, sides
        /// </summary>
        /// <value>
        /// in the US Dollars
        /// </value>
        double Price { get; }
        /// <summary>
        /// Calories of the drink, entree, sides
        /// </summary>
        uint Calories { get; }
        /// <summary>
        /// special instruction to prepare the drink, entree, sides
        /// </summary>
        List<string> SpecialInstructions { get; }

        string Description { get; }
    }
}
