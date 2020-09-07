/*
 * Author: Katayoun Katy Davoudi
 * Class: FriedMirrakTests.cs
 * Purpose: Test the FriedMirrak.cs class in the Data Folder
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
    public class FriedMiraakTests
    {
        /// <summary>
        /// Makes sure as set in the class (in Data Folder) the size is small
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            FriedMiraak fm = new FriedMiraak();
            Assert.Equal(Size.Small, fm.Size);
        }
        /// <summary>
        /// Sets size, checks if size statement is true  
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            FriedMiraak fm = new FriedMiraak();
            fm.Size = Size.Large;
            Assert.Equal(Size.Large, fm.Size);
            fm.Size = Size.Medium;
            Assert.Equal(Size.Medium, fm.Size);
            fm.Size = Size.Small;
            Assert.Equal(Size.Small, fm.Size);
        }
        /// <summary>
        /// returns empty special instructions because there is none
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            FriedMiraak fm = new FriedMiraak();
            Assert.Empty(fm.SpecialInstructions);
        }
        /// <summary>
        /// makes sure the correct <paramref name="price"/> is shown based on <paramref name="size"/>
        /// </summary>
        /// <param name="size">parameter for size</param>
        /// <param name="price">parameter for price</param>
        [Theory]
        [InlineData(Size.Small, 1.78)]
        [InlineData(Size.Medium, 2.01)]
        [InlineData(Size.Large, 2.88)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            FriedMiraak fm = new FriedMiraak();
            fm.Size = size;
            Assert.Equal(price, fm.Price);
        }
        /// <summary>
        ///  makes sure the correct <paramref name="calories"/> is shown based on <paramref name="size"/>
        /// </summary>
        /// <param name="size">parameter for size</param>
        /// <param name="calories">parameter for calories</param>
        [Theory]
        [InlineData(Size.Small, 151)]
        [InlineData(Size.Medium, 236)]
        [InlineData(Size.Large, 306)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            FriedMiraak fm = new FriedMiraak();
            fm.Size = size;
            Assert.Equal(calories, fm.Calories);
        }
        /// <summary>
        /// Returns the <paramref name="name"/> of the side along with the <paramref name="size"/>
        /// </summary>
        /// <param name="size">parameter for the size of the side</param>
        /// <param name="name">parameter for the name of the side</param>
        [Theory]
        [InlineData(Size.Small, "Small Fried Miraak")]
        [InlineData(Size.Medium, "Medium Fried Miraak")]
        [InlineData(Size.Large, "Large Fried Miraak")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            FriedMiraak fm = new FriedMiraak();
            fm.Size = size;
            Assert.Equal(name, fm.ToString());
        }
    }
}