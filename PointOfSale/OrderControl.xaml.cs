/*
* Author: Katayoun Katy Davoudi
* Class name: OrderControl.xaml.cs
* Purpose: this class contains the swap screen method to swap between menu and customization screen
*/
using BleakwindBuffet.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        /// <summary>
        /// contructor for the order control class
        /// </summary>
        public OrderControl()
        {
            InitializeComponent();
            object order = new OrderClass(1);
            this.DataContext = order;
            orderSummary os = new orderSummary(order);
            orderS.Child = os;
            


        }
        /// <summary>
        /// method made for swapping screens
        /// </summary>
        /// <param name="element"></param>
        public void SwapScreen(UIElement element)
        {
            menuS.Child = element;
        }



    }
}
