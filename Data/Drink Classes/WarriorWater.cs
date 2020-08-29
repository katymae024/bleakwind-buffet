/*
* Author: Katayoun Katy Davoudi
* Class name: WarriorWater.cs
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
    public class WarriorWater
    {
        /// <summary>
        /// private property for ice
        /// </summary>
        private bool ice = true;
        /// <summary>
        /// private property for size
        /// </summary>
        private Size size = Size.Small;
        /// <summary>
        /// private property for lemon
        /// </summary>
        private bool lemon = false;
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
        /// boolean property for lemon
        /// </summary>
        public bool Lemon
        {
            get
            {
                return lemon;
            }
            set
            {
                lemon = value;
            }
        }
        /// <summary>
        /// price based on size
        /// </summary>
        public double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 0.00;
                }
                else if (Size == Size.Medium)
                {
                    return 0.00;
                }
                else
                {
                    return 0.00;
                }
            }
        }
        /// <summary>
        /// calories based on size
        /// </summary>
        public uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 0;
                }
                else if (Size == Size.Medium)
                {
                    return 0;
                }
                else
                {
                    return 0;
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
                if (!Ice) instruction.Add("Hold Ice");
                if (!Lemon) instruction.Add("Add Lemon");


                return instruction;
            }
        }
        /// <summary>
        /// printing the name of the drink
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Size.ToString() + "Warrior Water";
        }


    }
}
