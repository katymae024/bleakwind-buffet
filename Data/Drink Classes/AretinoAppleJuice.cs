using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class AretinoAppleJuice
    {
        private bool ice = true;

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
                    return 0.62;
                }
                else if (Size == Size.Medium)
                {
                    return 0.87;
                }
                else
                {
                    return 1.01;
                }
            }
        }

        public uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 44;
                }
                else if (Size == Size.Medium)
                {
                    return 88;
                }
                else
                {
                    return 132;
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
            return Size.ToString() + "Aretino Apple Juice";
        }

    }
}
