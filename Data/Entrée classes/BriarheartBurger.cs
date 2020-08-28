using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class BriarheartBurger
    {
        //gets price of the burger
        public double Price =>  6.32;

        public uint Calories => 732;

        private bool ketchup = true; 
        public bool Ketchup
        {
            get
            {
                return ketchup;
            }
            set
            {
                
                ketchup = value;
            }
        }

        private bool bun = true;
        public bool Bun
        {
            get
            {
                return bun;
            }
            set
            {
                bun = value;
            }
        }

        private bool musturd = true;
        public bool Musturd
        {
            get
            {
                return musturd;
            }
            set
            {
                musturd = value;
            }
        }

        
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instruction = new List<string>();
                if (!Ketchup) instruction.Add("Hold ketchup");
                if (!Bun) instruction.Add("Hold bun");
                return instruction;
            }
        }

        public override string ToString()
        {
            return "Briarheart Burger";
        }



    }
}
