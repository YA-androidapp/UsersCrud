using System.Collections.Generic;

namespace UsersCrud.Models
{
    public partial class Gender
    {
        public Gender()
        {
            User = new HashSet<User>();
        }

        public int GenderId { get; set; }
        public string GenderName { get; set; }

        public ICollection<User> User { get; set; }
    }
}
