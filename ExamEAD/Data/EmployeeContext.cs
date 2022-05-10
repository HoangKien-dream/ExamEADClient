using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ExamEAD.Data
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext() : base ("name=EmployeeDB")
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}