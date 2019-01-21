using System;
using System.Collections.Generic;

namespace GSTInvoice.Data.Models
{
    public partial class UserType
    {
        public UserType()
        {
            this.Users = new List<User>();
        }

        public int Id { get; set; }
        public string user_name { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
