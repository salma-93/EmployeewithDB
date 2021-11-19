using Microsoft.EntityFrameworkCore;
using EmployeewithDB.Models;

namespace EmployeewithDB.Data{
    public class EmployeeContext : DbContext{
        public EmployeeContext(DbContextOptions<EmployeeContext> opt) : base(opt)
        {

        }

        public DbSet<Employee> Employees {get; set; }
    }   
}