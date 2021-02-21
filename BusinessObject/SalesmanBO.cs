// ----------------------------------------------------------------------
// <copyright file="Salesman.cs" company="companyName">
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
    /// This is Salesman Business Object.
    /// </summary>
    public class SalesmanBO
    {
        private int _id;
        private string _name;
        private string _city;
        private decimal _commission;

        /// <summary>
        /// Gets or Sets id of Salesman.
        /// </summary>
        public int Id
        {
            get
            {
                return this._id;
            }

            set
            {
                this._id = value;
            }
        }

        /// <summary>
        /// Gets or Sets id of Salesman.
        /// </summary>
        public string Name
        {
            get
            {
                return this._name;
            }

            set
            {
                this._name = value;
            }
        }

        /// <summary>
        /// Gets or Sets id of Salesman.
        /// </summary>
        public string City
        {
            get
            {
                return this._city;
            }

            set
            {
                this._city = value;
            }
        }

        /// <summary>
        /// Gets or Sets id of Salesman.
        /// </summary>
        public decimal Commission
        {
            get
            {
                return this._commission;
            }

            set
            {
                this._commission = value;
            }
        }
    }
}
