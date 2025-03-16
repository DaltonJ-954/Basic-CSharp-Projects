using AmericaWalksApi.Models.Domain;
using System.ComponentModel.DataAnnotations;

namespace AmericaWalksApi.Models.DTO
{
    public class UpdateLocationRequestDto
    {
        [Required]
        [MinLength(2, ErrorMessage = "Code has to be a minimum of 2 characters")]
        [MaxLength(3, ErrorMessage = "Code has to be a maximum of 3 characters")]
        public string Code { get; set; }
        [Required]
        public WalksByState WalkLocation { get; set; }
        public string? LocationImageUrl { get; set; }
    }
}
