/*
* Author: Katayoun Katy Davoudi
* Class name: SmokehouseSkeleton.cs
* Purpose: Offering an item of the menu 
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class SmokehouseSkeleton
    {
        private bool sausageLink = true;

        private bool egg = true;

        private bool hashBrowns = true;

        private bool pancake = true;

        public double Price => 5.62;

        public uint Calories => 602;

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

        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instruction = new List<string>();

                if (!SausageLink) instruction.Add("Hold sausage");
                if (!Egg) instruction.Add("Hold egg");
                if (!HashBrowns) instruction.Add("Hold hash browns");
                if (!Pancake) instruction.Add("Hold pancake");
               

                return instruction;
            }
        }

        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }





    }
}
