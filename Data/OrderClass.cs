using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using BleakwindBuffet.Data.Interfaces;

namespace BleakwindBuffet.Data
{
    public class OrderClass: ObservableCollection<IOrderItem>
    {
        int numOrder;
        public OrderClass()
        {

        }

    }
}
