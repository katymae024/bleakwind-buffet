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
        int numOrder;
        int nextOrderNum = 1;
        public OrderClass()
        {
            this.numOrder = nextOrderNum;
            nextOrderNum++;

            CollectionChanged += CollectionChangedListener;
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

        //add and remove methods
        //eventlistener attach them to entree property drink and side
        void CollectionChangedListener(object sender, NotifyCollectionChangedEventArgs e)
        {
            OnPropertyChanged(new PropertyChangedEventArgs("SpecialInstructions"));

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

        void CollectionItemChangedListener(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Price")
            {
                OnPropertyChanged(new PropertyChangedEventArgs("Price"));

            }
            if (e.PropertyName == "Calories")
            {
                OnPropertyChanged(new PropertyChangedEventArgs("Calories"));

            }
            if (e.PropertyName == "SpecialInstructions")
            {
                OnPropertyChanged(new PropertyChangedEventArgs("SpecialInstructions"));

            }

        }

    }
}
