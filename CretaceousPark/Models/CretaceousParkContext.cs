using Microsoft.EntityFrameworkCore;

namespace CretaceousPark.Models
{
    public class CretaceousParkContext : DbContext
    {
      public CretaceousParkContext(DbContextOptions<CretaceousParkContext> options)
          : base(options)
      {
      }

      public DbSet<Animal> Animals { get; set; }
      protected override void OnModelCreating(ModelBuilder builder)
      {
        builder.Entity<Animal>()
        .HasData(
          new Animal { AnimalId = 1, Name = "Matilda", Species = "Wooly Mammoth", Age = 7, Sex = "Female"},
          new Animal { AnimalId = 2, Name = "Rexie", Species = "Dinosaur", Age = 10, Sex = "Female"},
          new Animal { AnimalId = 3, Name = "Matilda", Species = "Dinosaur", Age = 2, Sex = "Female"},
          new Animal { AnimalId = 4, Name = "Pip", Species = "Shark", Age = 4, Sex = "Male"},
          new Animal { AnimalId = 5, Name = "Bartholomew", Species = "Dinosaur", Age = 22, Sex = "Male"}
        );
      }
    }
}