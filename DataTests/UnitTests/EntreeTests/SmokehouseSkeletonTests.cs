﻿/*
 * Author: Katayoun Katy Davoudi
 * Class: SmokehouseSkeletonTests.cs
 * Purpose: Test the SmokehouseSkeleton.cs class in the Data Folder
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
    public class SmokehouseSkeletonTests
    {
        /// <summary>
        /// Makes sure it runs through Drink
        /// </summary>
        [Fact]
        public void ShouldBeAnEntree()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<Entree>(ss);
        }
        /// <summary>
        /// Makes sure as set in the class (in Data Folder) the sausage link is included
        /// </summary>
        [Fact]
        public void ShouldInlcudeSausageByDefault()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.True(ss.SausageLink);
        }
        /// <summary>
        /// Makes sure as set in the class (in Data Folder) the egg is included
        /// </summary>
        [Fact]
        public void ShouldInlcudeEggByDefault()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.True(ss.Egg);
        }
        /// <summary>
        /// Makes sure as set in the class (in Data Folder) the hashbrowns is included
        /// </summary>
        [Fact]
        public void ShouldInlcudeHashbrownsByDefault()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.True(ss.HashBrowns);
        }
        /// <summary>
        /// Makes sure as set in the class (in Data Folder) the pancake is included
        /// </summary>
        [Fact]
        public void ShouldInlcudePancakeByDefault()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.True(ss.Pancake);
        }
        /// <summary>
        /// Sets sausage, checks if statement is true then false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSausage()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.SausageLink = true;
            Assert.True(ss.SausageLink);
            ss.SausageLink = false;
            Assert.False(ss.SausageLink);
        }
        /// <summary>
        /// Sets egg, checks if statement is true then false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.Egg = true;
            Assert.True(ss.Egg);
            ss.Egg = false;
            Assert.False(ss.Egg);
        }
        /// <summary>
        /// Sets hashbrowns, checks if statement is true then false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetHashbrowns()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.HashBrowns = true;
            Assert.True(ss.HashBrowns);
            ss.HashBrowns = false;
            Assert.False(ss.HashBrowns);
        }
        /// <summary>
        /// Sets pancake, checks if statement is true then false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPancake()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.Pancake = true;
            Assert.True(ss.Pancake);
            ss.Pancake = false;
            Assert.False(ss.Pancake);
        }
        /// <summary>
        /// Makes sure the correct price is returned
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.Equal(5.62, ss.Price);
        }
        /// <summary>
        /// Makes sure the correct calories is returned
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.Equal((uint)602, ss.Calories);
        }
        /// <summary>
        /// Makes sure if special instruction has been met, for example whether to include sausage or not, etc.
        /// </summary>
        /// <param name="includeSausage">parameter for the sausage</param>
        /// <param name="includeEgg">parameter for the egg</param>
        /// <param name="includeHashbrowns">parameter for the hashbrowns</param>
        /// <param name="includePancake">parameter for the pancake</param>
        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSausage, bool includeEgg,
                                                            bool includeHashbrowns, bool includePancake)
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ss.SausageLink = includeSausage;
            ss.Egg = includeEgg;
            ss.HashBrowns = includeHashbrowns;
            ss.Pancake = includePancake;

            if (!includeSausage) Assert.Contains("Hold sausage", ss.SpecialInstructions);
            else if (!includeEgg) Assert.Contains("Hold egg", ss.SpecialInstructions);
            else if (!includeHashbrowns) Assert.Contains("Hold hashbrowns", ss.SpecialInstructions);
            else if (!includePancake) Assert.Contains("Hold pancake", ss.SpecialInstructions);

        }
        /// <summary>
        /// returns the correct name of the entree
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.Equal("Smokehouse Skeleton", ss.ToString());
        }
        /// <summary>
        /// checks if entree is implemented in the IOrderItem Class
        /// </summary>
        [Fact]
        public void SmokehouseSkeletonImplementsTheIOrderItemClass()
        {
            var SmokehouseSkeleton = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<IOrderItem>(SmokehouseSkeleton);
        }
        /// <summary>
        /// making sure properties are changed correctly
        /// </summary>
        [Fact]
        public void ChangingSausageLinkNotifiesSausageLinkProperties()
        {
            var SS = new SmokehouseSkeleton();

            Assert.PropertyChanged(SS, "SausageLink", () =>
            {
                SS.SausageLink = true;
            });
            Assert.PropertyChanged(SS, "SausageLink", () =>
            {
                SS.SausageLink = false;
            });
        }
        /// <summary>
        /// making sure properties are changed correctly
        /// </summary>
        [Fact]
        public void ChangingEggNotifiesEggProperties()
        {
            var SS = new SmokehouseSkeleton();
            Assert.PropertyChanged(SS, "Egg", () =>
            {
                SS.Egg = true;
            });
            Assert.PropertyChanged(SS, "Egg", () =>
            {
                SS.Egg = false;
            });
        }
        /// <summary>
        /// making sure properties are changed correctly
        /// </summary>
        [Fact]
        public void ChangingHashbrownsNotifiesHashbrownsProperties()
        {
            var SS = new SmokehouseSkeleton();
            Assert.PropertyChanged(SS, "Hashbrowns", () =>
            {
                SS.HashBrowns = true;
            });
            Assert.PropertyChanged(SS, "Hashbrowns", () =>
            {
                SS.HashBrowns = false;
            });
        }
        /// <summary>
        /// making sure properties are changed correctly
        /// </summary>
        [Fact]
        public void ChangingPancakeNotifiesPancakeProperties()
        {
            var SS = new SmokehouseSkeleton();
            Assert.PropertyChanged(SS, "Pancake", () =>
            {
                SS.Pancake = true;
            });
            Assert.PropertyChanged(SS, "Pancake", () =>
            {
                SS.Pancake = false;
            });

        }
        /// <summary>
        /// checking the description to see if correct
        /// </summary>
        /// <param name="description"></param>
        [Theory]
        [InlineData("Put some meat on those bones with a small stack of pancakes. Includes sausage links, eggs, and hash browns on the side. Topped with the syrup of your choice.")]
        public void ShouldBeRightDescription(string description)
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();

            Assert.Equal(description, ss.Description);
        }

    }
}