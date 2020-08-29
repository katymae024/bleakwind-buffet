﻿/*
* Author: Katayoun Katy Davoudi
* Class name: GardenOrcOmelette.cs
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
    public class GardenOrcOmelette
    {
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
        /// gets the price
        /// </summary>
        public double Price => 4.57;
        /// <summary>
        /// gets the calories
        /// </summary>
        public uint Calories => 404;
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




    }
}
