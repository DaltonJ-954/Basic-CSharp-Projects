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
        public WalkDifficulty Challenge { get; set; }
    }
}
