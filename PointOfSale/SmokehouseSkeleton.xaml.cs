﻿using System;
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
    /// Interaction logic for SmokehouseSkeleton.xaml
    /// </summary>
    public partial class SmokehouseSkeleton : UserControl
    {
        public SmokehouseSkeleton()
        {
            InitializeComponent();
        }

        private void SSdone_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindRoot<OrderControl>();
            orderControl.SwapScreen(new menuSelection());
        }
    }
}
