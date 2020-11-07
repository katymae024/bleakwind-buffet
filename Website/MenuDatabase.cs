﻿using System;
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
    public static class MenuDatabase
    {
        private static List<IOrderItem> item = new List<IOrderItem>();


        public static string[] Sides { get; private set; } 

        public static IEnumerable<IOrderItem> All { get { return item; } }

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
        /// Filters the provided collection of movies
        /// </summary>
        /// <param name="fullList">The collection of item to filter</param>
        /// <param name="type">The type to include</param>
        /// <returns>A collection containing only movies that match the filter</returns>
        public static IEnumerable<IOrderItem> FilterByTypes(IEnumerable<IOrderItem> fullList, IEnumerable<string> type)
        {

            // If no filter is specified, just return the provided collection
            if (type == null || type.Count() == 0) return fullList;
            // Filter the supplied collection of movies
            List<IOrderItem> results = new List<IOrderItem>();
            foreach (IOrderItem i in fullList)
            {
                if (i is Entree && type.Contains("Entrees"))
                {
                    results.Add(i);  //am I pulling the wrong entree, drink or side? showing error 
                    //checkboxes
                                      
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
        //filter for cal
        //filter for price
        static MenuDatabase()
        {
            item = (List<IOrderItem>)Menu.All();
        }
        /// <summary>
        /// Filters the provided collection of movies
        /// to those with IMDB ratings falling within
        /// the specified range
        /// </summary>
        /// <param name="items">The collection of movies to filter</param>
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
        /// Filters the provided collection of movies
        /// to those with IMDB ratings falling within
        /// the specified range
        /// </summary>
        /// <param name="items">The collection of movies to filter</param>
        /// <param name="min">The minimum range value</param>
        /// <param name="max">The maximum range value</param>
        /// <returns>The filtered movie collection</returns>
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
