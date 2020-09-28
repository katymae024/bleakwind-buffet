/*
* Author: Katayoun Katy Davoudi
* Class name: extesionMethod.cs
* Purpose: finds the the root or the ancestor
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace PointOfSale
{
    /// <summary>
    /// class find the ancestor
    /// </summary>
    public static class extensionMethod
    {
        /// <summary>
        /// finds root or ancestor
        /// </summary>
        /// <typeparam name="T">given type is T</typeparam>
        /// <param name="element"> name of parameter is element </param>
        /// <returns>the root</returns>
        public static T FindRoot<T>(this DependencyObject element) where T : DependencyObject
        {
            var par = VisualTreeHelper.GetParent(element);
            if (par == null) return null;
            if (par is T) return par as T;
            return par.FindRoot<T>();
        }
    }
}
