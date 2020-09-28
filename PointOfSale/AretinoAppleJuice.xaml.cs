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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for AretinoAppleJuice.xaml
    /// </summary>
    public partial class AretinoAppleJuice : UserControl
    {
        /// <summary>
        /// Constructor for aretino apple juice class
        /// </summary>
        public AretinoAppleJuice()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Swaps screen from customization to the main menu
        /// </summary>
        /// <param name="sender"> object parameter called sender</param>
        /// <param name="e"> routed evet args called e</param>
        private void AAdone_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindRoot<OrderControl>();
            orderControl.SwapScreen(new menuSelection());
        }
    }
}
