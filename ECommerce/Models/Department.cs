using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }

        [Required(ErrorMessage ="This field {0} is required")]
        [MaxLength(50, ErrorMessage ="The field {0} must be maximum {1} characters length")]
        [Display(Name = "Department")]
        public string Name { get; set; }

        public virtual ICollection<City> Cities{ get; set; }
    }
}