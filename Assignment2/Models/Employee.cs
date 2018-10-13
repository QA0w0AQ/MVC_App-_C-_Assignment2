using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Assignment2.Models
{
    public class Employee
    {
        public Employee()
        {
            Sales = new HashSet<Sale>();
            ApprovedSale = new HashSet<Sale>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int RegistrationNumber { get; set; }

        [InverseProperty("Employee")]
        public virtual ICollection<Sale> Sales { get; set; }

        [InverseProperty("ApprovedSales")]
        public virtual ICollection<Sale> ApprovedSale { get; set; }
    }
}