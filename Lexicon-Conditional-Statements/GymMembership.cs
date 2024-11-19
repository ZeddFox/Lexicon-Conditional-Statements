using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_Conditional_Statements
{
    internal class GymMembership
    {
        public void Run()
        {
            int age = 0;
            bool wantPremium = false;

            Console.Clear();
            Console.WriteLine("How old are you?");
            Console.Write("Age: ");

            age = Convert.ToInt32(Console.ReadLine());

            bool invalidAnswerPremium = true;
            while (invalidAnswerPremium)
            {
                Console.Clear();
                Console.WriteLine("Do you want a premium membership or just regular?");
                Console.WriteLine("( 1 ) : Premium");
                Console.WriteLine("( 2 ) : Regular");

                ConsoleKey keyPressed = Console.ReadKey().Key;

                switch (keyPressed)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        wantPremium = true;

                        invalidAnswerPremium = false;
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        wantPremium = false;

                        invalidAnswerPremium = false;
                        break;
                }
            }

            // Print bought out membership
            Console.WriteLine("That will be " + buyMembership(age, wantPremium) + " CURRENCY, please.");

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }

        decimal buyMembership(int buyerAge, bool wantPremium)
        {
            decimal cost;
            if (buyerAge < 19 || buyerAge > 64)
            {
                cost = 2200M; 
            }
            else
            {
                cost = 3100M;
            }

            if (wantPremium)
            {
                return cost += 300;
            }
            else
            {
                return cost;
            }
        }
    }
}
