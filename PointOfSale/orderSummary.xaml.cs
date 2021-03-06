﻿/*
* Author: Katayoun Katy Davoudi
* Class name: orderSummary.xaml.cs
* Purpose: class made for the order summary or the receipt of the order made
*/
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Interfaces;
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
    /// Interaction logic for orderSummary.xaml
    /// </summary>
    public partial class orderSummary : UserControl
    {
        
        /// <summary>
        /// Constructor for the order summary class
        /// </summary>
        public orderSummary(object DC, OrderControl orderC)
        {
            InitializeComponent();
            DataContext = DC;
            //DataContext = new OrderClass();
            orderControl = orderC;


        }
        private OrderControl orderControl
        {
            get;
            set;
            
        }
        /// <summary>
        /// method for when order is complete
        /// </summary>
        /// <param name="sender">parameter object sender</param>
        /// <param name="e">parameter routed event args</param>
        private void OrderComplete_Click(object sender, RoutedEventArgs e)
        {
            //swap screen to cash register
            orderControl.SwapScreen( new PaymentOptions());
           
        }
        /// <summary>
        /// method for when want to cancel order 
        /// </summary>
        /// <param name="sender">parameter object sender</param>
        /// <param name="e">parameter routed event args</param>
        private void CancelOrder_Click(object sender, RoutedEventArgs e)
        {

            //DataContext = new OrderClass(CancelOrder); 
            //check
         
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            if(DataContext is OrderClass o)
            {
                IOrderItem item = (IOrderItem)((Button)sender).DataContext;
                o.Remove(item);
            }
        }
    }
}
