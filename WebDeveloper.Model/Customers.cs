using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDeveloper.Model
{
    public partial class Customers
    {
        
        public Customers()
        {
            Orders = new HashSet<Orders>();
        }

        [Key]
        public int CustomerID { get; set; }

        [Required(ErrorMessage = "The Company Name is Required")]
        [Display(Name = "Company Name")]
        [StringLength(40, ErrorMessage = "The Max number characters is 40")]
        public string CompanyName { get; set; }

        [Display(Name = "Contact Name")]
        [StringLength(30, ErrorMessage = "The Max number characters is 30")]
        public string ContactName { get; set; }

        [Display(Name = "Contact Title")]
        [StringLength(30 , ErrorMessage = "The Max number characters is 30")]
        public string ContactTitle { get; set; }

       
        [StringLength(60, ErrorMessage = "The Max number characters is 60")]
        public string Address { get; set; }

        
        [StringLength(15, ErrorMessage = "The Max number characters is 15")]
        public string City { get; set; }

        
        [StringLength(15, ErrorMessage = "The Max number characters is 15")]
        public string Region { get; set; }

        [Display(Name = "Postal Code")]
        [StringLength(10 , ErrorMessage = "The Max number characters is 10")]
        public string PostalCode { get; set; }

        [StringLength(15 , ErrorMessage = "The Max number characters is 15")]
        public string Country { get; set; }

        [StringLength(24, ErrorMessage = "The Max number characters is 24")]
        public string Phone { get; set; }

        [StringLength(24, ErrorMessage = "The Max number characters is 24")]
        public string Fax { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}
