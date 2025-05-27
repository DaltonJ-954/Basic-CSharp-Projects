using AmericaWalksApi.Models.Domain;
using System.Text.Json.Serialization.Metadata;

namespace AmericaWalks.UI.Models
{
    public class AddLocationViewModel
    {
        public string Code { get; set; }
        public WalksByState WalkLocation { get; set; }
        public string? LocationImageUrl { get; set; }
    }
}
