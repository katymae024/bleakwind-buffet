using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class MarkarthMilk
    {
        private bool ice = false;

        private Size size = Size.Small;

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

        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instruction = new List<string>();
                if (!Ice) instruction.Add("Add Ice");
       

                return instruction;
            }
        }

        public override string ToString()
        {
            return Size.ToString() + "Markarth Milk";
        }


    }
}
