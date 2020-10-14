/*
* Author: Katayoun Katy Davoudi
* Class name: CandlehearthCoffee.xaml.cs
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
using Size = BleakwindBuffet.Data.Enums.Size;
using BleakwindBuffet.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CandlehearthCoffee.xaml
    /// </summary>
    public partial class CandlehearthCoffee : UserControl
    {
        OrderClass order;
        BleakwindBuffet.Data.Drinks.CandlehearthCoffee drag = new BleakwindBuffet.Data.Drinks.CandlehearthCoffee();
        /// <summary>
        /// Constructor for candle hearth coffee class
        /// </summary>
        public CandlehearthCoffee(OrderClass o)
        {
            InitializeComponent();
            order = o;
        }

        /// <summary>
        /// Swaps screen from from customization
        /// </summary>
        /// <param name="sender"> object parameter called sender</param>
        /// <param name="e"> routed evet args called e</param>
        private void CCdone_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindRoot<OrderControl>();
            order.Add(drag);
            orderControl.SwapScreen(new menuSelection());
        }

        private void IceCC_Click(object sender, RoutedEventArgs e)
        {
            if (IceCC.IsChecked == false)
            {

                drag.Ice = false;
            }
            if (IceCC.IsChecked == true)
            {
                drag.Ice = true;
            }
        }

        private void SmallCC_Click(object sender, RoutedEventArgs e)
        {
            MediumCC.IsChecked = false;
            LargeCC.IsChecked = false;
            drag.Size = Size.Small;
        }

        private void MediumCC_Click(object sender, RoutedEventArgs e)
        {
            SmallCC.IsChecked = false;
            LargeCC.IsChecked = false;
            drag.Size = Size.Medium;
        }

        private void LargeCC_Click(object sender, RoutedEventArgs e)
        {
            SmallCC.IsChecked = false;
            MediumCC.IsChecked = false;
            drag.Size = Size.Large;
        }

        private void DecafCC_Click(object sender, RoutedEventArgs e)
        {
            if (DecafCC.IsChecked == false)
            {

                drag.Decaf = false;
            }
            if (DecafCC.IsChecked == true)
            {
                drag.Decaf = true;
            }
        }

        private void RoomForCreamCC_Click(object sender, RoutedEventArgs e)
        {
            if (RoomForCreamCC.IsChecked == false)
            {

                drag.RoomForCream = false;
            }
            if (RoomForCreamCC.IsChecked == true)
            {
                drag.RoomForCream = true;
            }
        }
    }
}
