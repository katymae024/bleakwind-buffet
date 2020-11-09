/*
* Author: Katayoun Katy Davoudi
* Class name: MenuDatabase.cs
* Purpose: provides methods, filters, types regarding menu classes
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using BleakwindBuffet.Data.Interfaces;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrée_classes;
using BleakwindBuffet.Data.Drink_Classes;
using BleakwindBuffet.Data.Side_Classes;

namespace Website
{
    /// <summary>
    /// provided the methods of menu database
    /// </summary>
    public static class MenuDatabase
    {
        /// <summary>
        /// creating list of iorderitem 
        /// </summary>
        private static List<IOrderItem> item = new List<IOrderItem>();

        /// <summary>
        /// string array for sides
        /// </summary>
        public static string[] Sides { get; private set; } 
        /// <summary>
        /// returns item in all menu items
        /// </summary>
        public static IEnumerable<IOrderItem> All { get { return item; } }
        /// <summary>
        /// Type options
        /// </summary>
        public static string[] Types
        {
            get => new string[]
            {
            "Entrees",
            "Drinks",
            "Sides"
            };
        }

        /// <summary>
        /// Filters the provided collection of menu items
        /// </summary>
        /// <param name="fullList">The collection of item to filter</param>
        /// <param name="type">The type to include</param>
        /// <returns>A collection containing only type that match the filter</returns>
        public static IEnumerable<IOrderItem> FilterByTypes(IEnumerable<IOrderItem> fullList, IEnumerable<string> type)
        {

            // If no filter is specified, just return the provided collection
            if (type == null || type.Count() == 0) return fullList;
            // Filter the supplied collection of items
            List<IOrderItem> results = new List<IOrderItem>();
            foreach (IOrderItem i in fullList)
            {
                if (i is Entree && type.Contains("Entrees"))
                {
                    results.Add(i);  
                                      
                }
                else if(i is Drink && type.Contains("Drinks"))
                {
                    results.Add(i);
                }
                else if (i is Side && type.Contains("Sides"))
                {
                    results.Add(i);
                }

            }
            return results;

        }
        /// <summary>
        /// Searches the items in the database  for matches 
        /// </summary>
        /// <param name="terms"> the term to search for </param>
        /// <returns>The results of the search</returns>
        public static IEnumerable<IOrderItem> Search(string terms)
        {
            List<IOrderItem> results = new List<IOrderItem>();
            //null check
            if (terms == null) return All;

            foreach (IOrderItem i in All)
            {

                //adds the i if the title is a match
                if (i.ToString() != null && i.ToString().ToLower().Contains(terms.ToLower()))
                {
                    results.Add(i);
                }
            }
            return results;

        }
        /// <summary>
        /// constructor of menu database class
        /// </summary>
        static MenuDatabase()
        {
            item = (List<IOrderItem>)Menu.All();
        }
        /// <summary>
        /// Filters the provided collection of menu items
        /// to those with calorie ratings falling within
        /// the specified range
        /// </summary>
        /// <param name="items">The collection of items to filter</param>
        /// <param name="min">The minimum range value</param>
        /// <param name="max">The maximum range value</param>
        /// <returns>The filtered movie collection</returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> items, int? min, int? max)
        {

            var results = new List<IOrderItem>();
            if (min == null && max == null) return items;
            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Calories <= max) results.Add(item);
                }
                return results;
            }
            // only a minimum specified
            if (max == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Calories >= min) results.Add(item);
                }
                return results;
            }
            // Both minimum and maximum specified
            foreach (IOrderItem item in items)
            {
                if (item.Calories >= min && item.Calories <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }
        /// <summary>
        /// Filters the provided collection of menu items
        /// to those with price ranges falling within
        /// the specified range
        /// </summary>
        /// <param name="items">The collection of item to filter</param>
        /// <param name="min">The minimum range value</param>
        /// <param name="max">The maximum range value</param>
        /// <returns>The filtered item collection</returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> items, double? min, double? max)
        {

            var results = new List<IOrderItem>();
            if (min == null && max == null) return items;
            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Price <= max) results.Add(item);
                }
                return results;
            }
            // only a minimum specified
            if (max == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Price >= min) results.Add(item);
                }
                return results;
            }
            // Both minimum and maximum specified
            foreach (IOrderItem item in items)
            {
                if (item.Price >= min && item.Price <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }
    }

}
