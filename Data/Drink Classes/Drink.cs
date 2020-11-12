/*
* Author: Katayoun Katy Davoudi
* Class name: Drink.cs
* Purpose: All drinks derive from this class
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Interfaces;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drink_Classes
{
    /// <summary>
    /// a base class representing the common properties of drinks
    /// </summary>
    public abstract class Drink : IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Eventhandler for property change
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        private Size size = Size.Small;
        /// <summary>
        /// The size of the drink
        /// </summary>
        public virtual Size Size 
        {
            get
            {
                return size;

            }
            set
            {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Small"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Medium"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Large"));

            }
        }
        /// <summary>
        /// method for checking size small
        /// </summary>
        public bool Small
        {
            get
            {
                if(Size == Size.Small)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            set
            {
                if(value ==true)
                {
                    Size = Size.Small;
                }
            }
        }
        /// <summary>
        /// method for checking size medium
        /// </summary>
        public bool Medium
        {
            get
            {
                if (Size == Size.Medium)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            set
            {
                if (value == true)
                {
                    Size = Size.Medium;
                }
            }
        }
        /// <summary>
        /// method for checking size large
        /// </summary>
        public bool Large
        {
            get
            {
                if (Size == Size.Large)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            set
            {
                if (value == true)
                {
                    Size = Size.Large;
                }
            }
        }

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

        public abstract string Description { get; }
    }
}
