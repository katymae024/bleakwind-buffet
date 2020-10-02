/*
* Author: Katayoun Katy Davoudi
* Class name: DoubleDraugr.cs
* Purpose: Offering an item of the menu 
*/
using System;
using System.Collections.Generic;
using System.Text;

using BleakwindBuffet.Data.Entrée_classes;
using System.ComponentModel;


namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Containing a specific entree with its properties
    /// </summary>
    public class DoubleDraugr : Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// Eventhandler for property change
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
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
        public override double Price => 7.32;
        /// <summary>
        /// gets calorie of burger
        /// </summary>
        public override uint Calories => 843;

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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ketchup"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bun"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mustard"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheese"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tomato"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lettuce"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mayo"));
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
