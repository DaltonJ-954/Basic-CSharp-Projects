using System.ComponentModel.DataAnnotations;

namespace PokemonReviewApp.Models
{
    public enum PokemonType
    {
        Normal,
        Fire,
        Water,
        Grass,
        Electric,
        Ice,
        Fighting,
        Poison,
        Ground,
        Flying,
        Psychic,
        Bug,
        Rock,
        Ghost,
        Dragon,
        Dark,
        Steel,
        Fairy
    }

    public class Pokemon
    {
        // Models with properties are tied to databases as columns
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime BirthDate { get; set; }
        public ICollection<Review> Reviews { get; set; } = null!;
        public ICollection<PokemonOwner> PokemonOwners { get; set; } = null!;
        public ICollection<PokemonCategory> PokemonCategories { get; set; } = null!;

    }
}
