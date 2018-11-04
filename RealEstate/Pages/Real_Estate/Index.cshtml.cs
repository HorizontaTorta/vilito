using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RealEstate.Models;

namespace RealEstate.Pages.Real_Estate
{
    public class IndexModel : PageModel
    {
        private readonly RealEstate.Models.RealEstateContext _context;

        public IndexModel(RealEstate.Models.RealEstateContext context)
        {
            _context = context;
        }

        public IList<Property> Property { get;set; }
        public string SearchString { get; set; }

        public async Task OnGetAsync(string searchString)
        {
            
            var estate = from е in _context.Property
                         select е;

            if (!String.IsNullOrEmpty(searchString))
            {
                estate = estate.Where(s => s.Address.Contains(searchString));
            }



            Property = await estate.ToListAsync();
            SearchString = searchString;
        }

    }
}
