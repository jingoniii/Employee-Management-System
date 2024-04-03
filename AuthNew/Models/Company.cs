using System.ComponentModel.DataAnnotations;

namespace AuthNew.Models
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Address { get; set; }
        

    }
 
}