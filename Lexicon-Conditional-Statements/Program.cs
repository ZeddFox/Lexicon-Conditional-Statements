using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Channels;

namespace Lexicon_Conditional_Statements
{
    class Program
    {
        static void Main()
        {
            bool invalidAnswer = true;
            while (invalidAnswer)
            {
                Console.Clear();
                Console.WriteLine("Which exercise would you like to run?");
                Console.WriteLine("( 1 ) : VAT");
                Console.WriteLine("( 2 ) : Gym membership");
                Console.WriteLine("( 3 ) : Calculator");
                Console.WriteLine("( 4 ) : Menu");
                Console.WriteLine("( ESC ) : Exit)");

                ConsoleKey keyPressed = Console.ReadKey().Key;

                switch (keyPressed)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        VAT vat = new VAT();
                        vat.Run();
                        break;

                    case ConsoleKey.D2:
                        Console.Clear();
                        GymMembership gymMembership = new GymMembership();
                        gymMembership.Run();
                        break;

                    case ConsoleKey.D3:
                        Console.Clear();
                        Calculator calculator = new Calculator();
                        calculator.Run();
                        break;

                    case ConsoleKey.D4:
                        Console.Clear();
                        Menu menu = new Menu();
                        menu.Run();
                        break;

                    case ConsoleKey.Escape:
                        Console.Clear();
                        invalidAnswer = false;
                        break;
                }
            }
        }
    }
}
