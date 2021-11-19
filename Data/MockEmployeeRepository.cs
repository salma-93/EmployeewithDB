using System.Collections.Generic;
using EmployeewithDB.Models;

namespace EmployeewithDB.Data{
    public class MockEmployeeRepository : IEmployeeRepo
    {
        public IEnumerable<Employee> GetAllEmployees(){

            var Employees =new List<Employee>
            {

                    new Employee{Id=0, Name="salma", Email="sumesalma" ,Address="losangels"},
                    new Employee{Id=1, Name="ayzaan", Email="ayzaan@gmail.com" ,Address="us"},
                    new Employee{Id=2, Name="yaqoob", Email="yaqoob@gmail.com" ,Address="losangels"},
                    new Employee{Id=3, Name="shafi", Email="shafi@deloitte.com" ,Address="nyk"}
            };
            return Employees;
        }

        public Employee GetEmployeeById(int id){

            return new Employee{Id=0, Name="salma", Email="sumesalma" ,Address="bangalore"};
        }
    }
}