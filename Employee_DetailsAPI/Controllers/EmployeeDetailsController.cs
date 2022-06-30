
using Employee_DetailsAPI.EmployeeData;
using Employee_DetailsAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_DetailsAPI.Controllers
{
   
    [ApiController]
    public class EmployeeDetailsController : ControllerBase
    {
        private IEmployeeData _employeedata;
        public EmployeeDetailsController(IEmployeeData employeeData)
        {
            _employeedata = employeeData;
        }
        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetEmployees()
        {
            return Ok(_employeedata.GetEmployees());
        }

        [HttpGet]
        [Route("api/[controller]/{Empid}")]
        public IActionResult GetEmployee(Guid EmpId)
        {
            var employee = _employeedata.GetEmployee(EmpId);
            if (employee != null)
            {
                return Ok(employee);
            }
            return NotFound($"Employee With This ID:{EmpId} was Not Found");
        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult GetEmployee(Employee employee)
        {
            _employeedata.AddEmployee(employee);

            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host+ HttpContext.Request.Path+"/"+employee.EmpId,employee);
        }

        [HttpDelete]
        [Route("api/[controller]/{Empid}")]
        public IActionResult DeleteEmployee(Guid EmpId)
        {
            var employee = _employeedata.GetEmployee(EmpId);
            if (employee != null)
            {
                _employeedata.DeleteEmployee(employee);
                return Ok("Deleted Successfully");
            }
            return NotFound($"Employee With This ID:{EmpId} was Not Found");
        }

        [HttpPatch]
        [Route("api/[controller]/{Empid}")]
        public IActionResult EditEmployee(Guid EmpId, Employee employee)
        {
            var Existingemployee = _employeedata.GetEmployee(EmpId);
            if (Existingemployee != null)
            {
                employee.EmpId = Existingemployee.EmpId;
                _employeedata.EditEmployee(employee);
                return Ok(employee);
            }
            return NotFound($"Employee With This ID:{EmpId} was Not Found");
        }
    }
}
