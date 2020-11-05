using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using BleakwindBuffet.Data.Interfaces;
using BleakwindBuffet.Data;

namespace Website
{
    public static class MenuDatabase
    {
        private static List<IOrderItem> item = new List<IOrderItem>();


        public static string[] Sides { get; private set; } 

        public static IEnumerable<IOrderItem> All { get { return item; } }

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
                if (i.Title != null && i.Title.Contains(terms, StringComparison.CurrentCultureIgnoreCase))
                {
                    results.Add(i);
                }
            }
            return results;

        }
        static MenuDatabase()
        {
            item = Menu.
        }
    }
}
