using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Interfaces;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
//using BleakwindBuffet.Data.Entrée_classes;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;




namespace BleakwindBuffet.Data
{
    public static class Menu
    {
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> entreeList = new List<IOrderItem>();

            BriarheartBurger b = new BriarheartBurger();
            entreeList.Add(b);

            DoubleDraugr d = new DoubleDraugr();
            entreeList.Add(d);

            GardenOrcOmelette g = new GardenOrcOmelette();
            entreeList.Add(g);

            PhillyPoacher p = new PhillyPoacher();
            entreeList.Add(p);

            SmokehouseSkeleton s = new SmokehouseSkeleton();
            entreeList.Add(s);

            ThalmorTriple t = new ThalmorTriple();
            entreeList.Add(t);

            ThugsTBone tt = new ThugsTBone();
            entreeList.Add(tt);


            return entreeList;
        }

        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> drinkList = new List<IOrderItem>();
            foreach (Size s in Enum.GetValues(typeof(Size)))
            {
                AretinoAppleJuice a = new AretinoAppleJuice();
                a.Size = s;
                drinkList.Add(a);

                
                
                foreach (SodaFlavor f in Enum.GetValues(typeof(SodaFlavor)))
                {
                    SailorSoda ss = new SailorSoda();
                    ss.Size = s;
                    ss.Flavor = f;

                    drinkList.Add(ss);
                }

                CandlehearthCoffee c = new CandlehearthCoffee();

                c.Size = s;
                drinkList.Add(c);

                CandlehearthCoffee cDecaf = new CandlehearthCoffee();
                cDecaf.Size = s;
                cDecaf.Decaf = true;
                drinkList.Add(cDecaf);


                MarkarthMilk m = new MarkarthMilk();
                m.Size = s;
                drinkList.Add(m);

                WarriorWater w = new WarriorWater();
                w.Size = s;
                drinkList.Add(w);

            }

            return drinkList;


        }

        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> sideList = new List<IOrderItem>();
            foreach (Size f in Enum.GetValues(typeof(Size)))
            {
                DragonbornWaffleFries d = new DragonbornWaffleFries();
                d.Size = f;
                sideList.Add(d);

                FriedMiraak fm = new FriedMiraak();
                fm.Size = f;
                sideList.Add(fm);

                MadOtarGrits m = new MadOtarGrits();
                m.Size = f;
                sideList.Add(m);

                VokunSalad v = new VokunSalad();
                v.Size = f;
                sideList.Add(v);



            }
            return sideList;
        }

        public static IEnumerable<IOrderItem> FullMenu()
        {
            List<IOrderItem> fullList = new List<IOrderItem>();

            return fullList;
        }
    }
}
