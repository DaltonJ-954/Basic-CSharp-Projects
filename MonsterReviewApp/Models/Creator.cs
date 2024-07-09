namespace MonsterReviewApp.Models
{
    public class Creator
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CreatorOrigin { get; set; }
        public Country Country { get; set; }
        public ICollection<MonsterCreator> MonsterCreators { get; set; }
    }
}