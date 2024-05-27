using System.ComponentModel.DataAnnotations;

namespace eBookShop.Models.Domain
{
    public class Genre
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
    }
}
