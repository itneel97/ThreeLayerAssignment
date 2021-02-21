// ----------------------------------------------------------------------
// <copyright file="Customers.cs" company="companyName">
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
    /// This is Business Object for Customers.
    /// </summary>
    public class CustomersBO
    {
        private int _id;
        private string _name;
        private string _city;
        private int _grade;
        private int _salesmanId;

        /// <summary>
        ///  Gets or Sets Customer_id.
        /// </summary>
        public int Id
        { get => this._id; set => this._id = value; }

        /// <summary>
        ///  Gets or Sets Customer city.
        /// </summary>
        public string City { get => this._city; set => this._city = value; }

        /// <summary>
        ///  Gets or Sets Customer Name.
        /// </summary>
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>
        ///  Gets or Sets Customers Grade.
        /// </summary>
        public int Grade { get => this._grade; set => this._grade = value; }

        /// <summary>
        ///  Gets or Sets Customers reference to the Salesman (FK).
        /// </summary>
        public int SalesmanId { get => this._salesmanId; set => this._salesmanId = value; }
    }
}
