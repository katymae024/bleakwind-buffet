/*
* Author: Katayoun Katy Davoudi
* Class name: menuSelection.xaml.cs
* Purpose: Controls the screen swap between the actual menu and customization screen
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
    /// Interaction logic for menuSelection.xaml
    /// </summary>
    public partial class menuSelection : UserControl
    {
        /// <summary>
        /// Contructor of menu selection class
        /// </summary>
        public menuSelection()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Swaps screen from menu
        /// </summary>
        /// <param name="sender"> object parameter called sender</param>
        /// <param name="e"> routed evet args called e</param>
        private void BB_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindRoot<OrderControl>();
            var screen = new BriarheartBurger();
            screen.DataContext = new BleakwindBuffet.Data.Entrees.BriarheartBurger();
            orderControl.SwapScreen(screen);


        }
        /// <summary>
        /// Swaps screen from menu
        /// </summary>
        /// <param name="sender"> object parameter called sender</param>
        /// <param name="e"> routed evet args called e</param>
        private void DD_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindRoot<OrderControl>();
            var screen = new DoubleDraugr();
            screen.DataContext = new BleakwindBuffet.Data.Entrees.DoubleDraugr();
            orderControl.SwapScreen(screen);
        }
        /// <summary>
        /// Swaps screen from menu
        /// </summary>
        /// <param name="sender"> object parameter called sender</param>
        /// <param name="e"> routed evet args called e</param>
        private void TT_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindRoot<OrderControl>();
            var screen = new ThalmorTriple();
            screen.DataContext = new BleakwindBuffet.Data.Entrees.ThalmorTriple();
            orderControl.SwapScreen(screen);
        }
        /// <summary>
        /// Swaps screen from menu
        /// </summary>
        /// <param name="sender"> object parameter called sender</param>
        /// <param name="e"> routed evet args called e</param>
        private void SS_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindRoot<OrderControl>();
            var screen = new SmokehouseSkeleton();
            screen.DataContext = new BleakwindBuffet.Data.Entrees.SmokehouseSkeleton();
            orderControl.SwapScreen(screen);
        }
        /// <summary>
        /// Swaps screen from menu
        /// </summary>
        /// <param name="sender"> object parameter called sender</param>
        /// <param name="e"> routed evet args called e</param>
        private void GO_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindRoot<OrderControl>();
            var screen = new GardenOrcOmelette();
            screen.DataContext = new BleakwindBuffet.Data.Entrees.GardenOrcOmelette();
            orderControl.SwapScreen(screen);
        }
        /// <summary>
        /// doesn't do anything since thugs t-bone doesn't have special instructions
        /// </summary>
        /// <param name="sender"> object parameter called sender</param>
        /// <param name="e"> routed evet args called e</param>
        private void TTB_Click(object sender, RoutedEventArgs e)
        {

        }
        /// <summary>
        /// Swaps screen from menu
        /// </summary>
        /// <param name="sender"> object parameter called sender</param>
        /// <param name="e"> routed evet args called e</param>
        private void SSoda_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindRoot<OrderControl>();
            var screen = new SailorSoda();
            screen.DataContext = new BleakwindBuffet.Data.Drinks.SailorSoda();
            orderControl.SwapScreen(screen);
        }
        /// <summary>
        /// Swaps screen from menu
        /// </summary>
        /// <param name="sender"> object parameter called sender</param>
        /// <param name="e"> routed evet args called e</param>
        private void MM_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindRoot<OrderControl>();
            var screen = new MarkathMilk();
            screen.DataContext = new BleakwindBuffet.Data.Drinks.MarkarthMilk();
            orderControl.SwapScreen(screen);
        }
        /// <summary>
        /// Swaps screen from menu
        /// </summary>
        /// <param name="sender"> object parameter called sender</param>
        /// <param name="e"> routed evet args called e</param>
        private void AA_Click(object sender, RoutedEventArgs e)
        {

            var orderControl = this.FindRoot<OrderControl>();
            var screen = new AretinoAppleJuice();
            screen.DataContext = new BleakwindBuffet.Data.Drinks.AretinoAppleJuice();
            orderControl.SwapScreen(screen);
            
        }
        /// <summary>
        /// Swaps screen from menu
        /// </summary>
        /// <param name="sender"> object parameter called sender</param>
        /// <param name="e"> routed evet args called e</param>
        private void CC_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindRoot<OrderControl>();
            var screen = new CandlehearthCoffee();
            screen.DataContext = new BleakwindBuffet.Data.Drinks.CandlehearthCoffee();
            orderControl.SwapScreen(screen);
        }
        /// <summary>
        /// Swaps screen from menu
        /// </summary>
        /// <param name="sender"> object parameter called sender</param>
        /// <param name="e"> routed evet args called e</param>
        private void WW_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindRoot<OrderControl>();
            var screen = new WarriorWater();
            screen.DataContext = new BleakwindBuffet.Data.Drinks.WarriorWater();
            orderControl.SwapScreen(screen);
        }
        /// <summary>
        /// Swaps screen from menu
        /// </summary>
        /// <param name="sender"> object parameter called sender</param>
        /// <param name="e"> routed evet args called e</param>
        private void VS_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindRoot<OrderControl>();
            var screen = new VokunSalad();
            screen.DataContext = new BleakwindBuffet.Data.Sides.VokunSalad();
            orderControl.SwapScreen(screen);
        }
        /// <summary>
        /// Swaps screen from menu
        /// </summary>
        /// <param name="sender"> object parameter called sender</param>
        /// <param name="e"> routed evet args called e</param>
        private void FM_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindRoot<OrderControl>();
            var screen = new FriedMiraak();
            screen.DataContext = new BleakwindBuffet.Data.Sides.FriedMiraak();
            orderControl.SwapScreen(screen);
        }
        /// <summary>
        /// Swaps screen from menu
        /// </summary>
        /// <param name="sender"> object parameter called sender</param>
        /// <param name="e"> routed evet args called e</param>
        private void MOG_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindRoot<OrderControl>();
            var screen = new MadOtarGrits();
            screen.DataContext = new BleakwindBuffet.Data.Sides.MadOtarGrits();
            orderControl.SwapScreen(screen);
        }
        /// <summary>
        /// Swaps screen from menu
        /// </summary>
        /// <param name="sender"> object parameter called sender</param>
        /// <param name="e"> routed evet args called e</param>
        private void DWF_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindRoot<OrderControl>();
            var screen = new DragonbornWaffleFries();
            screen.DataContext = new BleakwindBuffet.Data.Sides.DragonbornWaffleFries();
            orderControl.SwapScreen(screen);
        }
        /// <summary>
        /// Swaps screen from menu
        /// </summary>
        /// <param name="sender"> object parameter called sender</param>
        /// <param name="e"> routed evet args called e</param>
        private void PP_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindRoot<OrderControl>();
            var screen = new PhillyPoacher();
            screen.DataContext = new BleakwindBuffet.Data.Entrees.PhillyPoacher();
            orderControl.SwapScreen(screen);
        }
    }
}
