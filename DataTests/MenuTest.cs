using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Interfaces;
using BleakwindBuffet.Data;
using Xunit;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests
{
    public class MenuTest
    {
        //number of items there
        [Fact]
        public void CheckingNumbersOfEntrees()
        {
            Assert.Collection<>
        }

        [Fact]
        public void CheckingEachEntreeToMakeSureItIsThere()
        {
            IEnumerable<IOrderItem> entrees = Menu.Entrees();

            Assert.Collection(entrees,
                    item => item.ToString().Contains("Briarheart Burger"),
                    item => item.ToString().Contains("Double Draugr"),


                );
        }
        
        


        [Fact]
        public void BriarheartBurgerImplementsTheIOrderItemClass()
        {
            var BriarheartBurger = new BriarheartBurger();
            Assert.IsAssignableFrom<IOrderItem>(BriarheartBurger);
        }
    }
}
