/*
* Author: Katayoun Katy Davoudi
* Class name: DoubleDraugr.cs
* Purpose: Offering an item of the menu 
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Containing a specific entree with its properties
    /// </summary>
    public class DoubleDraugr
    {
        /// <summary>
        /// private property of ketchup
        /// </summary>
        private bool ketchup = true;
        /// <summary>
        /// private property of bun
        /// </summary>
        private bool bun = true;
        /// <summary>
        /// private property of mustard
        /// </summary>
        private bool mustard = true;
        /// <summary>
        /// private property of cheese
        /// </summary>
        private bool cheese = true;
        /// <summary>
        /// private property of pickle
        /// </summary>
        private bool pickle = true;
        /// <summary>
        /// private property of tomato
        /// </summary>
        private bool tomato = true;
        /// <summary>
        /// private property of lettuce
        /// </summary>
        private bool lettuce = true;
        /// <summary>
        /// private property of mayo
        /// </summary>
        private bool mayo = true;

        /// <summary>
        /// gets price of the burger
        /// </summary>
        public double Price => 7.32;
        /// <summary>
        /// gets calorie of burger
        /// </summary>
        public uint Calories => 843;

        /// <summary>
        /// boolean property of ketchup
        /// </summary>
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

        /// <summary>
        /// boolean property of bun
        /// </summary>
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

        /// <summary>
        /// boolean property of mustard
        /// </summary>
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
        /// <summary>
        /// boolean property of pickle
        /// </summary>
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
        /// <summary>
        /// boolean property of cheese
        /// </summary>
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
        /// <summary>
        /// boolean property of tomato
        /// </summary>
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
        /// <summary>
        /// boolean property of lettuce
        /// </summary>
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
        /// <summary>
        /// boolean property of mayo
        /// </summary>
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



        /// <summary>
        /// whether someone wants everything being offered or wants to exclude certain items
        /// </summary>
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
        /// <summary>
        /// prints name of entree
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Double Draugr";
        }


    }
}
