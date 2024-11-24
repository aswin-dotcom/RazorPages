using Hub.Data;
using Hub.Models;
using Hub.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace Hub.Pages.Companies
{
    [BindProperties]
    public class IndexModel : PageModel {
        private readonly dboperaqtion _db;

        public IndexModel(dboperaqtion db)
        {
                _db = db;
        }

       public IEnumerable<Company> Companies { get; set; }
        public async Task OnGet()
        {
            Companies =await _db.GetAllAsync();
        }
    }
}
