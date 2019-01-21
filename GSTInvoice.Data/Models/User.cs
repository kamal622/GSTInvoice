using System;
using System.Collections.Generic;

namespace GSTInvoice.Data.Models
{
    public partial class User
    {
        public int id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int UserTypeId { get; set; }
        public virtual UserType UserType { get; set; }
    }
}
