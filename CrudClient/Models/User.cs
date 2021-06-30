using System.ComponentModel.DataAnnotations;

namespace CrudClient.Models
{
    public class User
    {
        // Data annotations
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }
    }
}