using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDeveloper.Model
{

    public partial class Orders
    {
        [Key]
        public int OrderID { get; set; }

        [StringLength(5)]
        public string CustomerID { get; set; }

        public int? EmployeeID { get; set; }

        [Display(Name = "Order Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime? OrderDate { get; set; }

        [Display(Name = "Required Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime? RequiredDate { get; set; }

        [Display(Name = "Shipped Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime? ShippedDate { get; set; }

        [Display(Name = "Ship Via")]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid integer Number")]
        public int? ShipVia { get; set; }

        [Display(Name = "Freight")]
        [Column(TypeName = "money")]
        [RegularExpression(@"^\d+.\d{0,2}$")]
        [Range(0, 9999999999999999.99)]
        public decimal? Freight { get; set; }

        [Display(Name = "Ship Name")]
        [StringLength(40)]
        public string ShipName { get; set; }

        [Display(Name = "Ship Address")]
        [StringLength(60)]
        public string ShipAddress { get; set; }

        [Display(Name = "Ship City")]
        [StringLength(15)]
        public string ShipCity { get; set; }

        [Display(Name = "Ship Region")]
        [StringLength(15)]
        public string ShipRegion { get; set; }

        [Display(Name = "Ship Postal Code")]
        [StringLength(10)]
        public string ShipPostalCode { get; set; }

        [Display(Name = "Ship Country")]
        [StringLength(15)]
        public string ShipCountry { get; set; }

        public virtual Customers Customers { get; set; }

        public virtual Employees Employees { get; set; }
    }
}
