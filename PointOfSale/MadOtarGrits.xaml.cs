/*
* Author: Katayoun Katy Davoudi
* Class name: MadOtarGrits.xaml.cs
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
    /// Interaction logic for MadOtarGrits.xaml
    /// </summary>
    public partial class MadOtarGrits : UserControl
    {
        OrderClass order;
        BleakwindBuffet.Data.Sides.MadOtarGrits drag = new BleakwindBuffet.Data.Sides.MadOtarGrits();
        /// <summary>
        /// Contructor for mad otar grits class
        /// </summary>
        public MadOtarGrits(OrderClass o)
        {
            InitializeComponent();
            order = o;
        }
        public string DisplayName
        {
            get => ToString();
        }
        /// <summary>
        /// Swaps screen from from customization
        /// </summary>
        /// <param name="sender"> object parameter called sender</param>
        /// <param name="e"> routed evet args called e</param>
        private void MOGdone_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindRoot<OrderControl>();
            order.Add(drag);
            orderControl.SwapScreen(new menuSelection());
        }

        private void SmallMOG_Click(object sender, RoutedEventArgs e)
        {
            MediumMOG.IsChecked = false;
            LargeMOG.IsChecked = false;
            drag.Size = Size.Small;
        }

        private void MediumMOG_Click(object sender, RoutedEventArgs e)
        {
            SmallMOG.IsChecked = false;
            LargeMOG.IsChecked = false;
            drag.Size = Size.Medium;
        }

        private void LargeMOG_Click(object sender, RoutedEventArgs e)
        {
            SmallMOG.IsChecked = false;
            MediumMOG.IsChecked = false;
            drag.Size = Size.Large;
        }
    }
}
