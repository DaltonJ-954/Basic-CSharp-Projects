using AmericaWalksApi.Models.Domain;
using System.Text.Json.Serialization;

namespace AmericaWalks.UI.Models
{
    public class AddLocationViewModel
    {
        public string Code { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public WalksByState WalkLocation { get; set; }

        public string? LocationImageUrl { get; set; }
    }
}