/*
 * Author: Katayoun Katy Davoudi
 * Class: BriarheatBurgerTests.cs
 * Purpose: Test the BriarheartBurger.cs class in the Data Folder
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Entrée_classes;
using BleakwindBuffet.Data.Interfaces;


namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// methods provided checks price, calories, special instructions, etc.
    /// </summary>
    public class BriarheartBurgerTests
    {
        /// <summary>
        /// Makes sure it runs through Drink
        /// </summary>
        [Fact]
        public void ShouldBeAnEntree()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.IsAssignableFrom<Entree>(bb);
        }
        /// <summary>
        /// Makes sure as set in the class (in Data Folder) the bun is included
        /// </summary>
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.True(bb.Bun);

        }
        /// <summary>
        /// Makes sure as set in the class (in Data Folder) the ketchup is included
        /// </summary>
        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.True(bb.Ketchup);
        }
        /// <summary>
        /// Makes sure as set in the class (in Data Folder) the mustard is included
        /// </summary>
        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.True(bb.Mustard);
        }
        /// <summary>
        /// Makes sure as set in the class (in Data Folder) the pickle is included
        /// </summary>
        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.True(bb.Pickle);
        }
        /// <summary>
        /// Makes sure as set in the class (in Data Folder) the cheese is included
        /// </summary>
        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.True(bb.Cheese);
        }
        /// <summary>
        /// Sets bun, checks if statement is true then false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            BriarheartBurger bb = new BriarheartBurger();
            bb.Bun = true;
            Assert.True(bb.Bun);
            bb.Bun = false;
            Assert.False(bb.Bun);
        }
        /// <summary>
        /// Sets ketchup, checks if statement is true then false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            BriarheartBurger bb = new BriarheartBurger();
            bb.Ketchup = true;
            Assert.True(bb.Ketchup);
            bb.Ketchup = false;
            Assert.False(bb.Ketchup);
        }
        /// <summary>
        /// Sets mustard, checks if statement is true then false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            BriarheartBurger bb = new BriarheartBurger();
            bb.Mustard = true;
            Assert.True(bb.Mustard);
            bb.Mustard = false;
            Assert.False(bb.Mustard);
        }
        /// <summary>
        /// Sets pickle, checks if statement is true then false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            BriarheartBurger bb = new BriarheartBurger();
            bb.Pickle = true;
            Assert.True(bb.Pickle);
            bb.Pickle = false;
            Assert.False(bb.Pickle);
        }
        /// <summary>
        /// Sets cheese, checks if statement is true then false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            BriarheartBurger bb = new BriarheartBurger();
            bb.Cheese = true;
            Assert.True(bb.Cheese);
            bb.Cheese = false;
            Assert.False(bb.Cheese);
        }
        /// <summary>
        /// Makes sure the correct price is returned
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.Equal(6.32, bb.Price);
        }
        /// <summary>
        /// Makes sure the correct calories is returned
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.Equal((uint) 743, bb.Calories);
        }
        /// <summary>
        ///  Makes sure if special instruction has been met, for example whether to include bun or not, ketchup,
        ///  mustard, etc.
        /// </summary>
        /// <param name="includeBun">parameter for the bun</param>
        /// <param name="includeKetchup">parameter for the ketchup </param>
        /// <param name="includeMustard">parameter for the mustard</param>
        /// <param name="includePickle">parameter for the pickle</param>
        /// <param name="includeCheese">parameter for the cheese</param>
        [Theory]
        [InlineData(true, true, true, true, true)]
        [InlineData(false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese)
        {
            BriarheartBurger bb = new BriarheartBurger();
            
            bb.Bun = includeBun;
            bb.Ketchup = includeKetchup;
            bb.Mustard = includeMustard;
            bb.Pickle = includePickle;
            bb.Cheese = includeCheese;
            
            if (!includeBun) Assert.Contains("Hold bun", bb.SpecialInstructions);
            else if (!includeKetchup) Assert.Contains("Hold ketchup", bb.SpecialInstructions);
            else if (!includeMustard) Assert.Contains("Hold mustard", bb.SpecialInstructions);
            else if (!includePickle) Assert.Contains("Hold pickle", bb.SpecialInstructions);
            else if (!includeCheese) Assert.Contains("Hold cheese", bb.SpecialInstructions);
            
        }
        /// <summary>
        /// returns the correct name of the entree
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.Equal("Briarheart Burger", bb.ToString());
        }
        /// <summary>
        /// checks if entree is implemented in the IOrderItem Class
        /// </summary>
        [Fact]
        public void BriarheartBurgerImplementsTheIOrderItemClass()
        {
            var BriarheartBurger = new BriarheartBurger();
            Assert.IsAssignableFrom<IOrderItem>(BriarheartBurger);
        }
        [Fact]
        public void ChangingIceNotifiesIceProperty()
        {
            var BB = new BriarheartBurger();

            Assert.PropertyChanged(BB, "Ketchup", () =>
            {
                BB.Ketchup = true;
            });

            Assert.PropertyChanged(BB, "Ketchup", () =>
            {
                BB.Ketchup = false;
            });
        }
    }
}