/*
 * Author: Zachery Brunner
 * Class: CandlehearthCoffeeTests.cs
 * Purpose: Test the CandlehearthCoffee.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class CandlehearthCoffeeTests
    {
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.False(cc.Ice);
        }

        [Fact]
        public void ShouldNotBeDecafByDefault()
        {
        }

        [Fact]
        public void ShouldNotHaveRoomForCreamByDefault()
        {
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.Equal(Size.Small, cc.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.Ice = true;
            Assert.True(cc.Ice);
            cc.Ice = false;
            Assert.False(cc.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetDecaf()
        {
        }

        [Fact]
        public void ShouldBeAbleToSetRoomForCream()
        {
        }

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

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeCream)
        {
        }

        [Theory]
        [InlineData(true, Size.Small, "Small Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Medium, "Medium Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Large, "Large Decaf Candlehearth Coffee")]
        [InlineData(false, Size.Small, "Small Candlehearth Coffee")]
        [InlineData(false, Size.Medium, "Medium Candlehearth Coffee")]
        [InlineData(false, Size.Large, "Large Candlehearth Coffee")]
        public void ShouldReturnCorrectToStringBasedOnSize(bool decaf, Size size, string name)
        {
            
        }
    }
}
