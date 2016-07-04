using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDeveloper.Model
{

    public partial class Employees
    {

        public Employees()
        {
            Employees1 = new HashSet<Employees>();
            Orders = new HashSet<Orders>();
        }

        [Key]
        public int EmployeeID { get; set; }

        [Required(ErrorMessage = "The Last Name is required")]
        [StringLength(20, ErrorMessage = "The Max number characters is 20")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "The First Name is required")]
        [StringLength(10, ErrorMessage = "The Max number characters is 10")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [StringLength(30, ErrorMessage = "The Max number characters is 30")]
        public string Title { get; set; }

        [StringLength(25, ErrorMessage = "The Max number characters is 25")]
        [Display(Name = "Title Of Courtesy")]
        public string TitleOfCourtesy { get; set; }

        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime? BirthDate { get; set; }

        [Display(Name = "Hire Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime? HireDate { get; set; }

        [StringLength(60, ErrorMessage = "The Max number characters is 30")]
        public string Address { get; set; }

        [StringLength(15, ErrorMessage = "The Max number characters is 15")]
        public string City { get; set; }

        [StringLength(15, ErrorMessage = "The Max number characters is 15")]
        public string Region { get; set; }

        [StringLength(10, ErrorMessage = "The Max number characters is 10")]
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }

        [StringLength(15, ErrorMessage = "The Max number characters is 15")]
        public string Country { get; set; }

        [StringLength(24, ErrorMessage = "The Max number characters is 24")]
        [Display(Name = "Home Phone")]
        public string HomePhone { get; set; }

        [StringLength(4, ErrorMessage = "The Max number characters is 4")]
        public string Extension { get; set; }

        [Column(TypeName = "image")]
        public byte[] Photo { get; set; }

        [Column(TypeName = "ntext")]
        public string Notes { get; set; }

        [Display(Name = "Reports To")]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid integer Number")]
        public int? ReportsTo { get; set; }

        [StringLength(255)]
        [Display(Name = "Photo Path")]
        public string PhotoPath { get; set; }

        
        public virtual ICollection<Employees> Employees1 { get; set; }

        public virtual Employees Employees2 { get; set; }

        
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
