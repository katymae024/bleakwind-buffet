﻿/*
 * Author: Katayoun Katy Davoudi
 * Class: CandlehearthCoffeeTests.cs
 * Purpose: Test the CandlehearthCoffee.cs class in the Data Folder
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drink_Classes;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    /// <summary>
    /// methods provided checks size, price, calories, special instructions, etc.
    /// </summary>
    public class CandlehearthCoffeeTests
    {
        /// <summary>
        /// Makes sure it runs through Drink
        /// </summary>
        [Fact]
        public void ShouldBeADrink()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.IsAssignableFrom<Drink>(cc);
        }
        /// <summary>
        /// Makes sure as set in the class (in Data Folder) the ice is not included
        /// </summary>
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.False(cc.Ice);
        }
        /// <summary>
        /// Makes sure as set in the class (in Data Folder) Decaf is not default
        /// </summary>
        [Fact]
        public void ShouldNotBeDecafByDefault()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.False(cc.Decaf);
        }

        /// <summary>
        /// Makes sure as set in the class (in Data Folder) room for cream is not default
        /// </summary>
        [Fact]
        public void ShouldNotHaveRoomForCreamByDefault()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.False(cc.RoomForCream);
        }

        /// <summary>
        /// Makes sure as set in the class (in Data Folder) the size is small 
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.Equal(Size.Small, cc.Size);
        }
        /// <summary>
        ///  Sets ice, checks if statement is true then false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.Ice = true;
            Assert.True(cc.Ice);
            cc.Ice = false;
            Assert.False(cc.Ice);
        }

        /// <summary>
        ///  Sets decaf, checks if statement is true then false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetDecaf()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.Decaf = true;
            Assert.True(cc.Decaf);
            cc.Decaf = false;
            Assert.False(cc.Decaf);
        }
        /// <summary>
        ///  Sets room for cream, checks if statement is true then false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetRoomForCream()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.RoomForCream = true;
            Assert.True(cc.RoomForCream);
            cc.RoomForCream = false;
            Assert.False(cc.RoomForCream);
        }
        /// <summary>
        ///  Sets size, checks if statement is true
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.Size = Size.Large;
            Assert.Equal(Size.Large, cc.Size);
            cc.Size = Size.Medium;
            Assert.Equal(Size.Medium, cc.Size);
            cc.Size = Size.Small;
            Assert.Equal(Size.Small, cc.Size);
        }
        /// <summary>
        /// makes sure the <paramref name="size"/> of the drinks gets the correct <paramref name="price"/>
        /// </summary>
        /// <param name="size"> parameter for sizes of the drink</param>
        /// <param name="price">parameter for prices of the drink</param>
        [Theory]
        [InlineData(Size.Small, 0.75)]
        [InlineData(Size.Medium, 1.25)]
        [InlineData(Size.Large, 1.75)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.Size = size;
            Assert.Equal(price, cc.Price);
        }
        /// <summary>
        /// makes sure the <paramref name="size"/> of the drinks gets the correct <paramref name="cal"/>
        /// </summary>
        /// <param name="size">parameter for <paramref name="size"/> of the drink</param>
        /// <param name="cal">parameter for <paramref name="cal"/> of the drink</param>
        [Theory]
        [InlineData(Size.Small, 7)]
        [InlineData(Size.Medium, 10)]
        [InlineData(Size.Large, 20)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.Size = size;
            Assert.Equal(cal, cc.Calories);
        }
        /// <summary>
        /// Makes sure if special instruction has been met, for example whether to include ice or not
        /// </summary>
        /// <param name="includeIce">parameter for including ice or not</param>
        /// <param name="includeCream">parameter for including cream or not</param>
        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeCream)
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.Ice = includeIce;
            cc.RoomForCream = includeCream;
            if (includeIce == false && includeCream == false) Assert.Empty(cc.SpecialInstructions);
            else if (includeIce == true) Assert.Contains("Add ice", cc.SpecialInstructions);
            else if (includeCream == true) Assert.Contains("Add cream", cc.SpecialInstructions);
            

        }
        /// <summary>
        /// Returns the <paramref name="name"/> of the drink along with the <paramref name="size"/> and 
        /// whether it's decaf or not
        /// </summary>
        /// <param name="decaf">parameter for drink being decaf or not</param>
        /// <param name="size">parameter for the size of the drink</param>
        /// <param name="name">parameter for the name of the drink</param>
        [Theory]
        [InlineData(true, Size.Small, "Small Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Medium, "Medium Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Large, "Large Decaf Candlehearth Coffee")]
        [InlineData(false, Size.Small, "Small Candlehearth Coffee")]
        [InlineData(false, Size.Medium, "Medium Candlehearth Coffee")]
        [InlineData(false, Size.Large, "Large Candlehearth Coffee")]
        public void ShouldReturnCorrectToStringBasedOnSize(bool decaf, Size size, string name)
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.Size = size;
            cc.Decaf = decaf;
            Assert.Equal(name, cc.ToString());

        }

        /// <summary>
        /// making sure properties are changed correctly
        /// </summary>
        [Fact]
        public void ChangingIceNotifiesIceProperties()
        {
            var CC = new CandlehearthCoffee();

            Assert.PropertyChanged(CC, "Ice", () =>
            {
                CC.Ice = true;
            });

            Assert.PropertyChanged(CC, "Ice", () =>
            {
                CC.Ice = false;
            });

        }
        /// <summary>
        /// making sure properties are changed correctly
        /// </summary>
        [Fact]
        public void ChangingDecafNotifiesDecafProperties()
        {
            var CC = new CandlehearthCoffee();
            Assert.PropertyChanged(CC, "Decaf", () =>
            {
                CC.Decaf = true;
            });
            Assert.PropertyChanged(CC, "Decaf", () =>
            {
                CC.Decaf = false;
            });

        }
        /// <summary>
        /// making sure properties are changed correctly
        /// </summary>
        [Fact]
        public void ChangingRoomForCreamNotifiesRoomForCreamProperties()
        {
            var CC = new CandlehearthCoffee();


            Assert.PropertyChanged(CC, "RoomForCream", () =>
            {
                CC.RoomForCream = true;
            });
            Assert.PropertyChanged(CC, "RoomForCream", () =>
            {
                CC.RoomForCream = false;
            });
        }

        /// <summary>
        /// making sure properties are changed correctly
        /// </summary>
        [Fact]
        public void ChangingSizeNotifiesSizeProperties()
        {
            var CC = new CandlehearthCoffee();
            Assert.PropertyChanged(CC, "Size", () =>
            {
                CC.Size = Size.Small;

            });

            Assert.PropertyChanged(CC, "Size", () =>
            {
                CC.Size = Size.Medium;
            });

            Assert.PropertyChanged(CC, "Size", () =>
            {
                CC.Size = Size.Large;
            });
        }
        /// <summary>
        /// making sure properties are changed correctly
        /// </summary>
        [Fact]
        public void ChangingPriceNotifiesPriceProperties()
        {
            var CC = new CandlehearthCoffee();
            Assert.PropertyChanged(CC, "Price", () =>
            {
                CC.Size = Size.Small;
            });
            Assert.PropertyChanged(CC, "Price", () =>
            {
                CC.Size = Size.Medium;
            });
            Assert.PropertyChanged(CC, "Price", () =>
            {
                CC.Size = Size.Large;
            });
        }
        /// <summary>
        /// making sure properties are changed correctly
        /// </summary>
        [Fact]
        public void ChangingCaloriesNotifiesCaloriesProperties()
        {
            var CC = new CandlehearthCoffee();
            Assert.PropertyChanged(CC, "Calories", () =>
            {
                CC.Size = Size.Small;
            });
            Assert.PropertyChanged(CC, "Calories", () =>
            {
                CC.Size = Size.Medium;
            });
            Assert.PropertyChanged(CC, "Calories", () =>
            {
                CC.Size = Size.Large;
            });

        }
        /// <summary>
        /// checking the description to see if correct
        /// </summary>
        /// <param name="description"></param>
        [Theory]
        [InlineData("Fair trade, fresh ground dark roast coffee.")]
        public void ShouldBeRightDescription(string description)
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();

            Assert.Equal(description, cc.Description);
        }

    }
}
