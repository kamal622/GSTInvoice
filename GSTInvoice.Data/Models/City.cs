using System;
using System.Collections.Generic;

namespace GSTInvoice.Data.Models
{
    public partial class City
    {
        public int Id { get; set; }
        public int StateId { get; set; }
        public string CityName { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public virtual State State { get; set; }
    }
}
