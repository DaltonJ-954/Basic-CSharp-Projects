using AmericaWalksApi.Models.Domain;
using System.Text.Json.Serialization;

namespace AmericaWalksApi.Models.DTO
{
    public class UpdateLocationRequestDto
    {
        public string Code { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public WalksByState WalkLocation { get; set; }
        public string? LocationImageUrl { get; set; }
    }
}
