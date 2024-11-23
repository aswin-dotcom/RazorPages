using Hub.Data;
using Hub.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace Hub.Pages.Companies
{
    [BindProperties]
    public class IndexModel : PageModel {
        private readonly ApplicationDbContext _db;

        public IndexModel(ApplicationDbContext db)
        {
                _db = db;
        }

       public IEnumerable<Company> Companies { get; set; }
        public void OnGet()
        {
            Companies = _db.companies.ToList();
        }
    }
}
