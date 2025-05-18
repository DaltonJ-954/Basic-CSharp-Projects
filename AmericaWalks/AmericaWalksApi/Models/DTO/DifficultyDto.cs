using System.Text.Json.Serialization;

namespace AmericaWalksApi.Models.DTO
{
    public enum WalkDifficulty
    {
        Easy,
        Moderate,
        Hard
    }
    
    
    public class DifficultyDto
    {
        public Guid Id { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public WalkDifficulty Challenge { get; set; }
    }
}
