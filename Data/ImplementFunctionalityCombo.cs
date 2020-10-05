using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using BleakwindBuffet.Data.Interfaces;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Entrée_classes;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Side_Classes;

namespace BleakwindBuffet.Data
{
    public class ImplementFunctionalityCombo : IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private Entree entree;
        private Drink drink;
        private Side side;


        public double Price => throw new NotImplementedException();

        public uint Calories => throw new NotImplementedException();

        public List<string> SpecialInstructions
        {
            get
            {
                throw new NotImplementedException();

                List<string> list = new List<string>();
                list.Add(entree.ToString());
                list.AddRange(entree.SpecialInstructions);
                list.Add(drink.ToString());
                list.AddRange(drink.SpecialInstructions);
                list.Add(side.ToString());
                list.AddRange(side.SpecialInstructions);
                return list;
            }
            
        }


        



    }
}
