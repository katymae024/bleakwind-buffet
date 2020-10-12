/*Author: Katayoun Katy Davoudi
 * Class: Order.cs
 * Purpose: Class for having the properties and different methods for order class
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using BleakwindBuffet.Data.Interfaces;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Collections;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// containing all the methods/private fields for order class
    /// </summary>
    public class OrderClass: ObservableCollection<IOrderItem>, ICollection, INotifyCollectionChanged, INotifyPropertyChanged
    {
        /// <summary>
        /// private backing variable for order constructor
        /// </summary>
        private int numOrder = 0;
        /// <summary>
        /// constructor of the class
        /// </summary>
        /// <param name="orderNum">integer parameter</param>
        public OrderClass(int orderNum)
        {
             numOrder = orderNum;
             CollectionChanged += CollectionChangedListener;
        }
        /// <summary>
        /// managin order number returning the variable
        /// </summary>
        public int OrderNumber 
        {
            get
            {
                return numOrder;
            } 
        }
        /// <summary>
        /// public getter for calories
        /// </summary>
        public uint Calories
        {
            get
            {
                uint calories = 0;
                foreach(IOrderItem item in this)
                {
                    calories += item.Calories;
                }
                return calories;
            }
        }
        /// <summary>
        /// public property for sales tax rate
        /// </summary>
        public double SalesTaxRate { get; set; } = 0.12;

        public IEnumerable<IOrderItem> ItemList
        {
            get
            {
                return (IEnumerable<IOrderItem>)this;
            }
        }
        /// <summary>
        /// public property for subtotal
        /// </summary>
        public double Subtotal 
        {
            get
            {
                double subT = 0;
                foreach(IOrderItem item in this)
                {
                    subT += item.Price;
                }
                return subT;
            }
        }
        /// <summary>
        /// public property for tax
        /// </summary>
        public double Tax 
        {
            get
            {
                double tax = Subtotal * SalesTaxRate;
                return tax;
            }

        }
        /// <summary>
        /// public property for total
        /// </summary>
        public double Total 
        {
            get
            {
                double total = Subtotal + Tax;
                return total;
            } 
        }
        /// <summary>
        /// method for collection changed listener dealing with calories, subtotal, tax and total
        /// </summary>
        /// <param name="sender">parameter object type</param>
        /// <param name="e">parameter notify property changed event args</param>
        void CollectionChangedListener(object sender, NotifyCollectionChangedEventArgs e)
        {
            OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
            OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
            OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
            OnPropertyChanged(new PropertyChangedEventArgs("Total"));


            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    foreach (IOrderItem item in e.NewItems)
                    {
                        item.PropertyChanged += CollectionItemChangedListener;
                    }
                    break;
                case NotifyCollectionChangedAction.Remove:
                    foreach (IOrderItem item in e.OldItems)
                    {
                        item.PropertyChanged -= CollectionItemChangedListener;
                    }
                    break;
                case NotifyCollectionChangedAction.Reset:
                    throw new NotImplementedException("NotifyCollectionChangedAction.Reset not supported");
            }

        }
        /// <summary>
        /// method for collection item changed listener dealing with calories, subtotal, tax and total
        /// </summary>
        /// <param name="sender">parameter object type</param>
        /// <param name="e">parameter notify property changed event args</param>
        private void CollectionItemChangedListener(object sender, PropertyChangedEventArgs e)
        {
            

            if (e.PropertyName == "Price")
            {
                OnPropertyChanged(new PropertyChangedEventArgs("Total"));
                OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
                OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
                


            }
            if (e.PropertyName == "Calories")
            {
                OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
                
            }
            

        }

    }
}
