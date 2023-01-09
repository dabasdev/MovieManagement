using Management.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Management.DataAccess.Context;

public class MovieManagementDbContext : DbContext
{
    public MovieManagementDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Actor> Actors { get; set; } = null!;
    public DbSet<Movie> Movies { get; set; } = null!;
    public DbSet<Biography> Biographies { get; set; } = null!;
    public DbSet<Genre> Genres { get; set; } = null!;


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Actor>().HasData(
            new Actor { Id = 1, FirstName = "Ahmed", LastName = "Dabas" },
            new Actor { Id = 2, FirstName = "Jane", LastName = "Doe" },
            new Actor { Id = 3, FirstName = "Van", LastName = "Damme" }
        );

        modelBuilder.Entity<Movie>().HasData(
            new Movie { Id = 1, Name = "Movie-1", Description = "Des.01", ActorId = 1 },
            new Movie { Id = 2, Name = "Movie-2", Description = "Des.02", ActorId = 2 },
            new Movie { Id = 3, Name = "Movie-3", Description = "Des.03", ActorId = 3 },
            new Movie { Id = 4, Name = "Movie-4", Description = "Des.04", ActorId = 2 }
        );
    }
}