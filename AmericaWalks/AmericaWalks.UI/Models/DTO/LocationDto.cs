using System.Text.Json.Serialization;
using AmericaWalksApi.Models.Domain;

namespace AmericaWalks.UI.Models.DTO
{
    public class LocationDto
    {
        public Guid Id { get; set; }

        public string Code { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public WalksByState WalkLocation { get; set; }

        public string? LocationImageUrl { get; set; }
    }
}
