using System.ComponentModel.DataAnnotations;

namespace AuthNew.Models
{
    public class Employee
    {
        [Key]
        [Required]
        public int EmployeeId { get; set; }
        
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        [DataType(DataType.Date)]
        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public string PhoneNumber { get; set;}

        public int? PositionID { get; set; }
        public Position? Position { get; set; }

        public int? CompanyId { get; set; }
        public Company? Company { get; set; }

    }
}
