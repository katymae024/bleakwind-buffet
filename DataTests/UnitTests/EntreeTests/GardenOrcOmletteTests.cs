/*
 * Author: Katayoun Katy Davoudi
 * Class: GardenOrcOmletteTests.cs
 * Purpose: Test the GardenOrcOmlette.cs class in the Data Folder
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
    public class GardenOrcOmeletteTests
    {
        /// <summary>
        /// Makes sure it runs through Drink
        /// </summary>
        [Fact]
        public void ShouldBeAnEntree()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.IsAssignableFrom<Entree>(go);
        }
        /// <summary>
        /// Makes sure as set in the class (in Data Folder) the broccoi is included
        /// </summary>
        [Fact]
        public void ShouldInlcudeBroccoliByDefault()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.True(go.Broccoli);
        }
        /// <summary>
        /// Makes sure as set in the class (in Data Folder) the mushrooms are included
        /// </summary>
        [Fact]
        public void ShouldInlcudeMushroomsByDefault()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.True(go.Mushrooms);
        }
        /// <summary>
        /// Makes sure as set in the class (in Data Folder) the tomato is included
        /// </summary>
        [Fact]
        public void ShouldInlcudeTomatoByDefault()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.True(go.Tomato);
        }
        /// <summary>
        /// Makes sure as set in the class (in Data Folder) the cheddar is included
        /// </summary>
        [Fact]
        public void ShouldInlcudeCheddarByDefault()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.True(go.Cheddar);
        }
        /// <summary>
        /// Sets broccoli, checks if statement is true then false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBroccoli()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            go.Broccoli = true;
            Assert.True(go.Broccoli);
            go.Broccoli = false;
            Assert.False(go.Broccoli);
        }
        /// <summary>
        /// Sets mushrooms, checks if statement is true then false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            go.Mushrooms = true;
            Assert.True(go.Mushrooms);
            go.Mushrooms = false;
            Assert.False(go.Mushrooms);
        }
        /// <summary>
        /// Sets tomato, checks if statement is true then false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            go.Tomato = true;
            Assert.True(go.Tomato);
            go.Tomato = false;
            Assert.False(go.Tomato);
        }
        /// <summary>
        /// Sets cheddar, checks if statement is true then false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetCheddar()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            go.Cheddar = true;
            Assert.True(go.Cheddar);
            go.Cheddar = false;
            Assert.False(go.Cheddar);
        }
        /// <summary>
        /// Makes sure the correct price is returned
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.Equal(4.57, go.Price);
        }
        /// <summary>
        /// Makes sure the correct calories is returned
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.Equal((uint) 404, go.Calories);
        }
        /// <summary>
        /// Makes sure if special instruction has been met, for example whether to include broccoli or not, etc.
        /// </summary>
        /// <param name="includeBroccoli">parameter for the broccoli</param>
        /// <param name="includeMushrooms">parameter for the mushrooms</param>
        /// <param name="includeTomato">parameter for the tomato</param>
        /// <param name="includeCheddar">parameter for the cheddar</param>
        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBroccoli, bool includeMushrooms,
                                                            bool includeTomato, bool includeCheddar)
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            go.Broccoli = includeBroccoli;
            go.Mushrooms = includeMushrooms;
            go.Tomato = includeTomato;
            go.Cheddar = includeCheddar;

            if (!includeBroccoli) Assert.Contains("Hold broccoli", go.SpecialInstructions);
            else if (!includeMushrooms) Assert.Contains("Hold mushrooms", go.SpecialInstructions);
            else if (!includeTomato) Assert.Contains("Hold tomato", go.SpecialInstructions);
            else if (!includeCheddar) Assert.Contains("Hold cheddar", go.SpecialInstructions);
        }
        /// <summary>
        /// returns the correct name of the entree
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            Assert.Equal("Garden Orc Omelette", go.ToString());
        }
        /// <summary>
        /// checks if entree is implemented in the IOrderItem Class
        /// </summary>
        [Fact]
        public void GardenOrcOmletteImplementsTheIOrderItemClass()
        {
            var GardenOrcOmelette = new GardenOrcOmelette();
            Assert.IsAssignableFrom<IOrderItem>(GardenOrcOmelette);
        }
        /// <summary>
        /// making sure properties are changed correctly
        /// </summary>
        [Fact]
        public void ChangingPropertiesNotifiesEntreeProperties()
        {
            var GO = new GardenOrcOmelette();

            Assert.PropertyChanged(GO, "Broccoli", () =>
            {
                GO.Broccoli = true;
            });

            Assert.PropertyChanged(GO, "Broccoli", () =>
            {
                GO.Broccoli = false;
            });

            Assert.PropertyChanged(GO, "Cheddar", () =>
            {
                GO.Cheddar = true;

            });

            Assert.PropertyChanged(GO, "Cheddar", () =>
            {
                GO.Cheddar = false;

            });

            Assert.PropertyChanged(GO, "Tomato", () =>
            {
                GO.Tomato = true;
            });
            Assert.PropertyChanged(GO, "Tomato", () =>
            {
                GO.Tomato = true;
            });
            Assert.PropertyChanged(GO, "Mushrooms", () =>
            {
                GO.Mushrooms = true;
            });
            Assert.PropertyChanged(GO, "Mushrooms", () =>
            {
                GO.Mushrooms = false;
            });
            



        }
    }
}