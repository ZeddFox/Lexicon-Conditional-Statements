using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_Conditional_Statements
{
    internal class VAT
    {
        const decimal musicVAT = 1.06M;
        const decimal foodVAT = 1.12M;
        const decimal alcoholVAT = 1.25M;

        // Music Entertainment item costs
        decimal musicDisc = 49.99M;
        decimal headphones = 399.99M;
        decimal cdPlayer = 899.99M;

        // Food item costs
        decimal hamburger = 59.99M;
        decimal pizza = 99.99M;
        decimal soda = 19.99M;

        // Alcohol item costs
        decimal beer = 39.99M;
        decimal wine = 79.99M;
        decimal cider = 49.99M;

        public void Run()
        {
            string itemCategory = "";
            string itemType = "";
            decimal itemCost = 0M;
            int itemCount = 0;
            #region Select Item Type
            bool selectInvalidCategory = true;
            while (selectInvalidCategory)
            {
                Console.Clear();
                Console.WriteLine("Select a product category to buy from:");
                Console.WriteLine("( 1 ) : Music Entertainment");
                Console.WriteLine("( 2 ) : Food");
                Console.WriteLine("( 3 ) : Alcohol");

                ConsoleKey keypressed = Console.ReadKey().Key;

                switch (keypressed)
                {
                    case ConsoleKey.D1:

                        itemCategory = "Music Entertainment";

                        selectInvalidCategory = false;
                        break;
                    case ConsoleKey.D2:

                        itemCategory = "Food";

                        selectInvalidCategory = false;
                        break;
                    case ConsoleKey.D3:

                        itemCategory = "Alcohol";

                        selectInvalidCategory = false;
                        break;
                }
            }
            #endregion

            #region Select Item
            switch (itemCategory)
            {
                case "Music Entertainment":
                    #region Music Entertainment
                    bool selectInvalidTypeMusic = true;
                    while (selectInvalidTypeMusic)
                    {
                        Console.Clear();
                        Console.WriteLine("Select a product to buy:");
                        Console.WriteLine("( 1 ) : Music Disc");
                        Console.WriteLine("( 2 ) : Headphones");
                        Console.WriteLine("( 3 ) : CD Player");

                        ConsoleKey keypressed = Console.ReadKey().Key;

                        switch (keypressed)
                        {
                            case ConsoleKey.D1:

                                itemType = "Music Disc";
                                itemCost = musicDisc;

                                selectInvalidTypeMusic = false;
                                break;
                            case ConsoleKey.D2:

                                itemType = "Headphones";
                                itemCost = headphones;

                                selectInvalidTypeMusic = false;
                                break;
                            case ConsoleKey.D3:

                                itemType = "CD Player";
                                itemCost = cdPlayer;

                                selectInvalidTypeMusic = false;
                                break;
                        }
                    }
                    #endregion
                    break;
                case "Food":
                    #region Food
                    bool selectInvalidTypeFood = true;
                    while (selectInvalidTypeFood)
                    {
                        Console.Clear();
                        Console.WriteLine("Select a product to buy:");
                        Console.WriteLine("( 1 ) : Hamburger");
                        Console.WriteLine("( 2 ) : Pizza");
                        Console.WriteLine("( 3 ) : Soda");

                        ConsoleKey keypressed = Console.ReadKey().Key;

                        switch (keypressed)
                        {
                            case ConsoleKey.D1:

                                itemType = "Hamburger";
                                itemCost = hamburger;

                                selectInvalidTypeFood = false;
                                break;
                            case ConsoleKey.D2:

                                itemType = "Pizza";
                                itemCost = pizza;

                                selectInvalidTypeFood = false;
                                break;
                            case ConsoleKey.D3:

                                itemType = "Soda";
                                itemCost = soda;

                                selectInvalidTypeFood = false;
                                break;
                        }
                    }
                    #endregion
                    break;
                case "Alcohol":
                    #region Alcohol
                    bool selectInvalidTypeAlcohol = true;
                    while (selectInvalidTypeAlcohol)
                    {
                        Console.Clear();
                        Console.WriteLine("Select a product to buy:");
                        Console.WriteLine("( 1 ) : Beer");
                        Console.WriteLine("( 2 ) : Wine");
                        Console.WriteLine("( 3 ) : Cider");

                        ConsoleKey keypressed = Console.ReadKey().Key;

                        switch (keypressed)
                        {
                            case ConsoleKey.D1:

                                itemType = "Beer";
                                itemCost = beer;

                                selectInvalidTypeAlcohol = false;
                                break;
                            case ConsoleKey.D2:

                                itemType = "Wine";
                                itemCost = wine;

                                selectInvalidTypeAlcohol = false;
                                break;
                            case ConsoleKey.D3:

                                itemType = "Cider";
                                itemCost = cider;

                                selectInvalidTypeAlcohol = false;
                                break;
                        }
                    }
                    #endregion
                    break;
            }
            #endregion

            #region Select Amount
            bool selectInvalidAmount = true;
            while (selectInvalidAmount)
            {
                Console.Clear();
                Console.WriteLine("How many would you like to buy? ( 1 - 9 )");

                ConsoleKey keypressed = Console.ReadKey().Key;

                switch (keypressed)
                {
                    case ConsoleKey.D1:

                        itemCount = 1;

                        selectInvalidAmount = false;
                        break;
                    case ConsoleKey.D2:

                        itemCount = 2;

                        selectInvalidAmount = false;
                        break;
                    case ConsoleKey.D3:

                        itemCount = 3;

                        selectInvalidAmount = false;
                        break;
                    case ConsoleKey.D4:

                        itemCount = 4;

                        selectInvalidAmount = false;
                        break;
                    case ConsoleKey.D5:

                        itemCount = 5;

                        selectInvalidAmount = false;
                        break;
                    case ConsoleKey.D6:

                        itemCount = 6;

                        selectInvalidAmount = false;
                        break;
                    case ConsoleKey.D7:

                        itemCount = 7;

                        selectInvalidAmount = false;
                        break;
                    case ConsoleKey.D8:

                        itemCount = 8;

                        selectInvalidAmount = false;
                        break;
                    case ConsoleKey.D9:

                        itemCount = 9;

                        selectInvalidAmount = false;
                        break;
                }
            }
            #endregion

            //Calculate cost and VAT and print.
            Console.Clear();
            Console.WriteLine("Receipt:");
            Console.WriteLine(itemType + " x" + itemCount);
            Console.WriteLine("Net: " + (itemCost * itemCount) + " | " + itemCost + " x " + itemCount);
            Console.WriteLine("VAT: " + (CalculateTax(itemCategory, itemCount) * itemCost) + " | " + CalculateTax(itemCategory, itemCost) + " x " + itemCount);
            Console.WriteLine("Total cost: " + ((itemCost * itemCount) + (CalculateTax(itemCategory, itemCost) * itemCount)) + " | " + (itemCost + CalculateTax(itemCategory, itemCost)) + " x " + itemCount);

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }

        decimal CalculateTax(string productType, decimal productCost)
        {
            switch (productType)
            {
                case "Music Entertainment":
                    return (productCost * musicVAT) - productCost;

                case "Food":
                    return (productCost * foodVAT) - productCost;

                case "Alcohol":
                    return (productCost * alcoholVAT) - productCost;

                default:
                    return 0M;
            }
        }
    }
}
