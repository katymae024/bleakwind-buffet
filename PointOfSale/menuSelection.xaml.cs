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
            if (DataContext is BleakwindBuffet.Data.OrderClass order)
            {

                var bb = new BleakwindBuffet.Data.Entrees.BriarheartBurger();
                var orderControl = this.FindRoot<OrderControl>();
                var screen = new BriarheartBurger();
                screen.DataContext = bb;
                orderControl.SwapScreen(screen);
                order.Add(bb);
            }


        }
        /// <summary>
        /// Swaps screen from menu
        /// </summary>
        /// <param name="sender"> object parameter called sender</param>
        /// <param name="e"> routed evet args called e</param>
        private void DD_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is BleakwindBuffet.Data.OrderClass order)
            {

                var dd = new BleakwindBuffet.Data.Entrees.DoubleDraugr();
                var orderControl = this.FindRoot<OrderControl>();
                var screen = new DoubleDraugr();
                screen.DataContext = dd;
                orderControl.SwapScreen(screen);
                order.Add(dd);
            }
        }
        /// <summary>
        /// Swaps screen from menu
        /// </summary>
        /// <param name="sender"> object parameter called sender</param>
        /// <param name="e"> routed evet args called e</param>
        private void TT_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is BleakwindBuffet.Data.OrderClass order)
            {

                var tt = new BleakwindBuffet.Data.Entrees.ThalmorTriple();
                var orderControl = this.FindRoot<OrderControl>();
                var screen = new ThalmorTriple();
                screen.DataContext = tt;
                orderControl.SwapScreen(screen);
                order.Add(tt);

            }
        }
        /// <summary>
        /// Swaps screen from menu
        /// </summary>
        /// <param name="sender"> object parameter called sender</param>
        /// <param name="e"> routed evet args called e</param>
        private void SS_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is BleakwindBuffet.Data.OrderClass order)
            {
                var ss = new BleakwindBuffet.Data.Entrees.SmokehouseSkeleton();
                var orderControl = this.FindRoot<OrderControl>();
                var screen = new SmokehouseSkeleton();
                screen.DataContext = ss;
                orderControl.SwapScreen(screen);
                order.Add(ss);
            }
        }
        /// <summary>
        /// Swaps screen from menu
        /// </summary>
        /// <param name="sender"> object parameter called sender</param>
        /// <param name="e"> routed evet args called e</param>
        private void GO_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is BleakwindBuffet.Data.OrderClass order)
            {

                var go = new BleakwindBuffet.Data.Entrees.GardenOrcOmelette();
                var orderControl = this.FindRoot<OrderControl>();
                var screen = new GardenOrcOmelette();
                screen.DataContext = go;
                orderControl.SwapScreen(screen);
                order.Add(go);
            }
        }
        /// <summary>
        /// doesn't do anything since thugs t-bone doesn't have special instructions
        /// </summary>
        /// <param name="sender"> object parameter called sender</param>
        /// <param name="e"> routed evet args called e</param>
        private void TTB_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is BleakwindBuffet.Data.OrderClass order)
            {
                var ttb = new BleakwindBuffet.Data.Entrees.ThugsTBone();
                order.Add(ttb);
            }
        }
        /// <summary>
        /// Swaps screen from menu
        /// </summary>
        /// <param name="sender"> object parameter called sender</param>
        /// <param name="e"> routed evet args called e</param>
        private void SSoda_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is BleakwindBuffet.Data.OrderClass order)
            {
                var ssoda = new BleakwindBuffet.Data.Drinks.SailorSoda();
                var orderControl = this.FindRoot<OrderControl>();
                var screen = new SailorSoda();
                screen.DataContext = ssoda;
                orderControl.SwapScreen(screen);
                order.Add(ssoda);
            }
        }
        /// <summary>
        /// Swaps screen from menu
        /// </summary>
        /// <param name="sender"> object parameter called sender</param>
        /// <param name="e"> routed evet args called e</param>
        private void MM_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is BleakwindBuffet.Data.OrderClass order)
            {
                var mm = new BleakwindBuffet.Data.Drinks.MarkarthMilk();
                var orderControl = this.FindRoot<OrderControl>();
                var screen = new MarkathMilk();
                screen.DataContext = mm;
                orderControl.SwapScreen(screen);
                order.Add(mm);
            }
        }
        /// <summary>
        /// Swaps screen from menu
        /// </summary>
        /// <param name="sender"> object parameter called sender</param>
        /// <param name="e"> routed evet args called e</param>
        private void AA_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is BleakwindBuffet.Data.OrderClass order)
            {
                var aa = new BleakwindBuffet.Data.Drinks.AretinoAppleJuice();
                var orderControl = this.FindRoot<OrderControl>();
                var screen = new AretinoAppleJuice(order);
                screen.DataContext = aa;
                orderControl.SwapScreen(screen);
                //order.Add(aa);
            }
            
        }
        /// <summary>
        /// Swaps screen from menu
        /// </summary>
        /// <param name="sender"> object parameter called sender</param>
        /// <param name="e"> routed evet args called e</param>
        private void CC_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is BleakwindBuffet.Data.OrderClass order)
            {
                var cc = new BleakwindBuffet.Data.Drinks.CandlehearthCoffee();
                var orderControl = this.FindRoot<OrderControl>();
                var screen = new CandlehearthCoffee();
                screen.DataContext = cc;
                orderControl.SwapScreen(screen);
                order.Add(cc);

            }
        }
        /// <summary>
        /// Swaps screen from menu
        /// </summary>
        /// <param name="sender"> object parameter called sender</param>
        /// <param name="e"> routed evet args called e</param>
        private void WW_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is BleakwindBuffet.Data.OrderClass order)
            {
                var ww = new BleakwindBuffet.Data.Drinks.WarriorWater();
                var orderControl = this.FindRoot<OrderControl>();
                var screen = new WarriorWater();
                screen.DataContext = ww;
                orderControl.SwapScreen(screen);
                order.Add(ww);
            }
        }
        /// <summary>
        /// Swaps screen from menu
        /// </summary>
        /// <param name="sender"> object parameter called sender</param>
        /// <param name="e"> routed evet args called e</param>
        private void VS_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is BleakwindBuffet.Data.OrderClass order)
            {
                var vs = new BleakwindBuffet.Data.Sides.VokunSalad();
                var orderControl = this.FindRoot<OrderControl>();
                var screen = new VokunSalad();
                screen.DataContext = vs;
                orderControl.SwapScreen(screen);
                order.Add(vs);
            }
        }
        /// <summary>
        /// Swaps screen from menu
        /// </summary>
        /// <param name="sender"> object parameter called sender</param>
        /// <param name="e"> routed evet args called e</param>
        private void FM_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is BleakwindBuffet.Data.OrderClass order)
            {
                var fm = new BleakwindBuffet.Data.Sides.FriedMiraak();
                var orderControl = this.FindRoot<OrderControl>();
                var screen = new FriedMiraak();
                screen.DataContext = fm;
                orderControl.SwapScreen(screen);
                order.Add(fm);
            }

        }
        /// <summary>
        /// Swaps screen from menu
        /// </summary>
        /// <param name="sender"> object parameter called sender</param>
        /// <param name="e"> routed evet args called e</param>
        private void MOG_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is BleakwindBuffet.Data.OrderClass order)
            {
                var mog = new BleakwindBuffet.Data.Sides.MadOtarGrits();
                var orderControl = this.FindRoot<OrderControl>();
                var screen = new MadOtarGrits();
                screen.DataContext = mog;
                orderControl.SwapScreen(screen);
                order.Add(mog);
            }
        }
        /// <summary>
        /// Swaps screen from menu
        /// </summary>
        /// <param name="sender"> object parameter called sender</param>
        /// <param name="e"> routed evet args called e</param>
        private void DWF_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is BleakwindBuffet.Data.OrderClass order)
            {
                var dwf = new BleakwindBuffet.Data.Sides.DragonbornWaffleFries();
                var orderControl = this.FindRoot<OrderControl>();
                var screen = new DragonbornWaffleFries(order);
                screen.DataContext = dwf;
                orderControl.SwapScreen(screen);

                //order.Add(dwf);
            }
        }
        /// <summary>
        /// Swaps screen from menu
        /// </summary>
        /// <param name="sender"> object parameter called sender</param>
        /// <param name="e"> routed evet args called e</param>
        private void PP_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is BleakwindBuffet.Data.OrderClass order)
            {
                var pp = new BleakwindBuffet.Data.Entrees.PhillyPoacher();
                var orderControl = this.FindRoot<OrderControl>();
                var screen = new PhillyPoacher();
                screen.DataContext = pp;
                orderControl.SwapScreen(screen);
                order.Add(pp);
            }
        }
    }
}
