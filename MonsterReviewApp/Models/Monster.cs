namespace MonsterReviewApp.Models
{
    public class Monster
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Incarnation { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<MonsterCreator> MonsterCreators { get; set; }
        public ICollection<MonsterCategories> MonsterCategories { get; set; }
    }
}