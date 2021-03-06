﻿/*
* Author: Katayoun Katy Davoudi
* Class name: DragonbornWaffleFries.cs
* Purpose: Offering an item of the menu 
*/
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Side_Classes;
using System.ComponentModel;


namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Containing a specific side with its properties
    /// </summary>
    public class DragonbornWaffleFries : Side, INotifyPropertyChanged
    {
        /// <summary>
        /// Eventhandler for property change
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// private property for size
        /// </summary>
        private Size size = Size.Small;
        /// <summary>
        /// private property for description
        /// </summary>
        private string description = "Crispy fried potato waffle fries.";
        /// <summary>
        /// description for the menu item
        /// </summary>
        public override string Description { get { return description; } }
        /// <summary>
        /// The size of the drink
        /// </summary>
        public override Size Size
        {
            get
            {
                return size;

            }
            set
            {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));

            }
        }
        public string DisplayName
        {
            get => ToString();
        }
        /// <summary>
        /// gets price
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 0.42;
                }
                else if (Size == Size.Medium)
                {
                    return 0.76;
                }
                else
                {
                    return 0.96;
                }
            }
        }
        /// <summary>
        /// gets calories
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 77;
                }
                else if (Size == Size.Medium)
                {
                    return 89;
                }
                else
                {
                    return 100;
                }
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

                return instruction;
            }
        }
        /// <summary>
        /// prints the name of the side
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Size.ToString() + " Dragonborn Waffle Fries";
        }
    }
}
