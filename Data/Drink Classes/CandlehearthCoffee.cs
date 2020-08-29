/*
* Author: Katayoun Katy Davoudi
* Class name: CandlehearthCoffee.cs
* Purpose: Offering an item of the menu 
*/
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Containing a specific drink with its properties
    /// </summary>
    public class CandlehearthCoffee
    {
        /// <summary>
        /// private property for ice
        /// </summary>
        private bool ice = false;
        /// <summary>
        /// private property for decaf
        /// </summary>
        private bool decaf = false;
        /// <summary>
        /// private property for room for cream
        /// </summary>
        private bool roomForCream = false;
        /// <summary>
        /// private property for size
        /// </summary>
        private Size size = Size.Small;
        /// <summary>
        /// boolean property for ice 
        /// </summary>
        public bool Ice
        {
            get
            {
                return ice;
            }
            set
            {
                ice = value;
            }
        }
        /// <summary>
        /// boolean property for decaf
        /// </summary>
        public bool Decaf
        {
            get
            {
                return decaf;
            }
            set
            {
                decaf = value;
            }
        }
        /// <summary>
        /// boolean property for room for cream
        /// </summary>
        public bool RoomForCream
        {
            get
            {
                return roomForCream;
            }
            set
            {
                roomForCream = value;
            }
        }
        /// <summary>
        /// boolean property for size
        /// </summary>
        public Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }
        /// <summary>
        /// boolean property for price
        /// </summary>
        public double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 0.75;
                }
                else if (Size == Size.Medium)
                {
                    return 1.25;
                }
                else
                {
                    return 1.75;
                }
            }
        }
        /// <summary>
        ///  boolean property for calories
        /// </summary>
        public uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 7;
                }
                else if (Size == Size.Medium)
                {
                    return 10;
                }
                else
                {
                    return 20;
                }
            }
        }
        /// <summary>
        /// whether someone wants everything being offered or wants to exclude certain items
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instruction = new List<string>();
                if (!Ice) instruction.Add("Add Ice");
                if (!RoomForCream) instruction.Add("Add Cream");

                return instruction;
            }
        }
        /// <summary>
        /// printing size of coffee and name of drink
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if(decaf == true)
            {
                return Size.ToString() + "Decaf Candlehearth Coffee";
            }
            else
            {
                return Size.ToString() + "Candlehearth Coffee";
            }
            
        }

    }
}
