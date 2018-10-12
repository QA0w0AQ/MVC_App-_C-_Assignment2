using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment2.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public int StoreLocationId { get; set; }
        public virtual StoreLocation StoreLocation { get; set; }

        public virtual ICollection<Product> Products { get; set; }

        public int? EmployeeId { get; set; }
        public virtual ApplicationUser Employee { get; set; }

        public string SaleManId { get; set; }
        public virtual ApplicationUser SaleMan { get; set; }

    }
}