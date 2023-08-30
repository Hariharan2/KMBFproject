using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace KMBFproject.Models
{
    public class Employee
    {
        [Key] 
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string DOJ { get; set; }
        [Required]
        public string Designation { get; set; }
        [Required]
        public int Address { get; set; }
        [Required]
        public int Contact_Number { get; set; }
    }
}
