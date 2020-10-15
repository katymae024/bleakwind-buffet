/*
* Author: Katayoun Katy Davoudi
* Class name: BriarheartBurger.xaml.cs
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
    /// Interaction logic for BriarheartBurger.xaml
    /// </summary>
    public partial class BriarheartBurger : UserControl
    {
        OrderClass order;
        BleakwindBuffet.Data.Entrees.BriarheartBurger drag = new BleakwindBuffet.Data.Entrees.BriarheartBurger();
        /// <summary>
        /// Constructor of briarheart burger class
        /// </summary>
        public BriarheartBurger(OrderClass o)
        {
            InitializeComponent();
            order = o;
        }

        /// <summary>
        /// Swaps screen from from customization
        /// </summary>
        /// <param name="sender"> object parameter called sender</param>
        /// <param name="e"> routed evet args called e</param>
        private void BBdone_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindRoot<OrderControl>();
            order.Add(drag);
            orderControl.SwapScreen(new menuSelection());
        }

        private void BunBB_Click(object sender, RoutedEventArgs e)
        {
            if (BunBB.IsChecked == false)
            {

                drag.Bun = false;
            }
            if (BunBB.IsChecked == true)
            {
                drag.Bun = true;
            }

        }

        private void KetchupBB_Click(object sender, RoutedEventArgs e)
        {
            if (KetchupBB.IsChecked == false)
            {

                drag.Ketchup = false;
            }
            if (KetchupBB.IsChecked == true)
            {
                drag.Ketchup = true;
            }

        }

        private void MustardBB_Click(object sender, RoutedEventArgs e)
        {
            if (MustardBB.IsChecked == false)
            {

                drag.Mustard = false;
            }
            if (MustardBB.IsChecked == true)
            {
                drag.Mustard = true;
            }

        }

        private void CheeseBB_Click(object sender, RoutedEventArgs e)
        {
            if (CheeseBB.IsChecked == false)
            {

                drag.Cheese = false;
            }
            if (CheeseBB.IsChecked == true)
            {
                drag.Cheese = true;
            }

        }

        private void PickleBB_Click(object sender, RoutedEventArgs e)
        {
            if (PickleBB.IsChecked == false)
            {

                drag.Pickle = false;
            }
            if (PickleBB.IsChecked == true)
            {
                drag.Pickle = true;
            }

        }
    }
}
