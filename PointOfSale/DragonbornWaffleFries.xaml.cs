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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DragonbornWaffleFries.xaml
    /// </summary>
    public partial class DragonbornWaffleFries : UserControl
    {
        /// <summary>
        /// Constructor for dragon born waffle fries
        /// </summary>
        public DragonbornWaffleFries()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Swaps screen from from customization
        /// </summary>
        /// <param name="sender"> object parameter called sender</param>
        /// <param name="e"> routed evet args called e</param>
        private void DWFdone_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindRoot<OrderControl>();
            orderControl.SwapScreen(new menuSelection());
        }

       

        private void RadioButton_Click_1(object sender, RoutedEventArgs e)
        {
            if (DataContext is Side d)
            {
                if (sender is RadioButton rb)
                {
                    switch (rb.Name)
                    {
                        //case 
                        //which button is pressed
                        //assign the size of the side 
                        //set size equal to small
                    }
                }

            }
        }

        private void MediumDWF_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LargeDWF_Click(object sender, RoutedEventArgs e)
        {

        }
        //make a method

    }
}
