using AmericaWalksApi.Models.Domain;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace AmericaWalksApi.Models.DTO
{
    public class AddLocationRequestDto
    {
        [Required]
        [MinLength(2, ErrorMessage = "Code has to be a minimum of 2 characters")]
        [MaxLength(3, ErrorMessage = "Code has to be a maximum of 3 characters")]
        public string Code { get; set; }

        [Required]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public WalksByState WalkLocation { get; set; }

        public string? LocationImageUrl { get; set; }
    }
}