using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Assignment5.Models
{
    public class Department
    {
        //to make identity
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public decimal Budget { get; set; }
        public int ManagerID { get; set; }

        //foreign key
        public virtual Employee Manager { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}