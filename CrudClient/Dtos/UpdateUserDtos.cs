using System.ComponentModel.DataAnnotations;

namespace CrudClient.Dtos
{
    public class UpdateUserDtos
    {
        [Required]
        [MinLength(3)]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }
    }
}