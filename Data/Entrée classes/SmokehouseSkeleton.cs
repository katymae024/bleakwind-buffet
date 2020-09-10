/*
* Author: Katayoun Katy Davoudi
* Class name: SmokehouseSkeleton.cs
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
    public class SmokehouseSkeleton : Entree
    {
        /// <summary>
        /// private property for sausage links
        /// </summary>
        private bool sausageLink = true;
        /// <summary>
        /// private property for egg
        /// </summary>
        private bool egg = true;
        /// <summary>
        /// private property for hash browns
        /// </summary>
        private bool hashBrowns = true;
        /// <summary>
        /// private property for pancake
        /// </summary>
        private bool pancake = true;
        /// <summary>
        /// gets price
        /// </summary>
        public override double Price => 5.62;
        /// <summary>
        /// gets calories
        /// </summary>
        public override uint Calories => 602;
        /// <summary>
        /// boolean property for sausage link
        /// </summary>
        public bool SausageLink
        {
            get
            {
                return sausageLink;
            }
            set
            {

                sausageLink = value;
            }
        }
        /// <summary>
        /// boolean property for eggs
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
        /// boolean property for hash browns
        /// </summary>
        public bool HashBrowns
        {
            get
            {
                return hashBrowns;
            }
            set
            {

                hashBrowns = value;
            }
        }
        /// <summary>
        /// boolean property for pancake
        /// </summary>
        public bool Pancake
        {
            get
            {
                return pancake;
            }
            set
            {

                pancake = value;
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

                if (!SausageLink) instruction.Add("Hold sausage");
                if (!Egg) instruction.Add("Hold egg");
                if (!HashBrowns) instruction.Add("Hold hashbrowns");
                if (!Pancake) instruction.Add("Hold pancake");
               

                return instruction;
            }
        }
        /// <summary>
        /// prints name of entree
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }





    }
}
