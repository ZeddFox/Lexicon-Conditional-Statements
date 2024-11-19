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
                    Console.WriteLine("Press any key to return to menu.");
                    break;

                case "add":
                    Console.WriteLine("You selected: " + selection + ". I am not programmed to handle this command");
                    Console.WriteLine("Press any key to return to menu.");
                    break;

                case "delete":
                    Console.WriteLine("You selected: " + selection + ". I am not programmed to handle this command");
                    Console.WriteLine("Press any key to return to menu.");
                    break;

                case "edit":
                    Console.WriteLine("You selected: " + selection + ". I am not programmed to handle this command");
                    Console.WriteLine("Press any key to return to menu.");
                    break;

                case "find":
                    Console.WriteLine("You selected: " + selection + ". I am not programmed to handle this command");
                    Console.WriteLine("Press any key to return to menu.");
                    break;

                case "list":
                    Console.WriteLine("You selected: " + selection + ". I am not programmed to handle this command");
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
