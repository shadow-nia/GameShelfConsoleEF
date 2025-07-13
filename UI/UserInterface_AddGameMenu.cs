using GameShelf.Models;

namespace GameShelf.UI
{
    public static partial class UserInterface
    {
        public static (InterfaceSwitcher Next, GameDto Data) ShowAddGameMenu()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Example:");
            Console.WriteLine("Name = \"Elden Ring\"");
            Console.WriteLine("Description = \"Vast open world action RPG with challenging combat.\"");
            Console.WriteLine("Genre = \"RPG\"");
            Console.WriteLine("Rating = 4.9");
            Console.WriteLine("Price = 59.99");
            Console.WriteLine("----------------------------------------------------------");

            var dto = new GameDto();

            Console.Write("Please write game's name : ");
            dto.Name = Console.ReadLine() ?? "No name";

            Console.Write("Please write game's Description : ");
            dto.Description = Console.ReadLine() ?? "No description";

            Console.Write("Please write game's Genre : ");
            dto.Genre = Console.ReadLine() ?? "Unknown";

            Console.Write("Please write game's Rating : ");
            dto.Rating = double.TryParse(Console.ReadLine(), out var rating) ? rating : 1.0;

            Console.Write("Please write game's Price : ");
            dto.Price = decimal.TryParse(Console.ReadLine(), out var price) ? price : 1.0m;

            return (InterfaceSwitcher.MainMenu, dto);
        }
    }
}
