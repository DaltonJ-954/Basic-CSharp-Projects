﻿namespace MonsterReviewApp.Models
{
    public class MonsterType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<MonsterCategories> MonsterCategories { get; set; }

    }
}
