using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Assignment5.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace Assignment5.DAL
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext() : base("EmployeeContext")
        {
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Child> Children { get; set; }
        public DbSet<Department> Departments { get; set; }

        //for pluralize singularize thing
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
