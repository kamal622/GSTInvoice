using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSTInvoice.Service.Model
{
    class AccountResultModel
    {
        public int Id { get; set; }
        public string BusinessName { get; set; }
        public string DisplayName { get; set; }
        public string MobileNo { get; set; }
        public string GSTINno { get; set; }
        public string Email { get; set; }
        //public string CreatDate { get; set; }
        //public string CreateBy { get; set; }
    }


}
