/*
 * Author: Katayoun Katy Davoudi
 * Class: MadOtarGritsTests.cs
 * Purpose: Test the MadOtarGrits.cs class in the Data Folder
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
    public class MadOtarGritsTests
    {
        /// <summary>
        /// Makes sure it runs through Side
        /// </summary>
        [Fact]
        public void ShouldBeASide()
        {
            MadOtarGrits mg = new MadOtarGrits();
            Assert.IsAssignableFrom<Side>(mg);
        }
        /// <summary>
        /// Makes sure as set in the class (in Data Folder) the size is small
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            MadOtarGrits mg = new MadOtarGrits();
            Assert.Equal(Size.Small, mg.Size);
        }
        /// <summary>
        /// Sets size, checks if size statement is true  
        /// </summary>        
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            MadOtarGrits mg = new MadOtarGrits();
            mg.Size = Size.Large;
            Assert.Equal(Size.Large, mg.Size);
            mg.Size = Size.Medium;
            Assert.Equal(Size.Medium, mg.Size);
            mg.Size = Size.Small;
            Assert.Equal(Size.Small, mg.Size);
        }
        /// <summary>
        /// returns empty special instructions because there is none
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectStringOnSpecialInstructions()
        {
            MadOtarGrits mg = new MadOtarGrits();
            Assert.Empty(mg.SpecialInstructions);
        }
        /// <summary>
        /// makes sure the correct <paramref name="price"/> is shown based on <paramref name="size"/>
        /// </summary>
        /// <param name="size">parameter for size</param>
        /// <param name="price">parameter for price</param>
        [Theory]
        [InlineData(Size.Small, 1.22)]
        [InlineData(Size.Medium, 1.58)]
        [InlineData(Size.Large, 1.93)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            MadOtarGrits mg = new MadOtarGrits();
            mg.Size = size;
            Assert.Equal(price, mg.Price);
        }
        /// <summary>
        ///  makes sure the correct <paramref name="calories"/> is shown based on <paramref name="size"/>
        /// </summary>
        /// <param name="size">parameter for size</param>
        /// <param name="calories">parameter for calories</param>
        [Theory]
        [InlineData(Size.Small, 105)]
        [InlineData(Size.Medium, 142)]
        [InlineData(Size.Large, 179)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            MadOtarGrits mg = new MadOtarGrits();
            mg.Size = size;
            Assert.Equal(calories, mg.Calories);
        }
        /// <summary>
        /// Returns the <paramref name="name"/> of the side along with the <paramref name="size"/>
        /// </summary>
        /// <param name="size">parameter for the size of the side</param>
        /// <param name="name">parameter for the name of the side</param>
        [Theory]
        [InlineData(Size.Small, "Small Mad Otar Grits")]
        [InlineData(Size.Medium, "Medium Mad Otar Grits")]
        [InlineData(Size.Large, "Large Mad Otar Grits")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            MadOtarGrits mg = new MadOtarGrits();
            mg.Size = size;
            Assert.Equal(name, mg.ToString());
        }
        /// <summary>
        /// making sure properties are changed correctly
        /// </summary>
        [Fact]
        public void ChangingSizeNotifiesSizeProperties()
        {
            var MOG = new MadOtarGrits();
            Assert.PropertyChanged(MOG, "Size", () =>
            {
                MOG.Size = Size.Small;

            });

            Assert.PropertyChanged(MOG, "Size", () =>
            {
                MOG.Size = Size.Medium;

            });

            Assert.PropertyChanged(MOG, "Size", () =>
            {
                MOG.Size = Size.Large;

            });

        }
        /// <summary>
        /// making sure properties are changed correctly
        /// </summary>
        [Fact]
        public void ChangingPriceNotifiesPriceProperties()
        {
            var MOG = new MadOtarGrits();
            Assert.PropertyChanged(MOG, "Price", () =>
            {
                MOG.Size = Size.Small;

            });

            Assert.PropertyChanged(MOG, "Price", () =>
            {
                MOG.Size = Size.Medium;

            });

            Assert.PropertyChanged(MOG, "Price", () =>
            {
                MOG.Size = Size.Large;

            });

        }
        /// <summary>
        /// making sure properties are changed correctly
        /// </summary>
        [Fact]
        public void ChangingCaloriesNotifiesCaloriesProperties()
        {
            var MOG = new MadOtarGrits();
            Assert.PropertyChanged(MOG, "Calories", () =>
            {
                MOG.Size = Size.Small;

            });

            Assert.PropertyChanged(MOG, "Calories", () =>
            {
                MOG.Size = Size.Medium;

            });

            Assert.PropertyChanged(MOG, "Calories", () =>
            {
                MOG.Size = Size.Large;

            });

        }
        /// <summary>
        /// checking the description to see if correct
        /// </summary>
        /// <param name="description"></param>
        [Theory]
        [InlineData("Cheesey Grits.")]
        public void ShouldBeRightDescription(string description)
        {
            MadOtarGrits mg = new MadOtarGrits();

            Assert.Equal(description, mg.Description);
        }

    }
}