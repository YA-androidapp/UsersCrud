using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using UsersCrud.Models;

namespace UsersCrud.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
    }
}
