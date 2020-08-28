
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class SailorSoda
    {
        private bool ice = true;

        private Size size = Size.Small;

        private SodaFlavor flavor = SodaFlavor.Cherry;

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

        public SodaFlavor Flavor
        {
            get
            {
                return flavor;
            }
            set
            {
                flavor = value;
            }
        }

        public double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 1.42;
                }
                else if (Size == Size.Medium)
                {
                    return 1.74;
                }
                else
                {
                    return 2.07;
                }
            }
        }

        public uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 117;
                }
                else if (Size == Size.Medium)
                {
                    return 153;
                }
                else
                {
                    return 205;
                }
            }
        }

        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instruction = new List<string>();
                if (!Ice) instruction.Add("Hold Ice");


                return instruction;
            }
        }

        public override string ToString()
        {
            return Size.ToString() + Flavor.ToString() + "Sailor Soda" ;
        }


    }
}
