using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class WarriorWater
    {
        private bool ice = true;

        private Size size = Size.Small;

        private bool lemon = false;

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

        public override string ToString()
        {
            return Size.ToString() + "Warrior Water";
        }


    }
}
