﻿/*
* Author: Katayoun Katy Davoudi
* Class name: MarkarthMilk.cs
* Purpose: Offering an item of the menu 
*/
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Interfaces;
using System.ComponentModel;


namespace BleakwindBuffet.Data.Drink_Classes
{
    /// <summary>
    /// Containing a specific drink with its properties
    /// </summary>
    public class MarkarthMilk: Drink, INotifyPropertyChanged
    {
        /// <summary>
        /// Eventhandler for property change
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// private property for ice
        /// </summary>
        private bool ice = false;
        /// <summary>
        /// private property for description
        /// </summary>
        private string description = "Hormone-free organic 2% milk.";
        /// <summary>
        /// private property for size
        /// </summary>
        private Size size = Size.Small;
        /// <summary>
        /// boolean property for ice
        /// </summary>
        public bool Ice
        {
            get
            {
                return ice;
            }
            set
            {
                ice = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
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
        /// <summary>
        /// property for price depending of size
        /// 
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 1.05;
                }
                else if (Size == Size.Medium)
                {
                    return 1.11;
                }
                else
                {
                    return 1.22;
                }
            }
        }
        /// <summary>
        /// property for calories depending on size
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 56;
                }
                else if (Size == Size.Medium)
                {
                    return 72;
                }
                else
                {
                    return 93;
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
                if (Ice) instruction.Add("Add ice");
       

                return instruction;
            }
        }
        /// <summary>
        /// printing the drink
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Size.ToString() + " Markarth Milk";
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
