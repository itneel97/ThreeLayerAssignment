
using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class CustomersBL
    {
        public DataTable GridViewBind()
        {
            CustomersDA cust = new CustomersDA();
            return cust.BindGridView();
        }
    }
}
