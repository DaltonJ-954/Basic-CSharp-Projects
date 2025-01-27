namespace AmericaWalksApi.Models.Domain
{
    public class Walk
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double LengthInMiles { get; set; }
        public string? LocationImageUrl { get; set; }
        public Guid DifficultyId { get; set; }
        public Guid LocationId { get; set; }


        // Navigation properties
        public Difficulty Difficulty { get; set; }
        public Location Location { get; set; }
    }
}
