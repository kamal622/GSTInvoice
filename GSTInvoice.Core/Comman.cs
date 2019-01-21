using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSTInvoice.Core
{
    public class Comman
    {
        private static string mProduct_Name = "";
        private static int userId = 0;
        private static int userTypeId = 0;
        private static string userName = null;

        public static string Product_Name
        {
            get
            {
                if ((mProduct_Name.Length) == 0)
                    mProduct_Name = "GST Accouting System";
                return mProduct_Name;
            }

            set
            {
                mProduct_Name = value;
            }
        }

        public static int UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        public static string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public static int UserTypeId
        {
            get { return userTypeId; }
            set { userTypeId = value; }
        }
        
    }                     
}
