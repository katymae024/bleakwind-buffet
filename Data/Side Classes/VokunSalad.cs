/*
* Author: Katayoun Katy Davoudi
* Class name: VokunSalad.cs
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
    public class VokunSalad
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
                if(Size == Size.Small)
                {
                    return 0.93;
                }
                else if (Size == Size.Medium)
                {
                    return 1.28;
                }
                else 
                {
                    return 1.82;
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
                    return 41;
                }
                else if (Size == Size.Medium)
                {
                    return 52;
                }
                else
                {
                    return 73;
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
        /// prints name of side
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Size.ToString() + " Vokun Salad";
        }


    }
}
