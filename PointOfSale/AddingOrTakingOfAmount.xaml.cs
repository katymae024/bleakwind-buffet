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
    /// Interaction logic for AddingOrTakingOf_Amount.xaml
    /// </summary>
    public partial class AddingOrTakingOfAmount : UserControl
    {
        public static readonly DependencyProperty QProperty = DependencyProperty.Register("Quantity",typeof(int),typeof(AddingOrTakingOfAmount), new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        public AddingOrTakingOfAmount()
        {
            InitializeComponent();
        }

        public int Quantity
        {
            get { return (int)GetValue(QProperty); }
            set { SetValue(QProperty, value); }

        }

        public void IncreaseQuantity(object sender, RoutedEventArgs e)
        {
            Quantity++;
        }
        public void DecreaseQuantity(object sender, RoutedEventArgs e)
        {
            Quantity--;
        }

        private void PlusSign_Click(object sender, RoutedEventArgs e)
        {
           

        }
    }
}
