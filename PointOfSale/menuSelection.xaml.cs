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
    /// Interaction logic for menuSelection.xaml
    /// </summary>
    public partial class menuSelection : UserControl
    {
        public menuSelection()
        {
            InitializeComponent();
        }

        private void BB_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindRoot<OrderControl>();
            orderControl.SwapScreen(new BriarheartBurger());

        }

        private void DD_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TT_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SS_Click(object sender, RoutedEventArgs e)
        {

        }

        private void GO_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TTB_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SSoda_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MM_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AA_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CC_Click(object sender, RoutedEventArgs e)
        {

        }

        private void WW_Click(object sender, RoutedEventArgs e)
        {

        }

        private void VS_Click(object sender, RoutedEventArgs e)
        {

        }

        private void FM_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MOG_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DWF_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
