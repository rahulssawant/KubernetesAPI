using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentEmpAPIKubernetes.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string EmpName { get; set; }
        public DateTime? DOB { get; set; }
        public string Designation { get; set; }
        public double Salary { get; set; }
    }
}
