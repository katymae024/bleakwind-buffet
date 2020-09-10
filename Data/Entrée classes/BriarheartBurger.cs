/*
* Author: Katayoun Katy Davoudi
* Class name: BriarheartBurger.cs
* Purpose: Offering an item of the menu 
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Entrée_classes;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Containing a specific entree with its properties
    /// </summary>
    public class BriarheartBurger : Entree
    {
        /// <summary>
        /// private property for ketchup
        /// </summary>
        private bool ketchup = true;
        /// <summary>
        /// private property for bun
        /// </summary>
        private bool bun = true;
        /// <summary>
        /// private property for mustard
        /// </summary>
        private bool mustard = true;
        /// <summary>
        /// private property for cheese
        /// </summary>
        private bool cheese = true;
        /// <summary>
        /// private property for pickle
        /// </summary>
        private bool pickle = true;

        /// <summary>
        ///gets price of the burger
        /// </summary>
        public override double Price =>  6.32;
        /// <summary>
        /// //gets calories of the burger
        /// </summary>
        public override uint Calories => 743;

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
        /// whether someone wants everything being offered or wants to exclude certain items
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instruction = new List<string>();
                if (!Ketchup) instruction.Add("Hold ketchup");
                if (!Bun) instruction.Add("Hold bun");
                if (!Cheese) instruction.Add("Hold cheese");
                if (!Pickle) instruction.Add("Hold pickle");
                if (!Mustard) instruction.Add("Hold mustard");
                return instruction;
            }
        }
        /// <summary>
        /// printing the name of the entree
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }



    }
}
