using Hub.Data;
using Hub.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Hub.Pages.Companies
{
    [BindProperties]
    public class EditModel : PageModel { 


        private readonly ApplicationDbContext _db;
        public EditModel(ApplicationDbContext db)
        {
                _db = db;
        }




        public Company Company { get; set; }
        public void OnGet(int id)
        {
            Company = _db.companies.FirstOrDefault(item => item.Id == id);
        }
        public async Task<IActionResult> OnPost()
        {
            if(ModelState.IsValid)
            {
                _db.companies.Update(Company);
                _db.SaveChanges();
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
