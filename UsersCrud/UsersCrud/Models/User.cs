using System.Collections.Generic;

namespace UsersCrud.Models
{
    public partial class User
    {
        public User()
        {
            UserRole = new HashSet<UserRole>();
        }

        public int UserId { get; set; }
        public int UserGenderId { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string UserPassword { get; set; }

        public Gender UserGender { get; set; }
        public ICollection<UserRole> UserRole { get; set; }
    }
}
