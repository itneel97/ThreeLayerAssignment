// ----------------------------------------------------------------------
// <copyright file="Salesman.aspx.cs" company="PlaceholderCompany">
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
    /// This class show data of salesman in grid view as well as insert into table.
    /// </summary>
    public partial class Salesman : System.Web.UI.Page
    {
        /// <summary>
        /// this is pageload event.
        /// </summary>
        /// <param name="sender">sender object.</param>
        /// <param name="e">Event Args.</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            SalesmanBL newSalesmanBL = new SalesmanBL();
            if (!this.Page.IsPostBack)
            {
                
                this.SalesmanGv.Columns[0].HeaderText = "ID";
                this.SalesmanGv.Columns[1].HeaderText = "Name";
                this.SalesmanGv.Columns[2].HeaderText = "City";
                this.SalesmanGv.Columns[3].HeaderText = "Commission";
                this.SalesmanGv.DataSource = newSalesmanBL.GridViewBind();
                this.SalesmanGv.DataBind();
            }
        }

        /// <summary>
        ///  This is button click event and inserts new saleman on submit click.
        /// </summary>
        /// <param name="sender">sender Object.</param>
        /// <param name="e">evnet arg.</param>
        protected void SubmitBtn_Click(object sender, EventArgs e)
        {
            int rowInserted = 0;
            SalesmanBO newSalesman = new SalesmanBO()
            {
                Id = Convert.ToInt32(this.SalesmanIdTxt.Text),
                Name = this.SalesmanNameTxt.Text,
                City = this.SalesmanCityTxt.Text,
                Commission = Convert.ToDecimal(this.SalesmanCommissionTxt.Text),
            };

            SalesmanBL newSalesmanBL = new SalesmanBL();
            rowInserted = newSalesmanBL.InsertSalesman(newSalesman);

            if (rowInserted > 0)
            {
                Console.WriteLine($"Total {rowInserted} Row(s) Affected ");
            }

            this.SalesmanIdTxt.Text = string.Empty;
            this.SalesmanNameTxt.Text = string.Empty;
            this.SalesmanCityTxt.Text = string.Empty;
            this.SalesmanCommissionTxt.Text = string.Empty;
            this.SalesmanIdTxt.Focus();

            this.SalesmanGv.DataSource = newSalesmanBL.GridViewBind();
            this.SalesmanGv.DataBind();
        }

        
    }
}