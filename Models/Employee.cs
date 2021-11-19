using System.ComponentModel.DataAnnotations;
namespace EmployeewithDB.Models
{
    public class Employee{

 
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(250)]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Address { get; set; }

    }
}