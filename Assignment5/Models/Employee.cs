using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment5.Models
{
    public class Employee
    {
        //to make identity
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmployeeID { get; set; }
        public long SSN { get; set; }
        public decimal Salary { get; set; } 
        public long Phone { get; set; }
        public string Name { get; set; }
        public int DepartmentID { get; set; }

        //foreign keys
        public virtual Department EmployeeDepartment { get; set; }
        public virtual ICollection<Child> Children { get; set; }
    }
}