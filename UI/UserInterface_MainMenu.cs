using System.Net.NetworkInformation;
using System.Reflection.Metadata.Ecma335;

namespace GameShelf.UI
{
    public static partial class UserInterface
    {
        public static InterfaceSwitcher ShowMainMenu() {
            Console.Clear();
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Welcome to GameShelf");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1.Watch all the games\n2.Find your game\n3.Exit");
            Console.WriteLine("----------------------------------------------------------");
            string? chosenOption = Console.ReadLine();
            if (chosenOption == null)
            {
                Console.WriteLine("Sorry, but your request was incorrect, try again!");
                Console.ReadKey();
                return InterfaceSwitcher.MainMenu;
            }
            switch (chosenOption)

            {
                case "1":
                    return InterfaceSwitcher.AllTheGameMenu;
                case "2":
                    return InterfaceSwitcher.FindYourGameMenu;
                case "3":
                    return InterfaceSwitcher.Exit;
                default:
                    Console.WriteLine("Sorry, but your request was incorrect, try again!");
                    Console.ReadKey();
                    return InterfaceSwitcher.MainMenu;
            }


        }
    }
}
