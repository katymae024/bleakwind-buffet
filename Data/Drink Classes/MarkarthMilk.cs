/*
* Author: Katayoun Katy Davoudi
* Class name: MarkarthMilk.cs
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
    public class MarkarthMilk
    {
        /// <summary>
        /// private property for ice
        /// </summary>
        private bool ice = false;
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
        /// public method for size
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
        /// property for price depending of size
        /// 
        /// </summary>
        public double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 1.05;
                }
                else if (Size == Size.Medium)
                {
                    return 1.11;
                }
                else
                {
                    return 1.22;
                }
            }
        }
        /// <summary>
        /// property for calories depending on size
        /// </summary>
        public uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 56;
                }
                else if (Size == Size.Medium)
                {
                    return 72;
                }
                else
                {
                    return 93;
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
       

                return instruction;
            }
        }
        /// <summary>
        /// printing the drink
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Size.ToString() + "Markarth Milk";
        }


    }
}
