using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDeveloper.Model
{
    public partial class Products
    {
        [Key]
        public int ProductID { get; set; }

        [Display(Name = "Product Name")]
        [Required(ErrorMessage = "The Product Name is required")]
        [StringLength(40)]
        public string ProductName { get; set; }

        public int? SupplierID { get; set; }

        public int? CategoryID { get; set; }

        [Display(Name = "Quantity Price Unit")]
        [StringLength(20)]
        public string QuantityPerUnit { get; set; }

        [Display(Name = "Unit Price")]
        [Column(TypeName = "money")]
        [RegularExpression(@"^\d+.\d{0,2}$")]
        [Range(0, 9999999999999999.99)]
        public decimal? UnitPrice { get; set; }

        [Display(Name = "Units In Stock")]
        public short? UnitsInStock { get; set; }

        [Display(Name = "Units On Order")]
        public short? UnitsOnOrder { get; set; }

        [Display(Name = "Reorder Level")]
        public short? ReorderLevel { get; set; }

        public bool Discontinued { get; set; }

        public virtual Categories Categories { get; set; }
    }
}
