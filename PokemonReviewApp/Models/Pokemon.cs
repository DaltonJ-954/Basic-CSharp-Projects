namespace PokemonReviewApp.Models
{
    //public enum PokemonType
    //{
    //    Normal,
    //    Fire,
    //    Water,
    //    Grass,
    //    Electric,
    //    Ice,
    //    Fighting,
    //    Poison,
    //    Ground,
    //    Flying,
    //    Psychic,
    //    Bug,
    //    Rock,
    //    Ghost,
    //    Dragon,
    //    Dark,
    //    Steel,
    //    Fairy
    //}

    public class Pokemon
    {
        // Models with properties are tied to databases as columns
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<PokemonOwner> PokemonOwners { get; set; }
        public ICollection<PokemonCategory> PokemonCategories { get; set; }

    }
}
