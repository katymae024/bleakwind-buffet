using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Interfaces;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrée_classes;



namespace BleakwindBuffet.Data
{
    public static class Menu
    {
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> entreeList = new List<IOrderItem>();

            return entreeList;
        }

        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> drinkList = new List<IOrderItem>();
            foreach(Size s in Enum.GetValues(typeof(Size)))
            {
                AretinoAppleJuice a = new AretinoAppleJuice();
                a.Size = s;
                drinkList.Add(a);

                SailorSoda ss = new SailorSoda();
                ss.Size = s;
                foreach(SodaFlavor f in Enum.GetValues(typeof(SodaFlavor)))
                {
                    ss.Flavor = f;
                    drinkList.Add(ss);
                }
            }
            
            return drinkList;


        }

    }
}
