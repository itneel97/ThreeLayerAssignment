using BusinessObject;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class OrdersBL
    {
        /// <summary>
        /// we are not passing any parameters since we don't need any thing back from database.
        /// </summary>
        /// <returns></returns>
        public DataTable BindGridView()
        {
            OrdersDA orderObj = new OrdersDA();
            
            return orderObj.BindGridView();
        }
    }
}
