

namespace ThreeLayerAssignment
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.UI;
    using System.Web.UI.WebControls;
    using BusinessLogic;

    /// <summary>
    /// Customers class.
    /// </summary>
    public partial class Customers : System.Web.UI.Page
    {
        /// <summary>
        /// This is Customers.
        /// </summary>
        /// <param name="sender">sender obj.</param>
        /// <param name="e">envt argument.</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            CustomersBL customerObject = new CustomersBL();
            this.CustomersGv.DataSource = customerObject.GridViewBind();
            this.CustomersGv.DataBind();
        }
    }
}