using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class GardenOrcOmelette
    {
        private bool broccoli = true;

        private bool mushrooms = true;

        private bool tomato = true;

        private bool cheddar = true;

        public double Price => 4.57;

        public uint Calories => 404;

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

        public override string ToString()
        {
            return "Garden Orc Omelette";
        }




    }
}
