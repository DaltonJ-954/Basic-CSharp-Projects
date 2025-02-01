using AmericaWalksApi.Models.Domain;

namespace AmericaWalksApi.Models.DTO
{
    public class AddLocationRequestDto
    {
        public string Code { get; set; }
        public WalksByState WalkLocation { get; set; }
        public string? LocationImageUrl { get; set; }
    }
}
