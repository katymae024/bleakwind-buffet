/*
* Author: Katayoun Katy Davoudi
* Class name: DragonbornWaffleFries.cs
* Purpose: Offering an item of the menu 
*/
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Containing a specific side with its properties
    /// </summary>
    public class DragonbornWaffleFries
    {
        /// <summary>
        /// private property for size
        /// </summary>
        private Size size = Size.Small;
        /// <summary>
        /// property for size
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
        /// gets price
        /// </summary>
        public double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 0.42;
                }
                else if (Size == Size.Medium)
                {
                    return 0.76;
                }
                else
                {
                    return 0.96;
                }
            }
        }
        /// <summary>
        /// gets calories
        /// </summary>
        public uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 77;
                }
                else if (Size == Size.Medium)
                {
                    return 89;
                }
                else
                {
                    return 100;
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

                return instruction;
            }
        }
        /// <summary>
        /// prints the name of the side
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Size.ToString() + "Dragonborn Waffle Fries";
        }
    }
}
