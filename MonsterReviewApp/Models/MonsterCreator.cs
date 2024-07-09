namespace MonsterReviewApp.Models
{
    public class MonsterCreator
    {
        public int MonsterId { get; set; }
        public int CreatorId { get; set; }
        public Monster Monster { get; set; }
        public Creator Creator { get; set; }
    }
}
