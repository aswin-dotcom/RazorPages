using Hub.Data;
using Hub.Models;
using Hub.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Hub.Pages.Companies
{
    [BindProperties]
    public class DeleteModel : PageModel
    {
        private readonly dboperaqtion _db;
        public DeleteModel(dboperaqtion db)
        {
                _db = db;
        }
        public Company Company { get; set; }
        public async Task OnGet(int id)
        {
            Company =  await _db.GetAsync(x => x.Id == id);
        }
        public async Task<IActionResult> OnPost()
        {
            if (Company != null)
            {
                _db.RemoveAsync(Company);
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
