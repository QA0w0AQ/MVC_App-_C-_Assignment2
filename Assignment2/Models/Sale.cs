using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment2.Models
{
    public class Sale
    {
        public Sale()
        {
            Products = new HashSet<Product>();
        }
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public int StoreLocationId { get; set; }
        public virtual StoreLocation StoreLocation { get; set; }

        public virtual ICollection<Product> Products { get; set; }

        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }

        public int? ApprovedSalesId { get; set; }
        public virtual Employee ApprovedSales { get; set; }

    }
}