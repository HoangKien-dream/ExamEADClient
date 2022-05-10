using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ExamEAD
{
    [DataContract]
    public class Employee
    {
        [Key]
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public double Salary { get; set; }
        [DataMember]
        public string Deparment { get; set; }
    }
}