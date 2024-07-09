namespace MonsterReviewApp.Models
{
    public class MonsterCategories
    {
        public int MonsterId { get; set; }
        public int CategoryId { get; set; }
        public Monster Monster { get; set; }
        public MonsterType MonsterType { get; set; }
    }
}
