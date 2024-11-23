using Hub.Data;
using Hub.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Hub.Pages.Companies
{
    [BindProperties]
    public class createModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public createModel(ApplicationDbContext db)
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
                _db.companies.Add(Company);
                _db.SaveChanges();
                return RedirectToPage("Index");
            }
            return Page();

        }
    }
}
