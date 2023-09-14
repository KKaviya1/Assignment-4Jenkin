using JenkinsAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JenkinsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
         
        static List<Employee> Employees = new List<Employee>
        {
            new Employee(){EmpId=1, EmpName="Viya",Destination="Manager"},
            new Employee(){EmpId=2, EmpName="Ravi",Destination="HR"},
            new Employee(){EmpId=3, EmpName="Prakash",Destination="Developer"},
         

        };
        [HttpGet]
        public ActionResult<IEnumerable<Employee>> Get()
        {
            return Ok(Employees);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Employee employee)
        {
            if (employee == null)
            {
                return BadRequest("Invalid Employee data.");
            }

            employee.EmpId = Employees.Max(e => e.EmpId) + 1; 
            Employees.Add(employee);

            return CreatedAtAction(nameof(Get), new { id = employee.EmpId }, employee);
        }
    }
}

