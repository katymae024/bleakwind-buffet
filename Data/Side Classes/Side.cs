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
using System.ComponentModel;

namespace BleakwindBuffet.Data.Side_Classes
{
    /// <summary>
    /// a base class representing the common properties of sides
    /// </summary>
    public abstract class Side : IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Eventhandler for property change
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        private Size size = Size.Small;
        /// <summary>
        /// The size of the side
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Medium"));
                //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Large"));
            }
        }

        /// <summary>
        /// method for checking size small
        /// </summary>
        public bool Small
        {
            get
            {
                if (Size == Size.Small)
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
                    Size = Size.Small;

                }

            }
        }
        /// <summary>
        /// method for checking size Medium
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
        /// method for checking size Large
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
