/*
* Author: Katayoun Katy Davoudi
* Class name: DragonbornWaffleFries.xaml.cs
* Purpose: Controls the screen swap between customization screen and the actual menu
*/
using BleakwindBuffet.Data.Side_Classes;
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

using BleakwindBuffet.Data.Sides;

using Size = BleakwindBuffet.Data.Enums.Size;
using BleakwindBuffet.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DragonbornWaffleFries.xaml
    /// </summary>
    public partial class DragonbornWaffleFries : UserControl
    {
        OrderClass order ; 
        BleakwindBuffet.Data.Sides.DragonbornWaffleFries drag = new BleakwindBuffet.Data.Sides.DragonbornWaffleFries();
        /// <summary>
        /// Constructor for dragon born waffle fries
        /// </summary>
        public DragonbornWaffleFries(OrderClass o)
        {
            InitializeComponent();
            order = o;
        }
        /// <summary>
        /// Swaps screen from from customization
        /// </summary>
        /// <param name="sender"> object parameter called sender</param>
        /// <param name="e"> routed evet args called e</param>
        private void DWFdone_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindRoot<OrderControl>();
            order.Add(drag);
            orderControl.SwapScreen(new menuSelection());
        }

       

        private void RadioButton_Click_1(object sender, RoutedEventArgs e)
        {
            MediumDWF.IsChecked = false;
            LargeDWF.IsChecked = false;
            drag.Size = Size.Small;
        }

        private void MediumDWF_Click(object sender, RoutedEventArgs e)
        {
            SmallDWF.IsChecked = false;
            LargeDWF.IsChecked = false;
            drag.Size = Size.Medium;
        }

        private void LargeDWF_Click(object sender, RoutedEventArgs e)
        {
            SmallDWF.IsChecked = false;
            MediumDWF.IsChecked = false;
            drag.Size = Size.Large;
        }
        //make a method

    }
}
