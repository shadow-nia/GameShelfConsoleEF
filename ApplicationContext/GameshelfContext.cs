using GameShelf.Configurations;
using GameShelf.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

public class GameshelfContext : DbContext
{
	public DbSet<GameEntity> Games { get; set; } = null!;
	public GameshelfContext()
	{
	}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        var connectionString = config.GetConnectionString("DefaultConnection");
        var projectRoot = Directory.GetParent(AppContext.BaseDirectory)!
                           .Parent!.Parent!.Parent!.FullName;

        connectionString = connectionString!.Replace("%PROJECT_PATH%", projectRoot);

        optionsBuilder.UseSqlite(connectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new GameEntityConfiguration());
    }

}
