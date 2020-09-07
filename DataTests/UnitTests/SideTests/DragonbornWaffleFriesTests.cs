/*
 * Author: Katayoun Katy Davoudi
 * Class: DragonbornWaffleFriesTests.cs
 * Purpose: Test the DragonbornWaffleFries.cs class in the Data Folder
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    /// <summary>
    /// methods provided checks price, calories, special instructions, etc.
    /// </summary>
    public class DragonbornWaffleFriesTests
    {
        /// <summary>
        /// Makes sure as set in the class (in Data Folder) the size is small
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            DragonbornWaffleFries dw = new DragonbornWaffleFries();
            Assert.Equal(Size.Small, dw.Size);
        }
        /// <summary>
        /// Sets size, checks if size statement is true  
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            DragonbornWaffleFries dw = new DragonbornWaffleFries();
            dw.Size = Size.Large;
            Assert.Equal(Size.Large, dw.Size);
            dw.Size = Size.Medium;
            Assert.Equal(Size.Medium, dw.Size);
            dw.Size = Size.Small;
            Assert.Equal(Size.Small, dw.Size);
        }
        /// <summary>
        /// returns empty special instructions because there is none
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            DragonbornWaffleFries dw = new DragonbornWaffleFries();
            Assert.Empty(dw.SpecialInstructions);
        }
        /// <summary>
        /// makes sure the correct <paramref name="price"/> is shown based on <paramref name="size"/>
        /// </summary>
        /// <param name="size">parameter for size</param>
        /// <param name="price">parameter for price</param>
        [Theory]
        [InlineData(Size.Small, 0.42)]
        [InlineData(Size.Medium, 0.76)]
        [InlineData(Size.Large, 0.96)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            DragonbornWaffleFries dw = new DragonbornWaffleFries();
            dw.Size = size;
            Assert.Equal(price, dw.Price);
        }
        /// <summary>
        ///  makes sure the correct <paramref name="calories"/> is shown based on <paramref name="size"/>
        /// </summary>
        /// <param name="size">parameter for size</param>
        /// <param name="calories">parameter for calories</param>
        [Theory]
        [InlineData(Size.Small, 77)]
        [InlineData(Size.Medium, 89)]
        [InlineData(Size.Large, 100)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            DragonbornWaffleFries dw = new DragonbornWaffleFries();
            dw.Size = size;
            Assert.Equal(calories, dw.Calories);
        }
        /// <summary>
        /// Returns the <paramref name="name"/> of the side along with the <paramref name="size"/>
        /// </summary>
        /// <param name="size">parameter for the size of the side</param>
        /// <param name="name">parameter for the name of the side</param>
        [Theory]
        [InlineData(Size.Small, "Small Dragonborn Waffle Fries")]
        [InlineData(Size.Medium, "Medium Dragonborn Waffle Fries")]
        [InlineData(Size.Large, "Large Dragonborn Waffle Fries")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            DragonbornWaffleFries dw = new DragonbornWaffleFries();
            dw.Size = size;
            Assert.Equal(name, dw.ToString());
        }
    }
}