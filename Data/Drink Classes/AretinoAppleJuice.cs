/*
* Author: Katayoun Katy Davoudi
* Class name: AretinoAppleJuice.cs
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
    public class AretinoAppleJuice
    {
        /// <summary>
        /// private property for ice
        /// </summary>
        private bool ice = true;
        /// <summary>
        /// private property for size of drink
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
        /// boolean property for price as far as sizes
        /// </summary>
        public double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 0.62;
                }
                else if (Size == Size.Medium)
                {
                    return 0.87;
                }
                else
                {
                    return 1.01;
                }
            }
        }
        /// <summary>
        /// boolean property for calories as far as sizes
        /// </summary>
        public uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 44;
                }
                else if (Size == Size.Medium)
                {
                    return 88;
                }
                else
                {
                    return 132;
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
                if (Ice) instruction.Add("Add Ice");
                
                return instruction;
            }
        }
        /// <summary>
        /// converts to the name of the drink
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Size.ToString() + "Aretino Apple Juice";
        }

    }
}
