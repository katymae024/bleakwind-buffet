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
    public class ThugsTBone
    {
        public double Price => 6.44;

        public uint Calories => 982;

        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instruction = new List<string>();

                return instruction;
            }
        }

        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}
