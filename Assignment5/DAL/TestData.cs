using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Assignment5.Models;

namespace Assignment5.DAL
{
    public class TestData : DropCreateDatabaseIfModelChanges<EmployeeContext>
    {
        protected override void Seed(EmployeeContext context)
        {
            //employee data
            var employees = new List<Employee> 
            {
                new Employee() { SSN = 123456789, Phone = 03120002980, Salary = 150000, Name = "A" , DepartmentID = 1},
                new Employee() { SSN = 987654321, Phone = 03025100080, Salary = 100000, Name = "B" , DepartmentID = 2},
                new Employee() { SSN = 121212121, Phone = 03325154980, Salary = 090000, Name = "C" , DepartmentID = 1},
                new Employee() { SSN = 343434343, Phone = 03289999980, Salary = 095000, Name = "D", DepartmentID = 2 }
            };
            foreach (Employee employee in employees)
            {
                context.Employees.Add(employee);
            }
            context.SaveChanges();

            //department data
            var departments = new List<Department> 
            {
                new Department() { DepartmentName = "CS", ManagerID = 1, Budget = 150000000 },
                new Department() { DepartmentName = "EE", ManagerID = 4, Budget = 135000000 }
            };
            foreach (Department department in departments)
            {
                context.Departments.Add(department);
            }
            context.SaveChanges();

            //children data
            var children = new List<Child>
            {
                new Child() { Name = "AA", Age = 10, ParentID = 1 }
            };
            foreach (Child child in children)
            {
                context.Children.Add(child);
            }
            context.SaveChanges();
        }
    }
}