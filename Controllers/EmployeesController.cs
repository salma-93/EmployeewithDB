
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using EmployeewithDB.Models;
using EmployeewithDB.Data;


namespace EmployeewithDB.Controllers
{
    [Route("api/employee")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeRepo _repository;

        public EmployeesController(IEmployeeRepo repository)
        {
            _repository = repository;
        }
       // private readonly MockEmployeeRepository _repository =new MockEmployeeRepository();
        [HttpGet]
        public ActionResult <IEnumerable<Employee>> GetAllEmployees(){

            var employees=_repository.GetAllEmployees();
            return Ok(employees);
        }

        [HttpGet("{id}")]
        public ActionResult <Employee> GetEmployeeById(int id){

            var employee = _repository.GetEmployeeById(id);
            return Ok(employee);

        }
    }
}