using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeModel.Models
{
    [Table("hod")]
    public class Manager
    {
        [Key]
        public int ManagerId { get; set; }
        [MaxLength(30), MinLength(5),Display(Name="HOD")]
        public string ManagerName { get; set; }
        public int deptId { get; set; }
        [ForeignKey("deptId")]
        public virtual Dept MyProperty { get; set; }
    }
}
