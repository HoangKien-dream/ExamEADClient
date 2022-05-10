using ExamEAD.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ExamEAD
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        private EmployeeContext db = new EmployeeContext();

        public List<Employee> FindAll()
        {
            return db.Employees.ToList();
        }

        public List<Employee> FindByDeparment(string deparment)
        {
          var ListEmploy =  db.Employees.Where(s => s.Deparment == deparment).ToList();
           return ListEmploy;
           throw new NotImplementedException();
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public Employee Save(Employee employee)
        {
            if(employee == null)
            {
                return null;
            }
            db.Employees.Add(employee);
            db.SaveChanges();
            return employee;
            throw new NotImplementedException();
        }
    }
}
