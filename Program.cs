using System.Net.NetworkInformation;
using GameShelf.Entities;
using GameShelf.Repositories;
using GameShelf.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;

var config = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json")
    .Build();

var connectionString = config.GetConnectionString("DefaultConnection");

var projectRoot = Directory.GetParent(AppContext.BaseDirectory)!
                   .Parent!.Parent!.Parent!.FullName;

connectionString = connectionString!.Replace("%PROJECT_PATH%", projectRoot);

var options = new DbContextOptionsBuilder<GameshelfContext>()
    .UseSqlite(connectionString)
    .Options;

var factory = new PooledDbContextFactory<GameshelfContext>(options);

var repository = new GameRepository(factory);

InterfaceSwitcher switcher = InterfaceSwitcher.MainMenu;

    while (switcher != InterfaceSwitcher.Exit)
    {
        switch (switcher) {

            case InterfaceSwitcher.MainMenu:
                switcher = UserInterface.ShowMainMenu();
                break;
            case InterfaceSwitcher.AllTheGameMenu:
                switcher = UserInterface.ShowAllTheGamesMenu(await repository.GetAllAsync());
                break;
            case InterfaceSwitcher.FindYourGameMenu:
                string gameName = UserInterface.AskGameName();
                var foundGames = await repository.GetByNameAsync(gameName);
                switcher = UserInterface.ShowFoundGames(foundGames ?? new List<GameEntity>());
                break;
        }




    }

    Console.WriteLine("See ya, bye!");







//modelBuilder.Entity<GameEntity>().HasData(
//        new GameEntity { Id = 1, Name = "Elden Ring", Description = "Vast open world action RPG with challenging combat.", Genre = "RPG", Rating = 4.9, Price = 59.99m },
//new GameEntity { Id = 2, Name = "Cyberpunk 2077", Description = "Futuristic open-world RPG in Night City.", Genre = "RPG", Rating = 4.2, Price = 49.99m },
//new GameEntity { Id = 3, Name = "The Witcher 3", Description = "Epic fantasy RPG with rich storytelling.", Genre = "RPG", Rating = 4.9, Price = 29.99m },
//new GameEntity { Id = 4, Name = "God of War Ragnarok", Description = "Action adventure in Norse mythology.", Genre = "Action", Rating = 4.8, Price = 69.99m },
//new GameEntity { Id = 5, Name = "Horizon Forbidden West", Description = "Open-world adventure with robotic creatures.", Genre = "Action", Rating = 4.6, Price = 59.99m },
//new GameEntity { Id = 6, Name = "Assassin’s Creed Valhalla", Description = "Viking saga with exploration and combat.", Genre = "Action", Rating = 4.3, Price = 39.99m },
//new GameEntity { Id = 7, Name = "Resident Evil Village", Description = "Horror survival in a mysterious European village.", Genre = "Horror", Rating = 4.4, Price = 34.99m },
//new GameEntity { Id = 8, Name = "Dead Space Remake", Description = "Sci-fi horror classic rebuilt with modern graphics.", Genre = "Horror", Rating = 4.7, Price = 59.99m },
//new GameEntity { Id = 9, Name = "Stardew Valley", Description = "Charming farming and life simulation.", Genre = "Simulation", Rating = 4.9, Price = 14.99m },
//new GameEntity { Id = 10, Name = "The Sims 4", Description = "Life simulation with character creation and storytelling.", Genre = "Simulation", Rating = 4.5, Price = 29.99m },
//new GameEntity { Id = 11, Name = "Cities: Skylines II", Description = "Build and manage realistic cities.", Genre = "Simulation", Rating = 4.3, Price = 49.99m },
//new GameEntity { Id = 12, Name = "Forza Horizon 5", Description = "Open-world racing in beautiful landscapes.", Genre = "Racing", Rating = 4.8, Price = 59.99m },
//new GameEntity { Id = 13, Name = "Gran Turismo 7", Description = "Realistic racing simulator with hundreds of cars.", Genre = "Racing", Rating = 4.4, Price = 69.99m },
//new GameEntity { Id = 14, Name = "Mario Kart 8 Deluxe", Description = "Fun arcade racing with beloved Nintendo characters.", Genre = "Racing", Rating = 4.9, Price = 59.99m },
//new GameEntity { Id = 15, Name = "Call of Duty: MW III", Description = "Modern military shooter with intense action.", Genre = "Shooter", Rating = 4.2, Price = 69.99m },
//new GameEntity { Id = 16, Name = "Apex Legends", Description = "Fast-paced battle royale shooter.", Genre = "Shooter", Rating = 4.4, Price = 0.00m },
//new GameEntity { Id = 17, Name = "Valorant", Description = "Tactical team-based shooter.", Genre = "Shooter", Rating = 4.5, Price = 0.00m },
//new GameEntity { Id = 18, Name = "League of Legends", Description = "Competitive MOBA with strategic gameplay.", Genre = "MOBA", Rating = 4.6, Price = 0.00m },
//new GameEntity { Id = 19, Name = "Dota 2", Description = "Classic multiplayer online battle arena.", Genre = "MOBA", Rating = 4.4, Price = 0.00m },
//new GameEntity { Id = 20, Name = "Minecraft", Description = "Sandbox building and survival adventure.", Genre = "Sandbox", Rating = 4.9, Price = 26.95m },
//new GameEntity { Id = 21, Name = "Terraria", Description = "2D sandbox exploration and crafting.", Genre = "Sandbox", Rating = 4.7, Price = 9.99m },
//new GameEntity { Id = 22, Name = "Baldur’s Gate 3", Description = "Deep RPG based on D&D rules.", Genre = "RPG", Rating = 4.9, Price = 59.99m },
//new GameEntity { Id = 23, Name = "Disco Elysium", Description = "Narrative-driven RPG with philosophical storytelling.", Genre = "RPG", Rating = 4.8, Price = 39.99m },
//new GameEntity { Id = 24, Name = "Animal Crossing: NH", Description = "Relaxing life sim with charming villagers.", Genre = "Simulation", Rating = 4.8, Price = 59.99m },
//new GameEntity { Id = 25, Name = "Super Mario Odyssey", Description = "3D platformer with inventive level design.", Genre = "Platformer", Rating = 4.9, Price = 59.99m },
//new GameEntity { Id = 26, Name = "Hollow Knight", Description = "Atmospheric 2D metroidvania with challenging combat.", Genre = "Platformer", Rating = 4.8, Price = 14.99m },
//new GameEntity { Id = 27, Name = "Celeste", Description = "Precision platformer with emotional narrative.", Genre = "Platformer", Rating = 4.7, Price = 19.99m },
//new GameEntity { Id = 28, Name = "Civilization VI", Description = "Turn-based strategy spanning human history.", Genre = "Strategy", Rating = 4.6, Price = 29.99m },
//new GameEntity { Id = 29, Name = "Total War: Warhammer III", Description = "Epic strategy battles in the Warhammer universe.", Genre = "Strategy", Rating = 4.5, Price = 59.99m },
//new GameEntity { Id = 30, Name = "Among Us", Description = "Social deduction party game.", Genre = "Party Game", Rating = 4.3, Price = 4.99m }

//    );