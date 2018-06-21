using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using UsersCrud.Models;

namespace UsersCrud.Controllers
{
    public class IndexModel : PageModel
    {
        private readonly UsersCrud.Models.usersDbContext _context;

        public IndexModel(UsersCrud.Models.usersDbContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; }

        public async Task OnGetAsync()
        {
            User = await _context.User
                .Include(u => u.UserGender).ToListAsync();
        }
    }
}
