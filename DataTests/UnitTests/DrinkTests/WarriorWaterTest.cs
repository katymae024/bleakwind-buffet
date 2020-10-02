/*
 * Author: Katayoun Katy Davoudi
 * Class: WarriorWaterTest.cs
 * Purpose: Test the WarriorWater.cs class in the Data Folder
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;


namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    /// <summary>
    /// methods provided checks size, price, calories, special instructions, etc.
    /// </summary>
    public class WorrierWaterTest
    {
        /// <summary>
        /// Makes sure it runs through Drink
        /// </summary>
        [Fact]
        public void ShouldBeADrink()
        {
            WarriorWater ww = new WarriorWater();
            Assert.IsAssignableFrom<Drink>(ww);
        }
        /// <summary>
        /// Makes sure as set in the class (in Data Folder) the ice is included
        /// </summary>
        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            WarriorWater ww = new WarriorWater();
            Assert.True(ww.Ice);
        }

        /// <summary>
        /// Makes sure as set in the class (in Data Folder) the lemon is included
        /// </summary>
        [Fact]
        public void ShouldNotIncludeLemonByDefault()
        {
            WarriorWater ww = new WarriorWater();
            Assert.False(ww.Lemon);
        }
        /// <summary>
        /// Makes sure as set in the class (in Data Folder) the size is small
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            WarriorWater ww = new WarriorWater();
            Assert.Equal(Size.Small, ww.Size);
        }
        /// <summary>
        /// Sets ice, checks if statement is true then false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            WarriorWater ww = new WarriorWater();
            ww.Ice = true;
            Assert.True(ww.Ice);
            ww.Ice = false;
            Assert.False(ww.Ice);
        }
        /// <summary>
        /// Sets lemon, checks if statement is true then false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetLemon()
        {
            WarriorWater ww = new WarriorWater();
            ww.Lemon = true;
            Assert.True(ww.Lemon);
            ww.Lemon = false;
            Assert.False(ww.Lemon);
        }
        /// <summary>
        /// Sets size, checks if size statement is true  
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            WarriorWater ww = new WarriorWater();
            ww.Size = Size.Large;
            Assert.Equal(Size.Large, ww.Size);
            ww.Size = Size.Medium;
            Assert.Equal(Size.Medium, ww.Size);
            ww.Size = Size.Small;
            Assert.Equal(Size.Small, ww.Size);
        }
        /// <summary>
        /// makes sure the <paramref name="size"/> of the drinks gets the correct <paramref name="price"/>
        /// </summary>
        /// <param name="size"> parameter for sizes of the drink</param>
        /// <param name="price">parameter for prices of the drink</param>
        [Theory]
        [InlineData(Size.Small, 0.00)]
        [InlineData(Size.Medium, 0.00)]
        [InlineData(Size.Large, 0.00)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            WarriorWater ww = new WarriorWater();
            ww.Size = size;
            Assert.Equal(price, ww.Price);
        }
        /// <summary>
        /// makes sure the <paramref name="size"/> of the drinks gets the correct <paramref name="cal"/>
        /// </summary>
        /// <param name="size">parameter for <paramref name="size"/> of the drink</param>
        /// <param name="cal">parameter for <paramref name="cal"/> of the drink</param>
        [Theory]
        [InlineData(Size.Small, 0)]
        [InlineData(Size.Medium, 0)]
        [InlineData(Size.Large, 0)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            WarriorWater ww = new WarriorWater();
            ww.Size = size;
            Assert.Equal(cal, ww.Calories);
        }
        /// <summary>
        /// Makes sure if special instruction has been met, for example whether to include ice or not
        /// </summary>
        /// <param name="includeIce">parameter for including ice or not</param>
        /// <param name="includeLemon">parameter for including lemon or not</param>
        [Theory]
        [InlineData(true, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeLemon)
        {
            WarriorWater ww = new WarriorWater();
            ww.Ice = includeIce;
            ww.Lemon = includeLemon;
            if (!includeIce) Assert.Contains("Hold ice", ww.SpecialInstructions);
            else if(includeLemon) Assert.Contains("Add lemon", ww.SpecialInstructions);

        }
        /// <summary>
        /// Returns the <paramref name="name"/> of the drink along with the <paramref name="size"/>
        /// </summary>
        /// <param name="size">parameter for the size of the drink</param>
        /// <param name="name">parameter for the name of the drink</param>
        [Theory]
        [InlineData(Size.Small, "Small Warrior Water")]
        [InlineData(Size.Medium, "Medium Warrior Water")]
        [InlineData(Size.Large, "Large Warrior Water")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            WarriorWater ww = new WarriorWater();
            ww.Size = size;
            Assert.Equal(name, ww.ToString());
        }
        /// <summary>
        /// making sure properties are changed correctly
        /// </summary>
        [Fact]
        public void ChangingIceNotifiesIceProperties()
        {
            var WW = new WarriorWater();

            Assert.PropertyChanged(WW, "Ice", () =>
            {
                WW.Ice = true;
            });

            Assert.PropertyChanged(WW, "Ice", () =>
            {
                WW.Ice = false;
            });

            
            


        }
        /// <summary>
        /// making sure properties are changed correctly
        /// </summary>
        [Fact]
        public void ChangingLemonNotifiesLemonProperties()
        {
            var WW = new WarriorWater();
            Assert.PropertyChanged(WW, "Lemon", () =>
            {
                WW.Lemon = true;
            });
            Assert.PropertyChanged(WW, "Lemon", () =>
            {
                WW.Lemon = false;
            });
        }
        /// <summary>
        /// making sure properties are changed correctly
        /// </summary>
        [Fact]
        public void ChangingSizeNotifiesSizeProperties()
        {
            var WW = new WarriorWater();
            Assert.PropertyChanged(WW, "Size", () =>
            {
                WW.Size = Size.Small;

            });

            Assert.PropertyChanged(WW, "Size", () =>
            {
                WW.Size = Size.Medium;
            });

            Assert.PropertyChanged(WW, "Size", () =>
            {
                WW.Size = Size.Large;
            });
        }
        /// <summary>
        /// making sure properties are changed correctly
        /// </summary>
        [Fact]
        public void ChangingPriceNotifiesPriceProperties()
        {
            var WW = new WarriorWater();
            Assert.PropertyChanged(WW, "Price", () =>
            {
                WW.Size = Size.Small;
            });
            Assert.PropertyChanged(WW, "Price", () =>
            {
                WW.Size = Size.Medium;
            });
            Assert.PropertyChanged(WW, "Price", () =>
            {
                WW.Size = Size.Large;
            });
        }
        /// <summary>
        /// making sure properties are changed correctly
        /// </summary>
        [Fact]
        public void ChangingCaloriesNotifiesCaloriesProperties()
        {
            var WW = new WarriorWater();
            Assert.PropertyChanged(WW, "Calories", () =>
            {
                WW.Size = Size.Small;
            });
            Assert.PropertyChanged(WW, "Calories", () =>
            {
                WW.Size = Size.Medium;
            });
            Assert.PropertyChanged(WW, "Calories", () =>
            {
                WW.Size = Size.Large;
            });



        }

    }
}
