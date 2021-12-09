using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentEmpAPIKubernetes.Models
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();
        Employee Get(int id);
        Employee Add(Employee item);
        void Remove(int id);
        bool Update(Employee item);
    }
}
