using System;
using System.Collections.Generic;

namespace GSTInvoice.Data.Models
{
    public partial class State
    {
        public State()
        {
            this.Cities = new List<City>();
        }

        public int Id { get; set; }
        public string StateName { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public virtual ICollection<City> Cities { get; set; }
    }
}
