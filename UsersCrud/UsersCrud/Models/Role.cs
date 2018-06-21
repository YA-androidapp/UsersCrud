using System.Collections.Generic;

namespace UsersCrud.Models
{
    public partial class Role
    {
        public Role()
        {
            UserRole = new HashSet<UserRole>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; }

        public ICollection<UserRole> UserRole { get; set; }
    }
}
