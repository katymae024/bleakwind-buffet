/*
* Author: Katayoun Katy Davoudi
* Class name: VokunSalad.xaml.cs
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for VokunSalad.xaml
    /// </summary>
    public partial class VokunSalad : UserControl
    {
        /// <summary>
        /// Contructor for the Vokun salad
        /// </summary>
        public VokunSalad()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Swaps screen from customization to the main menu
        /// </summary>
        /// <param name="sender"> object parameter called sender</param>
        /// <param name="e"> routed evet args called e</param>
        private void VSdone_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindRoot<OrderControl>();
            orderControl.SwapScreen(new menuSelection());
        }
    }
}
