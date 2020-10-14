/*
* Author: Katayoun Katy Davoudi
* Class name: AretinoAppleJuice.xaml.cs
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
    /// Interaction logic for AretinoAppleJuice.xaml
    /// </summary>
    public partial class AretinoAppleJuice : UserControl
    {
        OrderClass order;
        BleakwindBuffet.Data.Drinks.AretinoAppleJuice drag = new BleakwindBuffet.Data.Drinks.AretinoAppleJuice();
        /// <summary>
        /// Constructor for aretino apple juice class
        /// </summary>
        public AretinoAppleJuice(OrderClass o)
        {
            InitializeComponent();
            order = o;
        }

        public string DisplayName
        {
            get => ToString();
        }
        /// <summary>
        /// Swaps screen from customization to the main menu
        /// </summary>
        /// <param name="sender"> object parameter called sender</param>
        /// <param name="e"> routed evet args called e</param>
        private void AAdone_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindRoot<OrderControl>();
            order.Add(drag);
            orderControl.SwapScreen(new menuSelection());
        }

        private void IceAA_Click(object sender, RoutedEventArgs e)
        { 
            if (IceAA.IsChecked == false)
            {

                drag.Ice = false;
            }
            if(IceAA.IsChecked == true)
            {
                drag.Ice = true;
            }


        }

        private void SmallAA_Click(object sender, RoutedEventArgs e)
        {
            MediumAA.IsChecked = false;
            LargeAA.IsChecked = false;
            drag.Size = Size.Small;
        }

        private void MediumAA_Click(object sender, RoutedEventArgs e)
        {
            SmallAA.IsChecked = false;
            LargeAA.IsChecked = false;
            drag.Size = Size.Medium;
        }

        private void LargeAA_Click(object sender, RoutedEventArgs e)
        {
            SmallAA.IsChecked = false;
            MediumAA.IsChecked = false;
            drag.Size = Size.Large;
        }
    }
}
