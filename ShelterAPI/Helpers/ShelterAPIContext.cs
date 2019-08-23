using Microsoft.EntityFrameworkCore;
using ShelterAPI.Models;

namespace ShelterAPI.Helpers
{
    public class ShelterAPIContext : DbContext
    {


        public DbSet<Breed> Breeds { get; set; }
        public DbSet<Animal> Animals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
                .UseMySql(@"server=localhost;user id=root;password=epicodus;port=3306;database=animal_shelter;");

        public ShelterAPIContext(DbContextOptions options) : base(options)
        {

        }
        public ShelterAPIContext()
        {

        }

    }
}