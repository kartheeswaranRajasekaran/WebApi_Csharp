using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_DetailsAPI.Models
{
    public class Employee
    {
        [Key]
        public Guid EmpId { get; set; }
        [Required]
        [MaxLength(50,ErrorMessage ="Name Should be within 50 Character")]
        public string EmpName { get; set; }
        [Required]
        [MinLength(10,ErrorMessage ="Phone Number Should Be 10 Numbers")]
        public string EmpPhone { get; set; }
        [Required]
        public string EmpEmail { get; set; }
        [Required]
        public DateTime DOB { get; set; }
        [Required]
        public string JobTitle { get; set; }
        [Required]
        public string Department { get; set; }
    }
}
