/*
* Author: Katayoun Katy Davoudi
* Class name: GardenOrcOmelette.cs
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
    public class GardenOrcOmelette : Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// Eventhandler for property change
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// private property broccoli
        /// </summary>
        private bool broccoli = true;
        /// <summary>
        /// private property of mushrooms
        /// </summary>
        private bool mushrooms = true;
        /// <summary>
        /// private property of tomato
        /// </summary>
        private bool tomato = true;
        /// <summary>
        /// private property of cheddar
        /// </summary>
        private bool cheddar = true;
        /// <summary>
        /// private property for description
        /// </summary>
        private string description = " Vegetarian. Two egg omelette packed with a mix of broccoli, mushrooms, and tomatoes. Topped with cheddar cheese.";
        /// <summary>
        /// description for the menu item
        /// </summary>
        public override string Description { get { return description; } }
        /// <summary>
        /// gets the price
        /// </summary>
        public override double Price => 4.57;
        /// <summary>
        /// gets the calories
        /// </summary>
        public override uint Calories => 404;
        /// <summary>
        /// boolean property for broccoli
        /// </summary>
        public bool Broccoli
        {
            get
            {
                return broccoli;
            }
            set
            {

                broccoli = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Broccoli"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <summary>
        /// boolean property for mushrooms
        /// </summary>
        public bool Mushrooms
        {
            get
            {
                return mushrooms;
            }
            set
            {


                mushrooms = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mushrooms"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tomato"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <summary>
        /// boolean property for cheddar
        /// </summary>
        public bool Cheddar
        {
            get
            {
                return cheddar;
            }
            set
            {

                cheddar = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheddar"));
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
               
                if (!Broccoli) instruction.Add("Hold broccoli");
                if (!Mushrooms) instruction.Add("Hold mushrooms");
                if (!Cheddar) instruction.Add("Hold cheddar");
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
            return "Garden Orc Omelette";
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
