﻿/*
 * Author: Katayoun Katy Davoudi
 * Class: ThalmorTripleTests.cs
 * Purpose: Test the ThalmorTriple.cs class in the Data Folder
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
    public class ThalmorTripleTests
    {
        /// <summary>
        /// Makes sure it runs through Drink
        /// </summary>
        [Fact]
        public void ShouldBeAnEntree()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.IsAssignableFrom<Entree>(tt);
        }
        /// <summary>
        /// Makes sure as set in the class (in Data Folder) the bun is included
        /// </summary>
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Bun);
        }
        /// <summary>
        /// Makes sure as set in the class (in Data Folder) the ketchup is included
        /// </summary>
        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Ketchup);
        }
        /// <summary>
        /// Makes sure as set in the class (in Data Folder) the mustard is included
        /// </summary>
        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Mustard);
        }
        /// <summary>
        /// Makes sure as set in the class (in Data Folder) the pickle is included
        /// </summary>
        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Pickle);
        }
        /// <summary>
        /// Makes sure as set in the class (in Data Folder) the cheese is included
        /// </summary>
        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Cheese);
        }
        /// <summary>
        /// Makes sure as set in the class (in Data Folder) the tomato is included
        /// </summary>
        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Tomato);
        }
        /// <summary>
        /// Makes sure as set in the class (in Data Folder) the lettuce is included
        /// </summary>
        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Lettuce);
        }
        /// <summary>
        /// Makes sure as set in the class (in Data Folder) the mayo is included
        /// </summary>
        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Mayo);
        }
        /// <summary>
        /// Makes sure as set in the class (in Data Folder) the bacon is included
        /// </summary>
        [Fact]
        public void ShouldIncludeBaconByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Bacon);
        }
        /// <summary>
        /// Makes sure as set in the class (in Data Folder) the egg is included
        /// </summary>
        [Fact]
        public void ShouldIncludeEggByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Egg);
        }
        /// <summary>
        /// Sets bun, checks if statement is true then false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Bun = true;
            Assert.True(tt.Bun);
            tt.Bun = false;
            Assert.False(tt.Bun);
        }
        /// <summary>
        /// Sets ketchup, checks if statement is true then false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Ketchup = true;
            Assert.True(tt.Ketchup);
            tt.Ketchup = false;
            Assert.False(tt.Ketchup);
        }
        /// <summary>
        /// Sets mustard, checks if statement is true then false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Mustard = true;
            Assert.True(tt.Mustard);
            tt.Mustard = false;
            Assert.False(tt.Mustard);
        }
        /// <summary>
        /// Sets pickle, checks if statement is true then false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Pickle = true;
            Assert.True(tt.Pickle);
            tt.Pickle = false;
            Assert.False(tt.Pickle);
        }
        /// <summary>
        /// Sets cheese, checks if statement is true then false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Cheese = true;
            Assert.True(tt.Cheese);
            tt.Cheese = false;
            Assert.False(tt.Cheese);
        }
        /// <summary>
        /// Sets tomato, checks if statement is true then false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Tomato = true;
            Assert.True(tt.Tomato);
            tt.Tomato = false;
            Assert.False(tt.Tomato);
        }
        /// <summary>
        /// Sets lettuce, checks if statement is true then false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Lettuce = true;
            Assert.True(tt.Lettuce);
            tt.Lettuce = false;
            Assert.False(tt.Lettuce);
        }
        /// <summary>
        /// Sets mayo, checks if statement is true then false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Mayo = true;
            Assert.True(tt.Mayo);
            tt.Mayo = false;
            Assert.False(tt.Mayo);
        }
        /// <summary>
        /// Sets bacon, checks if statement is true then false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBacon()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Bacon = true;
            Assert.True(tt.Bacon);
            tt.Bacon = false;
            Assert.False(tt.Bacon);
        }
        /// <summary>
        /// Sets egg, checks if statement is true then false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Egg = true;
            Assert.True(tt.Egg);
            tt.Egg = false;
            Assert.False(tt.Egg);
        }
        /// <summary>
        /// Makes sure the correct price is returned
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.Equal(8.32, tt.Price);
        }
        /// <summary>
        /// Makes sure the correct calories is returned
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.Equal((uint) 943, tt.Calories);
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
        /// <param name="includeTomato">parameter for the tomato</param>
        /// <param name="includeLettuce">parameter for the lettuce</param>
        /// <param name="includeMayo">parameter for the mayo</param>
        /// <param name="includeBacon">parameter for the bacon</param>
        /// <param name="includeEgg">parameter for the egg</param>
        [Theory]
        [InlineData(true, true, true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo,
                                                                    bool includeBacon, bool includeEgg)
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Bun = includeBun;
            tt.Ketchup = includeKetchup;
            tt.Mustard = includeMustard;
            tt.Pickle = includePickle;
            tt.Cheese = includeCheese;
            tt.Tomato = includeTomato;
            tt.Lettuce = includeLettuce;
            tt.Mayo = includeMayo;
            tt.Bacon = includeBacon;
            tt.Egg = includeEgg;

            if (!includeBun) Assert.Contains("Hold bun", tt.SpecialInstructions);
            else if (!includeKetchup) Assert.Contains("Hold ketchup", tt.SpecialInstructions);
            else if (!includeMustard) Assert.Contains("Hold mustard", tt.SpecialInstructions);
            else if (!includePickle) Assert.Contains("Hold pickle", tt.SpecialInstructions);
            else if (!includeCheese) Assert.Contains("Hold cheese", tt.SpecialInstructions);
            else if (!includeTomato) Assert.Contains("Hold tomato", tt.SpecialInstructions);
            else if (!includeLettuce) Assert.Contains("Hold lettuce", tt.SpecialInstructions);
            else if (!includeMayo) Assert.Contains("Hold mayo", tt.SpecialInstructions);
            else if (!includeBacon) Assert.Contains("Hold bacon", tt.SpecialInstructions);
            else if (!includeEgg) Assert.Contains("Hold egg", tt.SpecialInstructions);
        }
        /// <summary>
        /// returns the correct name of the entree
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.Equal("Thalmor Triple", tt.ToString());
        }
        /// <summary>
        /// checks if entree is implemented in the IOrderItem Class
        /// </summary>
        [Fact]
        public void ThalmorTripleImplementsTheIOrderItemClass()
        {
            var ThalmorTriple = new ThalmorTriple();
            Assert.IsAssignableFrom<IOrderItem>(ThalmorTriple);
        }
        /// <summary>
        /// making sure properties are changed correctly
        /// </summary>
        [Fact]
        public void ChangingBunNotifiesBunProperties()
        {
            var TT = new ThalmorTriple();

            Assert.PropertyChanged(TT, "Bun", () =>
            {
                TT.Bun = true;
            });

            Assert.PropertyChanged(TT, "Bun", () =>
            {
                TT.Bun = false;
            });

        }
        /// <summary>
        /// making sure properties are changed correctly
        /// </summary>
        [Fact]
        public void ChangingKetchupNotifiesKetchupProperties()
        {
            var TT = new ThalmorTriple();
            Assert.PropertyChanged(TT, "Ketchup", () =>
            {
                TT.Ketchup = true;

            });

            Assert.PropertyChanged(TT, "Ketchup", () =>
            {
                TT.Ketchup = false;
            });

        }
        /// <summary>
        /// making sure properties are changed correctly
        /// </summary>
        [Fact]
        public void ChangingMustardNotifiesMustardProperties()
        {
            var TT = new ThalmorTriple();
            Assert.PropertyChanged(TT, "Mustard", () =>
            {
                TT.Mustard = true;
            });
            Assert.PropertyChanged(TT, "Mustard", () =>
            {
                TT.Mustard = false;
            });
        }
        /// <summary>
        /// making sure properties are changed correctly
        /// </summary>
        [Fact]
        public void ChangingPickleNotifiesPickleProperties()
        {
            var TT = new ThalmorTriple();
            Assert.PropertyChanged(TT, "Pickle", () =>
            {
                TT.Pickle = true;
            });
            Assert.PropertyChanged(TT, "Pickle", () =>
            {
                
                TT.Pickle = false;
            });
        }
        /// <summary>
        /// making sure properties are changed correctly
        /// </summary>
        [Fact]
        public void ChangingCheeseNotifiesCheeseProperties()
        {
            var TT = new ThalmorTriple();
            Assert.PropertyChanged(TT, "Cheese", () =>
            {
                TT.Cheese = true;
            });
            Assert.PropertyChanged(TT, "Cheese", () =>
            {
                TT.Cheese = false;
            });
        }
        /// <summary>
        /// making sure properties are changed correctly
        /// </summary>
        [Fact]
        public void ChangingTomatoNotifiesTomatoProperties()
        {
            var TT = new ThalmorTriple();
            Assert.PropertyChanged(TT, "Tomato", () =>
            {
                TT.Tomato = true;
            });
            Assert.PropertyChanged(TT, "Tomato", () =>
            {
                TT.Tomato = false;
            });
        }
        /// <summary>
        /// making sure properties are changed correctly
        /// </summary>
        [Fact]
        public void ChangingLettuceNotifiesLettuceProperties()
        {
            var TT = new ThalmorTriple();
            Assert.PropertyChanged(TT, "Lettuce", () =>
            {
                TT.Lettuce = true;
            });
            Assert.PropertyChanged(TT, "Lettuce", () =>
            {
                TT.Lettuce = false;
            });

        }
        /// <summary>
        /// making sure properties are changed correctly
        /// </summary>
        [Fact]
        public void ChangingMayoNotifiesMayoProperties()
        {
            var TT = new ThalmorTriple();
            Assert.PropertyChanged(TT, "Mayo", () =>
            {
                TT.Mayo = true;
            });
            Assert.PropertyChanged(TT, "Mayo", () =>
            {
                TT.Mayo = false;
            });

        }
        /// <summary>
        /// making sure properties are changed correctly
        /// </summary>
        [Fact]
        public void ChangingBaconNotifiesBaconProperties()
        {
            var TT = new ThalmorTriple();
            Assert.PropertyChanged(TT, "Bacon", () =>
            {
                TT.Bacon = true;
            });
            Assert.PropertyChanged(TT, "Bacon", () =>
            {
                TT.Bacon = false;
            });
        }
        /// <summary>
        /// making sure properties are changed correctly
        /// </summary>
        [Fact]
        public void ChangingEggNotifiesEggProperties()
        {
            var TT = new ThalmorTriple();
            Assert.PropertyChanged(TT, "Egg", () =>
            {
                TT.Egg = true;
            });
            Assert.PropertyChanged(TT, "Egg", () =>
            {
                TT.Egg = false;
            });
        }
        /// <summary>
        /// checking the description to see if correct
        /// </summary>
        /// <param name="description"></param>
        [Theory]
        [InlineData("Think you are strong enough to take on the Thalmor? Inlcudes two 1/4lb patties with a 1/2lb patty inbetween with ketchup, mustard, pickle, cheese, tomato, lettuce, mayo, bacon, and an egg.")]
        public void ShouldBeRightDescription(string description)
        {
            ThalmorTriple tt = new ThalmorTriple();

            Assert.Equal(description, tt.Description);
        }

    }
}