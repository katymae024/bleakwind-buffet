/*
* Author: Katayoun Katy Davoudi
* Class name: ThalmorTriple.cs
* Purpose: Offering an item of the menu 
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class ThalmorTriple
    {
        private bool ketchup = true;

        private bool bun = true;

        private bool mustard = true;

        private bool cheese = true;

        private bool pickle = true;

        private bool tomato = true;

        private bool lettuce = true;

        private bool mayo = true;

        private bool bacon = true;

        private bool egg = true;

        //gets price of the burger
        public double Price => 8.32;

        public uint Calories => 943;


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
        public bool Bacon
        {
            get
            {
                return bacon;
            }
            set
            {

                bacon = value;
            }
        }

        public bool Egg
        {
            get
            {
                return egg;
            }
            set
            {

                egg = value;
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
                if (!Bacon) instruction.Add("Hold bacon");
                if (!Egg) instruction.Add("Hold egg");
                return instruction;
            }
        }

        public override string ToString()
        {
            return "Thalmor Triple";
        }

    }
}
