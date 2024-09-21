using System.ComponentModel.DataAnnotations;

namespace CRUD.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [DataType("varchar")]
        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = null!;

        [DataType(DataType.EmailAddress)]
        [Required]
        public string Email { get; set; } = null!;
        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; } = null!;
    }
}
