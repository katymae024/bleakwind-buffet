/*
 * Author: Katayoun Katy Davoudi
 * Class: VokunSaladTests.cs
 * Purpose: Test the VokunSalad.cs class in the Data Folder
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Side_Classes;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    /// <summary>
    /// methods provided checks price, calories, special instructions, etc.
    /// </summary>
    public class VokunSaladTests
    {
        /// <summary>
        /// Makes sure it runs through Side
        /// </summary>
        [Fact]
        public void ShouldBeASide()
        {
            VokunSalad vs = new VokunSalad();
            Assert.IsAssignableFrom<Side>(vs);
        }
        /// <summary>
        /// Makes sure as set in the class (in Data Folder) the size is small
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            VokunSalad vs = new VokunSalad();
            Assert.Equal(Size.Small, vs.Size);

        }
        /// <summary>
        /// Sets size, checks if size statement is true  
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            VokunSalad vs = new VokunSalad();
            vs.Size = Size.Large;
            Assert.Equal(Size.Large, vs.Size);
            vs.Size = Size.Medium;
            Assert.Equal(Size.Medium, vs.Size);
            vs.Size = Size.Small;
            Assert.Equal(Size.Small, vs.Size);
        }
        /// <summary>
        /// returns empty special instructions because there is none
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            VokunSalad vs = new VokunSalad();
            Assert.Empty(vs.SpecialInstructions);
        }
        /// <summary>
        /// makes sure the correct <paramref name="price"/> is shown based on <paramref name="size"/>
        /// </summary>
        /// <param name="size">parameter for size</param>
        /// <param name="price">parameter for price</param>
        [Theory]
        [InlineData(Size.Small, 0.93)]
        [InlineData(Size.Medium, 1.28)]
        [InlineData(Size.Large, 1.82)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            VokunSalad vs = new VokunSalad();
            vs.Size = size;
            Assert.Equal(price, vs.Price);
        }
        /// <summary>
        ///  makes sure the correct <paramref name="calories"/> is shown based on <paramref name="size"/>
        /// </summary>
        /// <param name="size">parameter for size</param>
        /// <param name="calories">parameter for calories</param>
        [Theory]
        [InlineData(Size.Small, 41)]
        [InlineData(Size.Medium, 52)]
        [InlineData(Size.Large, 73)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            VokunSalad vs = new VokunSalad();
            vs.Size = size;
            Assert.Equal(calories, vs.Calories);
        }
        /// <summary>
        /// Returns the <paramref name="name"/> of the side along with the <paramref name="size"/>
        /// </summary>
        /// <param name="size">parameter for the size of the side</param>
        /// <param name="name">parameter for the name of the side</param>
        [Theory]
        [InlineData(Size.Small, "Small Vokun Salad")]
        [InlineData(Size.Medium, "Medium Vokun Salad")]
        [InlineData(Size.Large, "Large Vokun Salad")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            VokunSalad vs = new VokunSalad();
            vs.Size = size;
            Assert.Equal(name, vs.ToString());
        }
        /// <summary>
        /// making sure properties are changed correctly
        /// </summary>
        [Fact]
        public void ChangingSizeNotifiesSizeProperties()
        {
            var VS = new VokunSalad();
            Assert.PropertyChanged(VS, "Size", () =>
            {
                VS.Size = Size.Small;

            });

            Assert.PropertyChanged(VS, "Size", () =>
            {
                VS.Size = Size.Medium;

            });

            Assert.PropertyChanged(VS, "Size", () =>
            {
                VS.Size = Size.Large;

            });

        }
        /// <summary>
        /// making sure properties are changed correctly
        /// </summary>
        [Fact]
        public void ChangingPriceNotifiesPriceProperties()
        {
            var VS = new VokunSalad();
            Assert.PropertyChanged(VS, "Price", () =>
            {
                VS.Size = Size.Small;

            });

            Assert.PropertyChanged(VS, "Price", () =>
            {
                VS.Size = Size.Medium;

            });

            Assert.PropertyChanged(VS, "Price", () =>
            {
                VS.Size = Size.Large;

            });

        }
        /// <summary>
        /// making sure properties are changed correctly
        /// </summary>
        [Fact]
        public void ChangingCaloriesNotifiesCaloriesProperties()
        {
            var VS = new VokunSalad();
            Assert.PropertyChanged(VS, "Calories", () =>
            {
                VS.Size = Size.Small;

            });

            Assert.PropertyChanged(VS, "Calories", () =>
            {
                VS.Size = Size.Medium;

            });

            Assert.PropertyChanged(VS, "Calories", () =>
            {
                VS.Size = Size.Large;

            });

        }
    }
}