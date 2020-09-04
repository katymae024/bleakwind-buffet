/*
* Author: Katayoun Katy Davoudi
* Class name: ThugsTBone.cs
* Purpose: Offering an item of the menu 
*/
using System;
using System.Collections.Generic;
using System.Text;


namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Containing a specific entree with its properties
    /// </summary>
    public class ThugsTBone
    {
        /// <summary>
        /// gets price
        /// </summary>
        public double Price => 6.44;
        /// <summary>
        /// gets calories
        /// </summary>
        public uint Calories => 982;
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
        /// prints the name of entree
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}
