using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using UsersCrud.Models;

namespace UsersCrud.Controllers
{
    public class CreateModel : PageModel
    {
        private readonly UsersCrud.Models.usersDbContext _context;

        public CreateModel(UsersCrud.Models.usersDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["UserGenderId"] = new SelectList(_context.Gender, "GenderId", "GenderName");
            return Page();
        }

        [BindProperty]
        public User User { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.User.Add(User);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}