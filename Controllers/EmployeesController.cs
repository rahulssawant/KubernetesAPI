using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssignmentEmpAPIKubernetes.Models;
using System.Net;
using Microsoft.AspNetCore.Cors;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AssignmentEmpAPIKubernetes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("K8sApi")]
    public class EmployeesController : ControllerBase
    {
        static readonly IEmployeeRepository repository = new EmployeeRepostory();
        // GET: api/<EmployeesController>
        [HttpGet]
        public IEnumerable<Employee> GetAllEmployees()
        {
            return repository.GetAll();
        }
        [HttpGet("{id}")]
        public Employee GetEmployee(int id)
        {
            Employee item = repository.Get(id);
            if (item == null)
            {
                throw new System.Web.Http.HttpResponseException(HttpStatusCode.NotFound);
            }
            return item;
        }
        [HttpPost]
        public string PostEmployee(Employee item)
        {
            item = repository.Add(item);
            return "added successfully";
        }
        [HttpPut("{id}")]
        public void PutEmployee(int id, Employee Employee)
        {
            Employee.Id = id;
            if (!repository.Update(Employee))
            {
                throw new System.Web.Http.HttpResponseException(HttpStatusCode.NotFound);
            }
        }
        [HttpDelete("{id}")]
        public void DeleteEmployee(int id)
        {
            Employee item = repository.Get(id);
            if (item == null)
            {
                throw new System.Web.Http.HttpResponseException(HttpStatusCode.NotFound);
            }
            repository.Remove(id);
        }
    }
}
