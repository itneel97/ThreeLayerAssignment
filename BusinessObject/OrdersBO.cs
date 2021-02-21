// ----------------------------------------------------------------------
// <copyright file="Orders.cs" company="companyName">
//     Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
// ----------------------------------------------------------------------
namespace BusinessObject
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// This is Business object for Orders.
    /// </summary>
    public class OrdersBO
    {
        private int _orderNo;
        private double _purchAmount;
        private string _orderDate;
        private int _customerId;
        private int _salesmanId;

        /// <summary>
        ///  Gets or Sets Date Ordered.
        /// </summary>
        public string OrderDate { get => this._orderDate; set => this._orderDate = value; }

        /// <summary>
        ///  Gets or Sets Customers Id (FK).
        /// </summary>
        public int CustomerId { get => this._customerId; set => this._customerId = value; }

        /// <summary>
        ///  Gets or Sets SalesmanId reference (FK).
        /// </summary>
        public int SalesmanId { get => this._salesmanId; set => this._salesmanId = value; }

        /// <summary>
        ///  Gets or Sets Order Number.
        /// </summary>
        public int OrderNo { get => this._orderNo; set => this._orderNo = value; }

        /// <summary>
        ///  Gets or Sets Purchase Amount.
        /// </summary>
        public double PurchAmount { get => this._purchAmount; set => this._purchAmount = value; }
    }
}
