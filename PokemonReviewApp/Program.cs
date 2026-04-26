using Microsoft.EntityFrameworkCore;
using PokemonReviewApp.Data;

namespace PokemonReviewApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // -----------------------
            // Services
            // -----------------------
            builder.Services.AddControllers();

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<PokemonDbContext>(options =>
                options.UseSqlServer(
                    builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddTransient<Seed>();

            var app = builder.Build();

            // -----------------------
            // Seed Data (IMPORTANT)
            // -----------------------
            if (args.Length == 1 && args[0].ToLower() == "seeddata")
            {
                SeedData(app);
            }

            // -----------------------
            // Middleware
            // -----------------------
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }

        // -----------------------
        // Seed Method
        // -----------------------
        private static void SeedData(IHost app)
        {
            using var scope = app.Services.CreateScope();
            var services = scope.ServiceProvider;

            var seed = services.GetRequiredService<Seed>();
            seed.SeedDataContext();
        }
    }
}