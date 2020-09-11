using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Interfaces;
using BleakwindBuffet.Data;
using Xunit;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;


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
            Assert.Equal(5, drinks.Count);
        }

        [Fact]
        public void CheckingEachDrinkToMakeSureItIsThere()
        {

        }





        [Fact]
        public void BriarheartBurgerImplementsTheIOrderItemClass()
        {
            var BriarheartBurger = new BriarheartBurger();
            Assert.IsAssignableFrom<IOrderItem>(BriarheartBurger);
        }
    }
}
