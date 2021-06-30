using System.ComponentModel.DataAnnotations;

namespace CrudClient.Dtos
{
    public class UserReadDtos
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}