/*
 * Author: Katayoun Katy Davoudi
 * Class: DoubleDraugrTests.cs
 * Purpose: Test the DoubleDraugr.cs class in the Data Folder
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// methods provided checks price, calories, special instructions, etc.
    /// </summary>
    public class DoubleDraugrTests
    {
        /// <summary>
        /// Makes sure as set in the class (in Data Folder) the bun is included
        /// </summary>
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Bun);
        }
        /// <summary>
        /// Makes sure as set in the class (in Data Folder) the ketchup is included
        /// </summary>
        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Ketchup);
        }
        /// <summary>
        /// Makes sure as set in the class (in Data Folder) the mustard is included
        /// </summary>
        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Mustard);
        }
        /// <summary>
        /// Makes sure as set in the class (in Data Folder) the pickle is included
        /// </summary>
        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Pickle);
        }
        /// <summary>
        /// Makes sure as set in the class (in Data Folder) the cheese is included
        /// </summary>
        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Cheese);
        }
        /// <summary>
        /// Makes sure as set in the class (in Data Folder) the tomato is included
        /// </summary>
        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Tomato);
        }
        /// <summary>
        /// Makes sure as set in the class (in Data Folder) the lettuce is included
        /// </summary>
        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Lettuce);
        }

        /// <summary>
        /// Makes sure as set in the class (in Data Folder) the mayo is included
        /// </summary>
       [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Mayo);
        }
        /// <summary>
        /// Sets bun, checks if statement is true then false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Bun = true;
            Assert.True(dd.Bun);
            dd.Bun = false;
            Assert.False(dd.Bun);
        }
        /// <summary>
        /// Sets ketchup, checks if statement is true then false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Ketchup = true;
            Assert.True(dd.Ketchup);
            dd.Ketchup = false;
            Assert.False(dd.Ketchup);
        }
        /// <summary>
        /// Sets mustard, checks if statement is true then false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Mustard = true;
            Assert.True(dd.Mustard);
            dd.Mustard = false;
            Assert.False(dd.Mustard);
        }
        /// <summary>
        /// Sets pickle, checks if statement is true then false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Pickle = true;
            Assert.True(dd.Pickle);
            dd.Pickle = false;
            Assert.False(dd.Pickle);
        }
        /// <summary>
        /// Sets cheese, checks if statement is true then false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Cheese = true;
            Assert.True(dd.Cheese);
            dd.Cheese = false;
            Assert.False(dd.Cheese);
        }
        /// <summary>
        /// Sets tomato, checks if statement is true then false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Tomato = true;
            Assert.True(dd.Tomato);
            dd.Tomato = false;
            Assert.False(dd.Tomato);
        }
        /// <summary>
        /// Sets lettuce, checks if statement is true then false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Lettuce = true;
            Assert.True(dd.Lettuce);
            dd.Lettuce = false;
            Assert.False(dd.Lettuce);
        }
        /// <summary>
        /// Sets mayo, checks if statement is true then false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Mayo = true;
            Assert.True(dd.Mayo);
            dd.Mayo = false;
            Assert.False(dd.Mayo);
        }
        /// <summary>
        /// Makes sure the correct price is returned
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.Equal(7.32, dd.Price);
        }
        /// <summary>
        /// Makes sure the correct calories is returned
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.Equal((uint) 843, dd.Calories);
        }
        /// <summary>
        /// Makes sure if special instruction has been met, for example whether to include bun or not, ketchup,
        ///  mustard, etc.
        /// </summary>
        /// <param name="includeBun">parameter for the bun</param>
        /// <param name="includeKetchup">parameter for the ketchup</param>
        /// <param name="includeMustard">parameter for the mustard</param>
        /// <param name="includePickle">parameter for the pickle</param>
        /// <param name="includeCheese">parameter for the cheese</param>
        /// <param name="includeTomato">parameter for the tomato</param>
        /// <param name="includeLettuce">parameter for the lettuce</param>
        /// <param name="includeMayo">parameter for the mayo</param>
        [Theory]
        [InlineData(true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo)
        {

            DoubleDraugr dd = new DoubleDraugr();
            dd.Bun = includeBun;
            dd.Ketchup = includeKetchup;
            dd.Mustard = includeMustard;
            dd.Pickle = includePickle;
            dd.Cheese = includeCheese;
            dd.Tomato = includeTomato;
            dd.Lettuce = includeLettuce;
            dd.Mayo = includeMayo;


            if (!includeBun) Assert.Contains("Hold bun", dd.SpecialInstructions);
            else if (!includeKetchup) Assert.Contains("Hold ketchup", dd.SpecialInstructions);
            else if (!includeMustard) Assert.Contains("Hold mustard", dd.SpecialInstructions);
            else if (!includePickle) Assert.Contains("Hold pickle", dd.SpecialInstructions);
            else if (!includeCheese) Assert.Contains("Hold cheese", dd.SpecialInstructions);
            else if (!includeTomato) Assert.Contains("Hold tomato", dd.SpecialInstructions);
            else if (!includeLettuce) Assert.Contains("Hold lettuce", dd.SpecialInstructions);
            else if (!includeMayo) Assert.Contains("Hold mayo", dd.SpecialInstructions);
        }
        /// <summary>
        /// returns the correct name of the entree
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.Equal("Double Draugr", dd.ToString());
        }
    }
}