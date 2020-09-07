/*
 * Author: Katayoun Katy Davoudi
 * Class: ThugsTBoneTests.cs
 * Purpose: Test the ThugsTBone.cs class in the Data Folder
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// methods provided checks price, calories, special instructions, etc.
    /// </summary>
    public class ThugsTBoneTests
    {
        /// <summary>
        /// Makes sure the correct price is returned
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThugsTBone tb = new ThugsTBone();
            Assert.Equal(6.44, tb.Price);
        }
        /// <summary>
        /// Makes sure the correct calories is returned
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThugsTBone tb = new ThugsTBone();
            Assert.Equal((uint)982, tb.Calories);
        }
        /// <summary>
        /// returns empty special instructions because there is none
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            ThugsTBone tb = new ThugsTBone();
            Assert.Empty(tb.SpecialInstructions);
        }
        /// <summary>
        /// returns the correct name of the entree
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThugsTBone tb = new ThugsTBone();
            Assert.Equal("Thugs T-Bone", tb.ToString());
        }
    }
}