namespace BusinessLogic
{
    using BusinessObject;
    using DataAccess;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Salesman class.
    /// </summary>
    public class SalesmanBL
    {
        /// <summary>
        /// this method expects Business object of salesman and pass it to DataAccess model and from there it get back row affected.
        /// </summary>
        /// <param name="newSalesman"></param>
        /// <returns></returns>
        public int InsertSalesman(SalesmanBO newSalesman)
        {
            SalesmanDA newSalesmanDA = new SalesmanDA();
            newSalesmanDA.InsertSalesman(newSalesman);

            return newSalesmanDA.InsertSalesman(newSalesman);
        }

        public DataSet GridViewBind()
        {
            DataAccess.SalesmanDA newSalesman = new SalesmanDA();
            return newSalesman.BindGridView();
        }

    }
}
