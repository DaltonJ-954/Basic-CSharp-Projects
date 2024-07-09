namespace MonsterReviewApp.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string PlaceOfOrigin { get; set; }
        public ICollection<Creator> Creators { get; set;}
    }
}
