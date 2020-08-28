using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class CandlehearthCoffee
    {
        private bool ice = false;

        private bool decaf = false;

        private bool roomForCream = false;

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

        public bool Decaf
        {
            get
            {
                return decaf;
            }
            set
            {
                decaf = value;
            }
        }

        public bool RoomForCream
        {
            get
            {
                return roomForCream;
            }
            set
            {
                roomForCream = value;
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
                    return 0.75;
                }
                else if (Size == Size.Medium)
                {
                    return 1.25;
                }
                else
                {
                    return 1.75;
                }
            }
        }

        public uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 7;
                }
                else if (Size == Size.Medium)
                {
                    return 10;
                }
                else
                {
                    return 20;
                }
            }
        }

        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instruction = new List<string>();
                if (!Ice) instruction.Add("Add Ice");
                if (!RoomForCream) instruction.Add("Add Cream");

                return instruction;
            }
        }

        public override string ToString()
        {
            if(decaf == true)
            {
                return Size.ToString() + "Decaf Candlehearth Coffee";
            }
            else
            {
                return Size.ToString() + "Candlehearth Coffee";
            }
            
        }

    }
}
