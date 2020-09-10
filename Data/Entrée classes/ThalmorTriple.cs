/*
* Author: Katayoun Katy Davoudi
* Class name: ThalmorTriple.cs
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
    public class ThalmorTriple : Entree
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
        /// private property for tomato
        /// </summary>
        private bool tomato = true;
        /// <summary>
        /// private property for lettuce
        /// </summary>
        private bool lettuce = true;
        /// <summary>
        /// private property for mayo
        /// </summary>
        private bool mayo = true;
        /// <summary>
        /// private property for bacon
        /// </summary>
        private bool bacon = true;
        /// <summary>
        /// private property for egg
        /// </summary>
        private bool egg = true;

        /// <summary>
        /// gets price
        /// </summary>
        public override double Price => 8.32;
        /// <summary>
        /// gets calories
        /// </summary>
        public override uint Calories => 943;

        /// <summary>
        /// boolean property for ketchup
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
        /// boolean property for bun
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
        /// boolean property for mustard
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
        /// boolean property for pickle
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
        /// boolean property for cheese
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
        /// boolean property for tomato
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
        /// boolean property for lettuce
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
        /// boolean property for mayo
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
        /// boolean property for bacon
        /// </summary>
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
        /// <summary>
        /// boolean property for egg
        /// </summary>
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
                if (!Lettuce) instruction.Add("Hold lettuce");
                if (!Mayo) instruction.Add("Hold mayo");
                if (!Tomato) instruction.Add("Hold tomato");
                if (!Bacon) instruction.Add("Hold bacon");
                if (!Egg) instruction.Add("Hold egg");
                return instruction;
            }
        }
        /// <summary>
        /// prints name of entree
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Thalmor Triple";
        }

    }
}
