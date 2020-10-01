/*
 * Author: Katayoun Katy Davoudi
 * Class: AretinoAppleJuiceTests.cs
 * Purpose: Test the AretinoAppleJuice.cs class in the Data Folder
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
    public class AretinoAppleJuiceTests
    {
        /// <summary>
        /// Makes sure it runs through Drink
        /// </summary>
        [Fact]
        public void ShouldBeADrink()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Assert.IsAssignableFrom<Drink>(aj);
        }
        /// <summary>
        /// Makes sure as set in the class (in Data Folder) the ice is not included
        /// </summary>
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Assert.False(aj.Ice);
        }

        /// <summary>
        /// Makes sure as set in the class (in Data Folder) the size is small
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Assert.Equal(Size.Small, aj.Size);
        }

        /// <summary>
        /// Sets ice, checks if statement is true then false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            aj.Ice = true; 
            Assert.True(aj.Ice);
            aj.Ice = false;
            Assert.False(aj.Ice);
        }

        /// <summary>
        /// Sets size, checks if size statement is true  
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            aj.Size = Size.Large;
            Assert.Equal(Size.Large, aj.Size);
            aj.Size = Size.Medium;
            Assert.Equal(Size.Medium, aj.Size);
            aj.Size = Size.Small;
            Assert.Equal(Size.Small, aj.Size);
        }

        /// <summary>
        /// makes sure the <paramref name="size"/> of the drinks gets the correct <paramref name="price"/>
        /// </summary>
        /// <param name="size"> parameter for sizes of the drink</param>
        /// <param name="price">parameter for prices of the drink</param>
        [Theory]
        [InlineData(Size.Small, 0.62)]
        [InlineData(Size.Medium, 0.87)]
        [InlineData(Size.Large, 1.01)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            aj.Size = size;
            Assert.Equal(price, aj.Price);
        }

        /// <summary>
        /// makes sure the <paramref name="size"/> of the drinks gets the correct <paramref name="cal"/>
        /// </summary>
        /// <param name="size">parameter for <paramref name="size"/> of the drink</param>
        /// <param name="cal">parameter for <paramref name="cal"/> of the drink</param>
        [Theory]
        [InlineData(Size.Small, 44)]
        [InlineData(Size.Medium, 88)]
        [InlineData(Size.Large, 132)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            aj.Size = size;
            Assert.Equal(cal, aj.Calories);
        }

        /// <summary>
        /// Makes sure if special instruction has been met, for example whether to include ice or not
        /// </summary>
        /// <param name="includeIce">parameter for including ice or not</param>
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            aj.Ice = includeIce;
            if (includeIce) Assert.Contains("Add ice", aj.SpecialInstructions);
            else Assert.Empty(aj.SpecialInstructions);

        }

        /// <summary>
        /// Returns the <paramref name="name"/> of the drink along with the <paramref name="size"/>
        /// </summary>
        /// <param name="size">parameter for the size of the drink</param>
        /// <param name="name">parameter for the name of the drink</param>
        [Theory]
        [InlineData(Size.Small, "Small Aretino Apple Juice")]
        [InlineData(Size.Medium, "Medium Aretino Apple Juice")]
        [InlineData(Size.Large, "Large Aretino Apple Juice")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            aj.Size = size;
            Assert.Equal(name, aj.ToString()); 
        }
        [Fact]
        public void ChangingIceNotifiesIceProperty()
        {
            var AJ = new AretinoAppleJuice();

            Assert.PropertyChanged(AJ, "Ice", () =>
            {
                AJ.Ice = true;
            });

            Assert.PropertyChanged(AJ, "Ice", () =>
            {
                AJ.Ice = false;
            });
        }
    }
}