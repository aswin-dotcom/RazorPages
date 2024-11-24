using Hub.Data;
using Hub.Models;
using Hub.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Hub.Pages.Companies
{
    [BindProperties]
    public class createModel : PageModel
    {
        private readonly dboperaqtion  _db;
        public createModel(dboperaqtion db)
        {
                _db= db;
        }
        public Company Company { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost() {
            if (ModelState.IsValid)
            {
                _db.createAsync(Company);
                return RedirectToPage("Index");
            }
            return Page();

        }
    }
}
