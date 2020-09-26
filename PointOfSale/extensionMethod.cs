using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace PointOfSale
{
    public static class extensionMethod
    {
        public static T FindRoot<T>(this DependencyObject element) where T : DependencyObject
        {
            var par = VisualTreeHelper.GetParent(element);
            if (par == null) return null;
            if (par is T) return par as T;
            return par.FindRoot<T>();
        }
    }
}
