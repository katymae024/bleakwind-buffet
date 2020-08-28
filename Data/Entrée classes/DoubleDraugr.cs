using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class DoubleDraugr
    {
        private bool ketchup = true;

        private bool bun = true;

        private bool mustard = true;

        private bool cheese = true;

        private bool pickle = true;

        private bool tomato = true;

        private bool lettuce = true;

        private bool mayo = true;

        //gets price of the burger
        public double Price => 7.32;

        public uint Calories => 843;


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


        public bool Mustard
        {
            get
            {
                return mustard;
            }
            set
            {
                mustard = value;
            }
        }

        public bool Pickle
        {
            get
            {
                return pickle;
            }
            set
            {

                pickle = value;
            }
        }

        public bool Cheese
        {
            get
            {
                return cheese;
            }
            set
            {

                cheese = value;
            }
        }

        public bool Tomato
        {
            get
            {
                return tomato;
            }
            set
            {

                tomato = value;
            }
        }

        public bool Lettuce
        {
            get
            {
                return lettuce;
            }
            set
            {

                lettuce = value;
            }
        }

        public bool Mayo
        {
            get
            {
                return mayo;
            }
            set
            {

                mayo = value;
            }
        }




        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instruction = new List<string>();
                if (!Ketchup) instruction.Add("Hold ketchup");
                if (!Bun) instruction.Add("Hold bun");
                if (!Cheese) instruction.Add("Hold cheese");
                if (!Pickle) instruction.Add("Hold pickle");
                if (!Mustard) instruction.Add("Hold mustard");
                if (!Lettuce) instruction.Add("Hold lettuce");
                if (!Mayo) instruction.Add("Hold mayo");
                if (!Tomato) instruction.Add("Hold tomato");
                return instruction;
            }
        }

        public override string ToString()
        {
            return "Double Draugr";
        }


    }
}
