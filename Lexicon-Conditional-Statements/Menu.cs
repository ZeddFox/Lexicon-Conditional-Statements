using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_Conditional_Statements
{
    internal class Menu
    {
        public bool repeat = true;
        public void Run()
        {
            while (repeat)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the menu.");
                Console.WriteLine("Your alternatives are: help, add, delete, edit, find, list, exit");

                string inputString = Convert.ToString(Console.ReadLine().ToLower());

                Console.Clear();
                MenuSelect(inputString);

                Console.ReadKey();
            }
        }

        void MenuSelect(string selection)
        {
            switch (selection)
            {
                case "help":
                    Console.WriteLine("You selected: " + selection + ". I am not programmed to handle this command");
                    Console.WriteLine("I am however forced to give you a unique message for every command.");
                    Console.WriteLine("Don't panic! I'm here to help, though I'm about as useful as a chocolate teapot right now. Have you tried turning it off and on again?");
                    Console.WriteLine("Press any key to return to menu.");
                    break;

                case "add":
                    Console.WriteLine("You selected: " + selection + ". I am not programmed to handle this command");
                    Console.WriteLine("I am however forced to give you a unique message for every command.");
                    Console.WriteLine("Mission accomplished! But remember, just like adding hot sauce, there's no undo button. Hope you meant to do that!");
                    Console.WriteLine("Press any key to return to menu.");
                    break;

                case "delete":
                    Console.WriteLine("You selected: " + selection + ". I am not programmed to handle this command");
                    Console.WriteLine("I am however forced to give you a unique message for every command.");
                    Console.WriteLine("Usage: delete <filepath>");
                    Console.WriteLine("Removes a file permanently from everyones memory, not just this computers.");
                    Console.WriteLine("Press any key to return to menu.");
                    break;

                case "edit":
                    Console.WriteLine("You selected: " + selection + ". I am not programmed to handle this command");
                    Console.WriteLine("I am however forced to give you a unique message for every command.");
                    Console.WriteLine("You do not have permission to edit anything, at all.");
                    Console.WriteLine("Press any key to return to menu.");
                    break;

                case "find":
                    Console.WriteLine("You selected: " + selection + ". I am not programmed to handle this command");
                    Console.WriteLine("I am however forced to give you a unique message for every command.");
                    Console.WriteLine("No results found. Have you checked under the couch? That's where I usually find my missing socks and TV remote.");
                    Console.WriteLine("Press any key to return to menu.");
                    break;

                case "list":
                    Console.WriteLine("You selected: " + selection + ". I am not programmed to handle this command");
                    Console.WriteLine("I am however forced to give you a unique message for every command.");
                    Console.WriteLine("Here is a list of animals: dog, cat, elephant, giraffe, penguin, lion, zebra, kangaroo, dolphin, tiger");
                    Console.WriteLine("Press any key to return to menu.");
                    break;

                case "exit":
                    Console.WriteLine("You selected: " + selection + ". I am actually programmed to handle this command.");
                    Console.WriteLine("Press any key to exit.");
                    repeat = false;
                    break;

                default:
                    Console.WriteLine("Command not recognized, press any key try again.");
                    break;
            }
        }
    }
}
