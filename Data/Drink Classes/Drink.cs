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

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// a base class representing the common properties of drinks
    /// </summary>
    public abstract class Drink : IOrderItem, INotifyPropertyChanged
    {
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

        
    }
}
