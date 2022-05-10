namespace ExamEAD.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ExamEAD.Data.EmployeeContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ExamEAD.Data.EmployeeContext context)
        {
            var employee = new List<Employee>{
                  new Employee{Id=1,Name = "Hoàng Kiên",Salary=500000,Deparment="78 Ngọc Hà"},
                  new Employee{Id=3,Name = "Sĩ Nguyên",Salary=500000,Deparment=" 103 Hà Đông"},
                  new Employee{Id=4,Name = "Minh Quang",Salary=500000,Deparment="85 Đê La Thành"}
              };
            employee.ForEach(s => context.Employees.Add(s));
            context.SaveChanges();
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
