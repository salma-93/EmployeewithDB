using System.Collections.Generic;
using EmployeewithDB.Models;
namespace EmployeewithDB.Data
{
    public interface IEmployeeRepo
    {
            IEnumerable<Employee> GetAllEmployees();
            Employee GetEmployeeById(int id);
    }
}