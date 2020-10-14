/*
* Author: Katayoun Katy Davoudi
* Class name: DoubleDraugr.xaml.cs
* Purpose: Controls the screen swap between customization screen and the actual menu
*/
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
using BleakwindBuffet.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DoubleDraugr.xaml
    /// </summary>
    public partial class DoubleDraugr : UserControl
    {
        OrderClass order;
        BleakwindBuffet.Data.Entrees.DoubleDraugr drag = new BleakwindBuffet.Data.Entrees.DoubleDraugr();
        /// <summary>
        /// Constructor for double draugr class
        /// </summary>
        public DoubleDraugr(OrderClass o)
        {
            InitializeComponent();
            order = o;
        }
        /// <summary>
        /// Swaps screen from from customization
        /// </summary>
        /// <param name="sender"> object parameter called sender</param>
        /// <param name="e"> routed evet args called e</param>
        private void DDdone_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindRoot<OrderControl>();
            order.Add(drag);
            orderControl.SwapScreen(new menuSelection());
        }

        private void BunDD_Click(object sender, RoutedEventArgs e)
        {
            if (BunDD.IsChecked == false)
            {

                drag.Bun = false;
            }
            if (BunDD.IsChecked == true)
            {
                drag.Bun = true;
            }

        }

        private void KetchupDD_Click(object sender, RoutedEventArgs e)
        {
            if (KetchupDD.IsChecked == false)
            {

                drag.Ketchup = false;
            }
            if (KetchupDD.IsChecked == true)
            {
                drag.Ketchup = true;
            }

        }

        private void MustardDD_Click(object sender, RoutedEventArgs e)
        {
            if (MustardDD.IsChecked == false)
            {

                drag.Mustard = false;
            }
            if (MustardDD.IsChecked == true)
            {
                drag.Mustard = true;
            }

        }

        private void CheeseDD_Click(object sender, RoutedEventArgs e)
        {
            if (CheeseDD.IsChecked == false)
            {

                drag.Cheese = false;
            }
            if (CheeseDD.IsChecked == true)
            {
                drag.Cheese = true;
            }

        }

        private void PickleDD_Click(object sender, RoutedEventArgs e)
        {
            if (PickleDD.IsChecked == false)
            {

                drag.Pickle = false;
            }
            if (PickleDD.IsChecked == true)
            {
                drag.Pickle = true;
            }

        }

        private void TomatoDD_Click(object sender, RoutedEventArgs e)
        {
            if (TomatoDD.IsChecked == false)
            {

                drag.Tomato = false;
            }
            if (TomatoDD.IsChecked == true)
            {
                drag.Tomato = true;
            }

        }

        private void LettuceDD_Click(object sender, RoutedEventArgs e)
        {
            if (LettuceDD.IsChecked == false)
            {

                drag.Lettuce = false;
            }
            if (LettuceDD.IsChecked == true)
            {
                drag.Lettuce = true;
            }

        }

        private void MayoDD_Click(object sender, RoutedEventArgs e)
        {
            if (MayoDD.IsChecked == false)
            {

                drag.Mayo = false;
            }
            if (MayoDD.IsChecked == true)
            {
                drag.Mayo = true;
            }

        }
    }
}
