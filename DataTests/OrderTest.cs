/*Author: Katayoun Katy Davoudi
 * Class: OrderTest.cs
 * Purpose: has tests that relate to the order class
 */
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BleakwindBuffet.DataTests
{
    public class OrderTest
    {
       
        /// <summary>
        /// checks for subtotal 
        /// </summary>
        [Fact]
        public void CheckingSubtotal()
        {
            OrderClass order = new OrderClass(1);
            Assert.Equal(0, order.Subtotal);
            
        }
        /// <summary>
        /// checks for total
        /// </summary>
        [Fact]
        public void CheckingTotal()
        {
            OrderClass order = new OrderClass(1);
            Assert.Equal(0, order.Total);

        }
        /// <summary>
        /// checks for calories
        /// </summary>
        [Fact]
        public void CheckingCalories()
        {
            OrderClass order = new OrderClass(1);
            Assert.Equal(0, (int)order.Calories);

        }
        /// <summary>
        /// checks for sales tax
        /// </summary>
        [Fact]
        public void CheckingSalesTax()
        {
            OrderClass order = new OrderClass(1);
            Assert.Equal(0.12, order.SalesTaxRate);

        }
        /// <summary>
        /// checking the items being added on to the list has correct subtotal
        /// </summary>
        [Fact]
        public void ShouldBeAbleToAddItemsOnList()
        {
            BriarheartBurger bb = new BriarheartBurger();
            OrderClass order = new OrderClass(1);
            order.Add(bb);
            Assert.Equal(bb.Price, order.Subtotal);
           
        }
        /// <summary>
        /// checking I notify property changed
        /// </summary>
        [Fact]
        public void CheckingINotifyPropertyChange()
        {
            OrderClass order = new OrderClass(1);
            BriarheartBurger bb = new BriarheartBurger();

            order.Add(bb);
            Assert.PropertyChanged(order, "Calories", () => { order.Add(bb); });
        }
        
    }
}
