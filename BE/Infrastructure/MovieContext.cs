using Microsoft.EntityFrameworkCore;

namespace BE;

public class MovieContext : Microsoft.EntityFrameworkCore.DbContext
{
    public MovieContext(DbContextOptions<MovieContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<WatchlistDto>(x =>
        {
            x.HasKey(x => x.Id);
            x.HasMany(x => x.Movies).WithOne();
        });
    }

    public DbSet<WatchlistDto> Watchlists { get; set; }
    public DbSet<MovieDto> Movies { get; set; }
}