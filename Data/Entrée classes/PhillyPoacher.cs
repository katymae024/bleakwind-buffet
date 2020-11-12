/*
* Author: Katayoun Katy Davoudi
* Class name: PhillyPoacher.cs
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
    public class PhillyPoacher : Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// Eventhandler for property change
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// private property sirloin
        /// </summary>
        private bool sirloin = true;
        /// <summary>
        /// private property onion
        /// </summary>
        private bool onion = true;
        /// <summary>
        /// private property roll
        /// </summary>
        private bool roll = true;
        /// <summary>
        /// private property for description
        /// </summary>
        private string description = "Cheesesteak sandwich made from grilled sirloin, topped with onions on a fried roll.";
        /// <summary>
        /// description for the menu item
        /// </summary>
        public override string Description { get { return description; } }
        /// <summary>
        /// gets price
        /// </summary>
        public override double Price => 7.23;
        /// <summary>
        /// gets calories
        /// </summary>
        public override uint Calories => 784;
        /// <summary>
        /// boolean property for sirloin
        /// </summary>
        public bool Sirloin
        {
            get
            {
                return sirloin;
            }
            set
            {

                sirloin = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Sirloin"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));

            }
        }
        /// <summary>
        /// boolean property for onion
        /// </summary>
        public bool Onion
        {
            get
            {
                return onion;
            }
            set
            {

                onion = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Onion"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));

            }
        }
        /// <summary>
        /// boolean property for roll
        /// </summary>
        public bool Roll
        {
            get
            {
                return roll;
            }
            set
            {

                roll = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Roll"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));

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

                if (!Sirloin) instruction.Add("Hold sirloin");
                if (!Onion) instruction.Add("Hold onion");
                if (!Roll) instruction.Add("Hold roll");
              
                return instruction;
            }
        }
        /// <summary>
        /// prints name of entree
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }
        /// <summary>
        /// Display name property
        /// </summary>
        public string DisplayName
        {
            get => ToString();
        }

    }
}
