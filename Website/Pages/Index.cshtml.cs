using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BleakwindBuffet.Data.Interfaces;
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


        public IEnumerable<IOrderItem> MenuItems { get; set; }

        public string[] Types { get; set; } = new string[3];

        public string SearchTerms { get; set; }

        public void OnGet(string SearchTerms, string[] Types, double? PriceMin, double? PriceMax, int? CaloriesMin, int? CaloriesMax)
        {
          
            MenuItems = MenuDatabase.Search(SearchTerms);
            MenuItems = MenuDatabase.FilterByTypes(MenuItems, Types);
            this.CaloriesMin = CaloriesMin;
            this.CaloriesMax = CaloriesMax;
            this.PriceMax = PriceMax;
            this.PriceMin = PriceMin;
            MenuItems = MenuDatabase.FilterByCalories(MenuItems, CaloriesMin, CaloriesMax );
            MenuItems = MenuDatabase.FilterByPrice(MenuItems, PriceMin, PriceMax);

        }

        public object PersistCheckbox(string type)
        {
            if(type == "Entrees")
            {
                Types[0] = type;
            }
            else if (type == "Drinks")
            {
                Types[1] = type;
            }
            else if (type == "Sides")
            {
                Types[2] = type;
            }
            return type;
        }
    }
}
