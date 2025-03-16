using System.ComponentModel.DataAnnotations;

namespace AmericaWalksApi.Models.DTO
{
    public class WalkDto
    {
        [Required]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double LengthInMiles { get; set; }
        public string? LocationImageUrl { get; set; }

        public LocationDto Location { get; set; }
        public DifficultyDto Difficulty { get; set; }
    }
}
