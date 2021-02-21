// ----------------------------------------------------------------------
// <copyright file="Orders.aspx.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
// ----------------------------------------------------------------------
namespace ThreeLayerAssignment
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.UI;
    using System.Web.UI.WebControls;
    using BusinessLogic;
    using BusinessObject;

    /// <summary>
    ///  Order Class.
    /// </summary>
    public partial class Orders : System.Web.UI.Page
    {
        /// <summary>
        /// Page load event.
        /// </summary>
        /// <param name="sender">sender object.</param>
        /// <param name="e">event args.</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            OrdersBL ordersObject = new OrdersBL();
            this.OrderGv.DataSource = ordersObject.BindGridView();
            this.OrderGv.DataBind();
        }
    }
}