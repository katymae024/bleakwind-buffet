/*
* Author: Katayoun Katy Davoudi
* Class name: Index.cshtml.cs
* Purpose: Binds properties and also making the functionality of website
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BleakwindBuffet.Data.Drink_Classes;
using BleakwindBuffet.Data.Entrée_classes;
using BleakwindBuffet.Data.Interfaces;
using BleakwindBuffet.Data.Side_Classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;


namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        [BindProperty]
        public int? CaloriesMin { get; set; }
        
        [BindProperty]
        public int? CaloriesMax { get; set; }
        [BindProperty]
        public double? PriceMin { get; set; }
        [BindProperty]
        public double? PriceMax { get; set; }
        [BindProperty]
        public string Description { get; }

       [BindProperty] 
       public int Calories { get; }

       [BindProperty]
        public int Price { get; }

        public IEnumerable<IOrderItem> MenuItems { get; set; }

        public string[] Types { get; set; } = new string[3];

        public string SearchTerms { get; set; }

        public void OnGet(string SearchTerms, string[] Types, double? PriceMin, double? PriceMax, int? CaloriesMin, int? CaloriesMax)
        {
            this.CaloriesMin = CaloriesMin;
            this.CaloriesMax = CaloriesMax;
            this.PriceMax = PriceMax;
            this.PriceMin = PriceMin;
            this.Types = Types;
            this.SearchTerms = SearchTerms;
            MenuItems = MenuDatabase.All;
            
           
            if (SearchTerms != null)
            {
                MenuItems = MenuItems.Where(item => item.ToString() != null && item.ToString().Contains(SearchTerms, StringComparison.InvariantCultureIgnoreCase));
            }

            if (Types != null && Types.Length != 0)
            {
                MenuItems = MenuItems.Where(item => item is Entree && Types.Contains("Entrees") || item is Side && Types.Contains("Sides") || item is Drink && Types.Contains("Drinks"));
            }

            if (CaloriesMin == null && CaloriesMax == null)
            {

            }
            else if (CaloriesMin == null)
            {
                
                MenuItems = MenuItems.Where(item => item.Calories != null && item.Calories <= CaloriesMax);

            }
            else if (CaloriesMax == null)
            {
                MenuItems = MenuItems.Where(item => item.Calories != null && item.Calories >= CaloriesMin);
            }
            else
            {
                MenuItems = MenuItems.Where(item => item.Calories != null && item.Calories >= CaloriesMin && item.Calories <= CaloriesMax);
            }

            if (PriceMin == null && PriceMax == null)
            {

            }
            else if (PriceMin == null)
            {
                
                MenuItems = MenuItems.Where(item => item.Price != null && item.Price <= PriceMax);

            }
            else if (PriceMax == null)
            {
                MenuItems = MenuItems.Where(item => item.Price != null && item.Price >= PriceMin);
            }
            else
            {
                MenuItems = MenuItems.Where(item => item.Price != null && item.Price >= PriceMin && item.Price <= PriceMax);
            }

        }

        
    }
}
