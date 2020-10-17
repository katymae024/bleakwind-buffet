/*
* Author: Katayoun Katy Davoudi
* Class name: GardenOrcOmelette.xaml.cs
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
    /// Interaction logic for GardenOrcOmelette.xaml
    /// </summary>
    public partial class GardenOrcOmelette : UserControl
    {
        OrderClass order;
        BleakwindBuffet.Data.Entrees.GardenOrcOmelette drag = new BleakwindBuffet.Data.Entrees.GardenOrcOmelette();
        /// <summary>
        /// Constructor for garden orc omelette class
        /// </summary>
        public GardenOrcOmelette(OrderClass o)
        {
            InitializeComponent();
            order = o;
        }
        /// <summary>
        /// Swaps screen from from customization
        /// </summary>
        /// <param name="sender"> object parameter called sender</param>
        /// <param name="e"> routed evet args called e</param>
        private void GOdone_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindRoot<OrderControl>();
            order.Add(drag);
            orderControl.SwapScreen(new menuSelection());
        }

        private void BroccoliGO_Click(object sender, RoutedEventArgs e)
        {
            if (BroccoliGO.IsChecked == false)
            {

                drag.Broccoli = false;
            }
            if (BroccoliGO.IsChecked == true)
            {
                drag.Broccoli = true;
            }
        }

        private void MushroomsGO_Click(object sender, RoutedEventArgs e)
        {
            if (MushroomsGO.IsChecked == false)
            {

                drag.Mushrooms = false;
            }
            if (MushroomsGO.IsChecked == true)
            {
                drag.Mushrooms = true;
            }
        }

        private void TomatoGO_Click(object sender, RoutedEventArgs e)
        {
            if (TomatoGO.IsChecked == false)
            {

                drag.Tomato = false;
            }
            if (TomatoGO.IsChecked == true)
            {
                drag.Tomato = true;
            }
        }

        private void CheddarGO_Click(object sender, RoutedEventArgs e)
        {
            if (TomatoGO.IsChecked == false)
            {

                drag.Tomato = false;
            }
            if (TomatoGO.IsChecked == true)
            {
                drag.Tomato = true;
            }
        }
    }
}
