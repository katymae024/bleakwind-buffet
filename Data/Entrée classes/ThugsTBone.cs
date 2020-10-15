/*
* Author: Katayoun Katy Davoudi
* Class name: ThugsTBone.cs
* Purpose: Offering an item of the menu 
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Entrée_classes;



namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Containing a specific entree with its properties
    /// </summary>
    public class ThugsTBone : Entree
    {
        
        /// <summary>
        /// gets price
        /// </summary>
        public override double Price => 6.44;
        /// <summary>
        /// gets calories
        /// </summary>
        public override uint Calories => 982;
        /// <summary>
        /// whether someone wants everything being offered or wants to exclude certain items
        /// </summary>
        public override List<string> SpecialInstructions
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
        /// <summary>
        /// Display name property
        /// </summary>
        public string DisplayName
        {
            get => ToString();
        }
    }
}
