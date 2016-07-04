using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDeveloper.Model
{
    public partial class Categories
    {
        
        public Categories()
        {
            Products = new HashSet<Products>();
        }

        [Key]
        public int CategoryID { get; set; }

        [Required(ErrorMessage = "The Category Name is Required")]
        [Display(Name = "Category Name")]
        [StringLength(15, ErrorMessage = "The Max number characters is 15")]
        public string CategoryName { get; set; }

        [Display(Name = "Description")]
        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        [Display(Name = "Picture")]
        [Column(TypeName = "image")]
        public byte[] Picture { get; set; }

        [ScaffoldColumn(false)]
        [MaxLength(50)]
        public string PictureFileName { get; set; }

        [ScaffoldColumn(false)]
        [MaxLength(50)]
        public string PictureContentType { get; set; }

        public virtual ICollection<Products> Products { get; set; }
    }
}
