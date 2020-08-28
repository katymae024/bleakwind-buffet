/*
* Author: Katayoun Katy Davoudi
* Class name: MadOtarGrits.cs
* Purpose: Offering an item of the menu 
*/
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    public class MadOtarGrits
    {
        private Size size = Size.Small;

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

        public double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 1.22;
                }
                else if (Size == Size.Medium)
                {
                    return 1.58;
                }
                else
                {
                    return 1.93;
                }
            }
        }

        public uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 105;
                }
                else if (Size == Size.Medium)
                {
                    return 142;
                }
                else
                {
                    return 179;
                }
            }
        }

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
            return Size.ToString() + "Mad Otar Grits";
        }
    }
}
