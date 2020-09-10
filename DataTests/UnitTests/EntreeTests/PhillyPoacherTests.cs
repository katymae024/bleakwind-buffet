/*
 * Author: Katayoun Katy Davoudi
 * Class: PhillyPoacherTests.cs
 * Purpose: Test the PhillyPoacher.cs class in the Data Folder
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Entrée_classes;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// methods provided checks price, calories, special instructions, etc.
    /// </summary>
    public class PhillyPoacherTests
    {
        /// <summary>
        /// Makes sure it runs through Entree
        /// </summary>
        [Fact]
        public void ShouldBeAnEntree()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.IsAssignableFrom<Entree>(pp);
        }
        /// <summary>
        /// Makes sure as set in the class (in Data Folder) the sirloin is included
        /// </summary>
        [Fact]
        public void ShouldIncludeSirloinByDefault()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.True(pp.Sirloin);
        }
        /// <summary>
        /// Makes sure as set in the class (in Data Folder) the onion is included
        /// </summary>
        [Fact]
        public void ShouldIncludeOnionByDefault()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.True(pp.Onion);
        }
        /// <summary>
        /// Makes sure as set in the class (in Data Folder) the roll is included
        /// </summary>
        [Fact]
        public void ShouldIncludeRollByDefault()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.True(pp.Roll);
        }
        /// <summary>
        /// Sets sirloin, checks if statement is true then false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSirloin()
        {
            PhillyPoacher pp = new PhillyPoacher();
            pp.Sirloin = true;
            Assert.True(pp.Sirloin);
            pp.Sirloin = false;
            Assert.False(pp.Sirloin);
        }
        /// <summary>
        /// Sets onion, checks if statement is true then false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetOnions()
        {
            PhillyPoacher pp = new PhillyPoacher();
            pp.Onion = true;
            Assert.True(pp.Onion);
            pp.Onion = false;
            Assert.False(pp.Onion);
        }
        /// <summary>
        /// Sets roll, checks if statement is true then false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetRoll()
        {
            PhillyPoacher pp = new PhillyPoacher();
            pp.Roll = true;
            Assert.True(pp.Roll);
            pp.Roll = false;
            Assert.False(pp.Roll);
        }
        /// <summary>
        /// Makes sure the correct price is returned
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.Equal(7.23, pp.Price);
        }
        /// <summary>
        /// Makes sure the correct calories is returned
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.Equal((uint)784, pp.Calories);
        }
        /// <summary>
        /// Makes sure if special instruction has been met, for example whether to include sirloin or not, etc. 
        /// </summary>
        /// <param name="includeSirloin">parameter for the sirloin</param>
        /// <param name="includeOnion">parameter for the onion</param>
        /// <param name="includeRoll">parameter for the roll</param>
        [Theory]
        [InlineData(true, true, true)]
        [InlineData(false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSirloin, bool includeOnion,
                                                            bool includeRoll)
        {
            PhillyPoacher pp = new PhillyPoacher();
            pp.Sirloin = includeSirloin;
            pp.Onion = includeOnion;
            pp.Roll = includeRoll;

            if (!includeSirloin) Assert.Contains("Hold sirloin", pp.SpecialInstructions);
            else if (!includeOnion) Assert.Contains("Hold onion", pp.SpecialInstructions);
            else if (!includeRoll) Assert.Contains("Hold roll", pp.SpecialInstructions);

        }
        /// <summary>
        /// returns the correct name of the entree
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.Equal("Philly Poacher", pp.ToString());
        }
    }
}