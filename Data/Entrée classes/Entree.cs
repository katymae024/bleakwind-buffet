/*
* Author: Katayoun Katy Davoudi
* Class name: Entree.cs
* Purpose: All entrees derive from this class
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Interfaces;

namespace BleakwindBuffet.Data.Entrée_classes
{
    /// <summary>
    /// a base class representing the common properties of entree
    /// </summary>
    public abstract class Entree : IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Price of the entree
        /// </summary>
        /// <value>
        /// in the US Dollars
        /// </value>
        public abstract double Price { get; }

        /// <summary>
        /// Calories of the entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// special instruction to prepare the entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        public abstract string Description { get; }
    }
}
