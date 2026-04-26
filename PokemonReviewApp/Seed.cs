using PokemonReviewApp.Data;
using PokemonReviewApp.Models;

namespace PokemonReviewApp
{
    public class Seed
    {
        private readonly PokemonDbContext dataContext;

        public Seed(PokemonDbContext context)
        {
            dataContext = context;
        }

        public void SeedDataContext()
        {
            if (dataContext.PokemonOwners.Any())
                return;

            // Create base data
            var categories = new List<Category>();
            var countries = new List<Country>();
            var owners = new List<Owner>();
            var reviewers = new List<Reviewer>();

            // 10 Categories
            for (int i = 1; i <= 10; i++)
            {
                categories.Add(new Category { Name = $"Category {i}" });
            }

            // 10 Countries
            for (int i = 1; i <= 10; i++)
            {
                countries.Add(new Country { Name = $"Region {i}" });
            }

            // 10 Owners
            for (int i = 1; i <= 10; i++)
            {
                owners.Add(new Owner
                {
                    FirstName = $"OwnerFirst{i}",
                    LastName = $"OwnerLast{i}",
                    Gym = $"Gym {i}",
                    Country = countries[i - 1]
                });
            }

            // 10 Reviewers
            for (int i = 1; i <= 10; i++)
            {
                reviewers.Add(new Reviewer
                {
                    FirstName = $"ReviewerFirst{i}",
                    LastName = $"ReviewerLast{i}"
                });
            }

            var pokemonOwners = new List<PokemonOwner>();

            // 10 Pokémon
            for (int i = 1; i <= 10; i++)
            {
                var pokemon = new Pokemon
                {
                    Name = $"Pokemon {i}",
                    BirthDate = new DateTime(2000 + i, 1, 1),

                    PokemonCategories = new List<PokemonCategory>
                    {
                        new PokemonCategory
                        {
                            Category = categories[i - 1]
                        }
                    },

                    Reviews = new List<Review>()
                };

                // 3 Reviews per Pokémon
                for (int j = 0; j < 3; j++)
                {
                    pokemon.Reviews.Add(new Review
                    {
                        Title = $"Pokemon {i} Review {j + 1}",
                        Text = $"This is review {j + 1} for Pokemon {i}",
                        Rating = (j % 5) + 1,
                        Reviewer = reviewers[(i + j) % reviewers.Count]
                    });
                }

                pokemonOwners.Add(new PokemonOwner
                {
                    Pokemon = pokemon,
                    Owner = owners[i - 1]
                });
            }

            dataContext.PokemonOwners.AddRange(pokemonOwners);
            dataContext.SaveChanges();
        }
    }
}