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
    public class VokunSalad
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
            return Size.ToString() + "Vokun Salad";
        }


    }
}
