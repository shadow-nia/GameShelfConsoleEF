using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameShelf.Entities;

namespace GameShelf.UI
{
    public static partial class UserInterface
    {
        public static string AskGameName()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------------------------");
            Console.Write("Please, write the game's name what you are looking for: ");
            return Console.ReadLine() ?? "";
        }


        public static InterfaceSwitcher ShowFoundGames(GameEntity game)
        {

            if(game.Id is 0)
            {
                Console.WriteLine("Sorry, but we can't find any game on your request.");
                Console.WriteLine("Try another game");
                Console.ReadKey();
                return InterfaceSwitcher.FindYourGameMenu;
            }
            else { 


                    Console.WriteLine($" -{game.Name}\n{game.Genre} - {game.Price} - {game.Rating}");
                    Console.WriteLine("----------------------------------------------------------");
                
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1.Back to Main Menu\n2.Watch all the games\n3.Exit");
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
                    return InterfaceSwitcher.AllTheGameMenu;
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
}