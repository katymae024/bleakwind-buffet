/*
* Author: Katayoun Katy Davoudi
* Class name: FriedMiraak.xaml.cs
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
    /// Interaction logic for FriedMiraak.xaml
    /// </summary>
    public partial class FriedMiraak : UserControl
    {
        OrderClass order;
        BleakwindBuffet.Data.Sides.FriedMiraak drag = new BleakwindBuffet.Data.Sides.FriedMiraak();
        /// <summary>
        /// Constructor of fried miraak class
        /// </summary>
        public FriedMiraak(OrderClass o)
        {
            InitializeComponent();
            order = o;
        }
        /// <summary>
        /// property for displaying name
        /// </summary>
        public string DisplayName
        {
            get => ToString();
        }
        /// <summary>
        /// Swaps screen from from customization
        /// </summary>
        /// <param name="sender"> object parameter called sender</param>
        /// <param name="e"> routed evet args called e</param>
        private void FMdone_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindRoot<OrderControl>();
            order.Add(drag);
            orderControl.SwapScreen(new menuSelection());
        }

        private void SmallFM_Click(object sender, RoutedEventArgs e)
        {
            MediumFM.IsChecked = false;
            LargeFM.IsChecked = false;
            drag.Size = Size.Small;
        }

        private void MediumFM_Click(object sender, RoutedEventArgs e)
        {
            SmallFM.IsChecked = false;
            LargeFM.IsChecked = false;
            drag.Size = Size.Medium;
        }

        private void LargeFM_Click(object sender, RoutedEventArgs e)
        {
            SmallFM.IsChecked = false;
            MediumFM.IsChecked = false;
            drag.Size = Size.Large;
        }
    }
}
