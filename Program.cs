using System;
using System.Text.RegularExpressions;

//Jordan Martin
//IT112
//Notes: I used regex to see if the key input is a digit from 1-6. I reasearch into regex so I may have a better understanding of each symbols use. I find it very usefull for validating a string
// of data. I also used System.Linq to remove duplicate values in my quantity and the name of the product.
// BEHAVIORS NOT IMPLEMENTED AND WHY: I did not create a constructor for my class. I only call the shipper class with an interface object. 
// I felt that creating a constructor class for the shipper class for an interface object was not nessary. 


namespace Martin_Inventory
{
    class Program
    {
        static ConsoleKeyInfo userInput;
        static IShippable [] iship = new IShippable[10];
        static Shipper sp = new Shipper();


        static void Main(string[] args)
        {
            OptionsMenu();
        }

        static void OptionsMenu()
        {

            do
            {
                Console.WriteLine("Choose from the following options:");
                Console.WriteLine("1. Add a Bicycle to the shipment");
                Console.WriteLine("2. Add a Lawn Mower to the Shipment");
                Console.WriteLine("3. Add a Baseball Glove to the shipment");
                Console.WriteLine("4. Add Crackers to the shipment");
                Console.WriteLine("5. List Shipment Items");
                Console.WriteLine("6. Compute Shipping Charges");

                userInput = Console.ReadKey();
                Console.WriteLine("");
                Console.Clear();
                ValidateInput(userInput);

            } while (userInput.Key != ConsoleKey.D6);

            Console.WriteLine("Total shipping cost for this order is " + sp.TotalCost().ToString("C") + ".");
            Console.WriteLine("Press any key to exit the program.");
            Console.ReadKey();
            Console.Clear();
        }

        static void ValidateInput(ConsoleKeyInfo testInput)
        {
            //Regex to verify if the key is 1-6. if not it will run the bad input method.
            if(!Regex.Match(testInput.Key.ToString(), ".*[1-6].*").Success)
            {
                BadInput();
            }
            else if(testInput.Key == ConsoleKey.D1)
            {
                iship [0] = new Bicycles();
                Console.WriteLine(sp.Add(iship));
                PressKey();
            }
            else if (testInput.Key == ConsoleKey.D2)
            {
                iship[0] = new Lawn_Mowers();
                Console.WriteLine(sp.Add(iship));
                PressKey();
            }
            else if (testInput.Key == ConsoleKey.D3) 
            {
                iship[0] = new Baseball_Gloves();
                Console.WriteLine(sp.Add(iship));
                PressKey();
            }
            else if (testInput.Key == ConsoleKey.D4)
            {
                iship[0] = new Crackers();
                Console.WriteLine(sp.Add(iship));
                PressKey();
            }
            else if (testInput.Key == ConsoleKey.D5)
            {
                sp.List();
            }

        }

        static void BadInput()
        {
            Console.WriteLine("Bad input please enter one of the following digits.");
            OptionsMenu();
            ConsoleKeyInfo newKey = Console.ReadKey();
            userInput = newKey;
        }

        static void PressKey()
        {
            Console.WriteLine("Press any key to return to the menu.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
