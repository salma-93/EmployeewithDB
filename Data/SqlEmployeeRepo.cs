using System.Collections.Generic;
using EmployeewithDB.Models;
using System.Linq;

namespace EmployeewithDB.Data{
    public class SqlEmployeeRepo : IEmployeeRepo{
        private readonly EmployeeContext _context;
        public SqlEmployeeRepo(EmployeeContext context)
        {
            _context =context;
        }
        public IEnumerable<Employee> GetAllEmployees(){

             return _context.Employees.ToList();
         }
          public  Employee GetEmployeeById(int id){

                return _context.Employees.FirstOrDefault(p => p.Id == id);
            }
    }
}