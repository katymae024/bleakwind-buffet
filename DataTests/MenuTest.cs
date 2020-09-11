using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Interfaces;
using BleakwindBuffet.Data;
using Xunit;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;


namespace BleakwindBuffet.DataTests
{
    public class MenuTest
    {
        //number of items there
        [Fact]
        public void CheckingNumbersOfEntrees()
        {
            IEnumerable<IOrderItem> e = Menu.Entrees();
            List<IOrderItem> entrees = (List<IOrderItem>)e;
            Assert.Equal(7, entrees.Count);
        }

        [Fact]
        public void CheckingEachEntreeToMakeSureItIsThere()
        {
            IEnumerable<IOrderItem> entrees = Menu.Entrees();

            Assert.Collection(entrees,
                    item => item.ToString().Contains("Briarheart Burger"),
                    item => item.ToString().Contains("Double Draugr"),
                    item => item.ToString().Contains("Garden Orc Omelette"),
                    item => item.ToString().Contains("Philly Poacher"),
                    item => item.ToString().Contains("Smokehouse Skeleton"),
                    item => item.ToString().Contains("Thalmor Triple"),
                    item => item.ToString().Contains("Thugs T-Bone")
                );
        }

        [Fact]
        public void CheckingNumbersOfDrinks()
        {
            IEnumerable<IOrderItem> d = Menu.Drinks();
            List<IOrderItem> drinks = (List<IOrderItem>)d;
            Assert.Equal(33, drinks.Count);
        }

        [Fact]
        public void CheckingEachDrinkToMakeSureItIsThere()
        {
            IEnumerable<IOrderItem> drinks = Menu.Drinks();
            foreach (Size s in Enum.GetValues(typeof(Size)))
            {
                Assert.Contains(drinks,
                    item => item.ToString().Equals(s.ToString() + " Aretino Apple Juice")
                    );
                Assert.Contains(drinks,
                    item => item.ToString().Equals(s.ToString() + " Candlehearth Coffee")
                    );
                Assert.Contains(drinks,
                    item => item.ToString().Equals(s.ToString() + " Markarth Milk"));

                foreach (SodaFlavor f in Enum.GetValues(typeof(SodaFlavor)))
                {
                    Assert.Contains(drinks,
                        item => item.ToString().Equals(s.ToString() + " " + f.ToString() + " Sailor Soda"));




                }

                Assert.Contains(drinks,
                    item => item.ToString().Equals(s.ToString() + " Warrior Water"));

            }

        }

        [Fact]
        public void CheckingNumbersOfSides()
        {
            IEnumerable<IOrderItem> s = Menu.Sides();
            List<IOrderItem> sides = (List<IOrderItem>)s;
            Assert.Equal(12, sides.Count);
        }

        [Fact]
        public void CheckingEachSideToMakeSureItIsThere()
        {
            IEnumerable<IOrderItem> sides = Menu.Sides();
            foreach (Size s in Enum.GetValues(typeof(Size)))
            {
                Assert.Contains(sides,
                    item => item.ToString().Equals(s.ToString() + " Dragonborn Waffle Fries")
                    );
                Assert.Contains(sides,
                    item => item.ToString().Equals(s.ToString() + " Fried Miraak")
                    );
                Assert.Contains(sides,
                    item => item.ToString().Equals(s.ToString() + " Mad Otar Grits")
                    );
                Assert.Contains(sides,
                    item => item.ToString().Equals(s.ToString() + " Vokun Salad")
                    );


            }
        }
    }
}
