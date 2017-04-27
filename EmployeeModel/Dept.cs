using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EmployeeModel.Models
{
    [Table("section")]
    public class Dept
    {
        [Key]
        [Column("sectionId")]
        public int deptId { get; set; }

        [Column("sectionName")]
        [Required, MaxLength(25, ErrorMessage="Department name must be 20 characters or less"),MinLength(5)]
        public string deptName { get; set; }

        public int branchId { get; set; }
    }
}