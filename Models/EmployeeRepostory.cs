using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentEmpAPIKubernetes.Models
{
    public class EmployeeRepostory : IEmployeeRepository
    {
        private static List<Employee> employees = new List<Employee>();
        private int _nextId = 1;

        public EmployeeRepostory()
        {
            Add(new Employee { EmpName = "Rahul Sawant", DOB = Convert.ToDateTime("1995-12-02"), Designation = "SSE", Salary = 5000 });
            Add(new Employee { EmpName = "Vaibhav Pawar", DOB = Convert.ToDateTime("1996-06-28"), Designation = "SSE", Salary = 4000 });
            Add(new Employee { EmpName = "Aman Singhai", DOB = Convert.ToDateTime("1998-02-25"), Designation = "SE", Salary = 3000 });
            Add(new Employee { EmpName = "Rabbani Pathan", DOB = Convert.ToDateTime("1998-08-10"), Designation = "TSE", Salary = 2000 });
        }
        public Employee Add(Employee item)
        {
            if (item == null)
            {
                throw new NotImplementedException("item");
            }
            item.Id = _nextId++;
            employees.Add(item);
            return item;
        }

        public Employee Get(int id)
        {
            return employees.Find(p => p.Id == id);
        }

        public IEnumerable<Employee> GetAll()
        {
            return employees;
        }

        public void Remove(int id)
        {
            employees.RemoveAll(p => p.Id == id);
        }

        public bool Update(Employee item)
        {
            if (item == null)
            {
                throw new NotImplementedException("item");
            }
            int index = employees.FindIndex(p => p.Id == item.Id);
            if (index == -1)
            {
                return false;
            }
            employees.RemoveAt(index);
            employees.Add(item);
            return true;
        }
    }
}
