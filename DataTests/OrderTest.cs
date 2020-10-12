using BleakwindBuffet.Data;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BleakwindBuffet.DataTests
{
    public class OrderTest
    {
        //tax is correct
        //all the properties

        [Fact]
        public void CheckingSubtotal()
        {
            OrderClass order = new OrderClass();
            Assert.Equal(order.Subtotal);
            //what is expected
        }
    }
}
