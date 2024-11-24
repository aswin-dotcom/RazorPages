using Hub.Data;
using Hub.Models;
using Hub.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Hub.Pages.Companies
{
    [BindProperties]
    public class EditModel : PageModel { 


        private readonly dboperaqtion _db;
        public EditModel(dboperaqtion db)
        {
                _db = db;
        }




        public Company Company { get; set; }
        public async Task OnGet(int id)
        {
            Company =await _db.GetAsync(item => item.Id == id);
        }
        public async Task<IActionResult> OnPost()
        {
            if(ModelState.IsValid)
            {
                await _db.UpdateAsync(Company); 
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
