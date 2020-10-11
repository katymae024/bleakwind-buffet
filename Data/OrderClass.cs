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
    public class OrderClass: ObservableCollection<IOrderItem>, ICollection, INotifyCollectionChanged, INotifyPropertyChanged
    {
        //provide a property Calories which is a unsigned integer, and the sum of all the calories of the item sin the order.
        //private uint calories;
        private int numOrder = 0;
        //private int nextOrderNum = 1;
        public OrderClass(int orderNum)
        {
             numOrder = orderNum;
            // nextOrderNum++;


             CollectionChanged += CollectionChangedListener;
        }
        public int OrderNumber 
        {
            get
            {
                return numOrder;
            } 
        }

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
        public double SalesTaxRate { get; set; } = 0.12;

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

        public double Tax 
        {
            get
            {
                double tax = Subtotal * SalesTaxRate;
                return tax;
            }

        }

        public double Total 
        {
            get
            {
                double total = Subtotal + Tax;
                return total;
            } 
        }
        
        
        
        
        
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
