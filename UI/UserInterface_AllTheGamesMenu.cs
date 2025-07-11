using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameShelf.Entities;
using GameShelf.Repositories;

namespace GameShelf.UI
{
    public static partial class UserInterface
    {
        public static InterfaceSwitcher ShowAllTheGamesMenu(IEnumerable<GameEntity> entities) {
            Console.Clear();
            Console.WriteLine("----------------------------------------------------------");
            foreach(var game in entities ) {
                Console.WriteLine($" -{game.Name}\n{game.Genre} - {game.Price} - {game.Rating}");
                Console.WriteLine("----------------------------------------------------------");
            }
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1.Back to Main Menu\n2.Find your game\n3.Exit");
            Console.WriteLine("----------------------------------------------------------");
            string? chosenOption = Console.ReadLine();
            if (chosenOption == null)
            {
                Console.WriteLine("Sorry, but your request was incorrect, try again!");
                Console.ReadKey();
                return InterfaceSwitcher.AllTheGameMenu;
            }
            switch (chosenOption)

            {
                case "1":
                    return InterfaceSwitcher.MainMenu;
                case "2":
                    return InterfaceSwitcher.FindYourGameMenu;
                case "3":
                    return InterfaceSwitcher.Exit;
                default:
                    Console.WriteLine("Sorry, but your request was incorrect, try again!");
                    Console.ReadKey();
                    return InterfaceSwitcher.AllTheGameMenu;
            }
        }
    }
}
