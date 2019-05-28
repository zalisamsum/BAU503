using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class EmployeeController : ApiController
    {
        static List<Employee> Employees = new List<Employee>()
        {
            new Employee(){id=1,Name="Person1"},
            new Employee(){id=2,Name="Person2"},
            new Employee(){id=3,Name="Person3"},

        };
        public IEnumerable<Employee> Get()
        {
            return Employees;

        }
        public Employee Get(int id)
        {
            return Employees.FirstOrDefault(x => x.id == id);
        }
        [Route("api/employee/{id}/tasks")]
        public IEnumerable<string> GetEmployeeTask(int id)
        {
            switch (id)
            {
                case 1: return new List<string> { "Task1-1", "Task1-2", "Task1-3" };
                    
                case 2: return new List<string> { "Task1-1", "Task1-2", "Task1-3" };

                case 3: return new List<string> { "Task1-1", "Task1-2", "Task1-3" };

                default: return null;


            }
        }
    }
}
