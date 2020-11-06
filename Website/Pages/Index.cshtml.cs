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

        public IEnumerable<IOrderItem> MenuItems { get; set; }

        public string[] Types { get; set; }

        public string SearchTerms { get; set; }

        public void OnGet(string SearchTerms, string[] Type)
        {
            MenuItems = MenuDatabase.Search(SearchTerms);
            MenuItems = MenuDatabase.FilterByTypes(MenuItems, Type);
        }
    }
}
