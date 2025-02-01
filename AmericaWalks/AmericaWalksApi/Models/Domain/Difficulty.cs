using System.Text.Json.Serialization;

namespace AmericaWalksApi.Models.Domain
{
    public enum WalkDifficulty
    {
        Easy,
        Moderate,
        Hard
    }

    public class Difficulty
    {
        public Guid Id { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public WalkDifficulty Challenge { get; set; }
    }
}
