using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EmployeeModel.Models
{
    public class Employee
    {
        public Employee()
        {
            this.empCreated = DateTime.Now;
        }
        [Key]
        public int empId { get; set; }
        [Required]
        [Display(Name = "Developer Name")]
        public string empName { get; set; }
        [DataType(DataType.Date)]
        public DateTime empDoB { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime empCreated { get; set; }
        [Required]
        [DisplayName("Department")]
        public int deptId { get; set; }
        [ForeignKey("deptId")]
        public virtual Dept deptOfEmp { get; set; }
        [Timestamp]
        public Byte[] version { get; set; }
    }
}