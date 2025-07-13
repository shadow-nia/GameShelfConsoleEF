using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

public class GameshelfContextFactory : IDesignTimeDbContextFactory<GameshelfContext>
{
    public GameshelfContext CreateDbContext(string[] args)
    {
        var config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        var connectionString = config.GetConnectionString("DefaultConnection");

        var projectRoot = Directory.GetParent(AppContext.BaseDirectory)!
                                   .Parent!.Parent!.Parent!.FullName;

        connectionString = connectionString!.Replace("%PROJECT_PATH%", projectRoot);

        var optionsBuilder = new DbContextOptionsBuilder<GameshelfContext>();
        optionsBuilder.UseSqlite(connectionString);

        return new GameshelfContext(optionsBuilder.Options);
    }
}
