using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class PhillyPoacher
    {
        private bool sirloin = true;

        private bool onion = true;

        private bool roll = true;

        public double Price => 7.23;

        public uint Calories => 784;

        public bool Sirloin
        {
            get
            {
                return sirloin;
            }
            set
            {

                sirloin = value;
            }
        }

        public bool Onion
        {
            get
            {
                return onion;
            }
            set
            {

                onion = value;
            }
        }

        public bool Roll
        {
            get
            {
                return roll;
            }
            set
            {

                roll = value;
            }
        }

        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instruction = new List<string>();

                if (!Sirloin) instruction.Add("Hold sirloin");
                if (!Onion) instruction.Add("Hold onion");
                if (!Roll) instruction.Add("Hold roll");
              
                return instruction;
            }
        }

        public override string ToString()
        {
            return "Philly Poacher";
        }

    }
}
