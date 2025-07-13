using GameShelf.Configurations;
using GameShelf.Entities;
using Microsoft.EntityFrameworkCore;

public class GameshelfContext : DbContext
{
	public DbSet<GameEntity> Games { get; set; } = null!;
	public GameshelfContext(DbContextOptions<GameshelfContext> options) : base(options)
	{
	}


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new GameEntityConfiguration());
    }

}
