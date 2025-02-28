/*
Entreprise : ETML
Auteur : Meron Essayas
Date : 24.01.2025
Description : 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;

namespace WorldSystem
{
    internal class Program
    {
        // Déclaration de la fonction Windows qui peut être utilisée pour manipuler la fenêtre
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        // Constantes utilisées pour manipuler la fenêtre
        const int SW_MAXIMIZE = 3;
        static Vector2 GroundPosition = new Vector2(10, 40);
        static Vector2 InputPosition = new Vector2(GroundPosition.X, GroundPosition.Y + 2);

        static void Main(string[] args)
        {
            
            Vector2 ItemsPosition = GroundPosition;
            Vector2 DisplayPosition = new Vector2(2, 2);
            

            //Console.ReadLine();

            IntPtr hWnd = GetConsoleWindow();

            // Maximiser la fenêtre
            ShowWindow(hWnd, SW_MAXIMIZE);

            Random random = new Random();

            Array rarity = Enum.GetValues(typeof(Rarity));

            List<Material> Materials = new List<Material>()
            {
                new Material(name:"wood", weight:1, price:10),
                new Material(name:"stone", weight:2, price:20),
                new Material(name:"iron", weight:3, price:30),
                new Material(name:"steel", weight:4, price:40),
                new Material(name:"silver", weight:5, price:50),
                new Material(name:"gold", weight:6, price:60),
                new Material(name:"diamond", weight:7, price:70)
            };

            List<IItem> worldItems = new List<IItem>()
            {
                 new Resource(Quantity:random.Next(0, 10), Rarity:(Rarity)rarity.GetValue(random.Next(rarity.Length)), Material:Materials[random.Next(Materials.Count)]),
                 new Resource(Quantity:random.Next(0, 10), Rarity:(Rarity)rarity.GetValue(random.Next(rarity.Length)), Material:Materials[random.Next(Materials.Count)]),
                 new Resource(Quantity:random.Next(0, 10), Rarity:(Rarity)rarity.GetValue(random.Next(rarity.Length)), Material:Materials[random.Next(Materials.Count)]),
                 new Resource(Quantity:random.Next(0, 10), Rarity:(Rarity)rarity.GetValue(random.Next(rarity.Length)), Material:Materials[random.Next(Materials.Count)]),
                 new Resource(Quantity:random.Next(0, 10), Rarity:(Rarity)rarity.GetValue(random.Next(rarity.Length)), Material:Materials[random.Next(Materials.Count)]),
                 new Resource(Quantity:random.Next(0, 10), Rarity:(Rarity)rarity.GetValue(random.Next(rarity.Length)), Material:Materials[random.Next(Materials.Count)]),
                 new Resource(Quantity:random.Next(0, 10), Rarity:(Rarity)rarity.GetValue(random.Next(rarity.Length)), Material:Materials[random.Next(Materials.Count)]),
                 new Resource(Quantity:random.Next(0, 10), Rarity:(Rarity)rarity.GetValue(random.Next(rarity.Length)), Material:Materials[random.Next(Materials.Count)]),
                 new Resource(Quantity:random.Next(0, 10), Rarity:(Rarity)rarity.GetValue(random.Next(rarity.Length)), Material:Materials[random.Next(Materials.Count)]),
                 new Resource(Quantity:random.Next(0, 10), Rarity:(Rarity)rarity.GetValue(random.Next(rarity.Length)), Material:Materials[random.Next(Materials.Count)]),
                 new Resource(Quantity:random.Next(0, 10), Rarity:(Rarity)rarity.GetValue(random.Next(rarity.Length)), Material:Materials[random.Next(Materials.Count)]),
                 new Resource(Quantity:random.Next(0, 10), Rarity:(Rarity)rarity.GetValue(random.Next(rarity.Length)), Material:Materials[random.Next(Materials.Count)]),
                 new Resource(Quantity:random.Next(0, 10), Rarity:(Rarity)rarity.GetValue(random.Next(rarity.Length)), Material:Materials[random.Next(Materials.Count)]),
                 new Resource(Quantity:random.Next(0, 10), Rarity:(Rarity)rarity.GetValue(random.Next(rarity.Length)), Material:Materials[random.Next(Materials.Count)]),
                 new Resource(Quantity:random.Next(0, 10), Rarity:(Rarity)rarity.GetValue(random.Next(rarity.Length)), Material:Materials[random.Next(Materials.Count)]),
                 new Sword   (Quantity:random.Next(0, 10), Rarity:(Rarity)rarity.GetValue(random.Next(rarity.Length)), Resource:new Resource(Quantity:1, Material:Materials[random.Next(Materials.Count)], Rarity:(Rarity)rarity.GetValue(random.Next(rarity.Length)))),
                 new Sword   (Quantity:random.Next(0, 10), Rarity:(Rarity)rarity.GetValue(random.Next(rarity.Length)), Resource:new Resource(Quantity:1, Material:Materials[random.Next(Materials.Count)], Rarity:(Rarity)rarity.GetValue(random.Next(rarity.Length)))),
                 new Sword   (Quantity:random.Next(0, 10), Rarity:(Rarity)rarity.GetValue(random.Next(rarity.Length)), Resource:new Resource(Quantity:1, Material:Materials[random.Next(Materials.Count)], Rarity:(Rarity)rarity.GetValue(random.Next(rarity.Length)))),
                 new Sword   (Quantity:random.Next(0, 10), Rarity:(Rarity)rarity.GetValue(random.Next(rarity.Length)), Resource:new Resource(Quantity:1, Material:Materials[random.Next(Materials.Count)], Rarity:(Rarity)rarity.GetValue(random.Next(rarity.Length)))),
                 new Sword   (Quantity:random.Next(0, 10), Rarity:(Rarity)rarity.GetValue(random.Next(rarity.Length)), Resource:new Resource(Quantity:1, Material:Materials[random.Next(Materials.Count)], Rarity:(Rarity)rarity.GetValue(random.Next(rarity.Length)))),
                 new Sword   (Quantity:random.Next(0, 10), Rarity:(Rarity)rarity.GetValue(random.Next(rarity.Length)), Resource:new Resource(Quantity:1, Material:Materials[random.Next(Materials.Count)], Rarity:(Rarity)rarity.GetValue(random.Next(rarity.Length)))),
                 new Sword   (Quantity:random.Next(0, 10), Rarity:(Rarity)rarity.GetValue(random.Next(rarity.Length)), Resource:new Resource(Quantity:1, Material:Materials[random.Next(Materials.Count)], Rarity:(Rarity)rarity.GetValue(random.Next(rarity.Length)))),
                 new Sword   (Quantity:random.Next(0, 10), Rarity:(Rarity)rarity.GetValue(random.Next(rarity.Length)), Resource:new Resource(Quantity:1, Material:Materials[random.Next(Materials.Count)], Rarity:(Rarity)rarity.GetValue(random.Next(rarity.Length)))),
                 new Sword   (Quantity:random.Next(0, 10), Rarity:(Rarity)rarity.GetValue(random.Next(rarity.Length)), Resource:new Resource(Quantity:1, Material:Materials[random.Next(Materials.Count)], Rarity:(Rarity)rarity.GetValue(random.Next(rarity.Length)))),
                 new Sword   (Quantity:random.Next(0, 10), Rarity:(Rarity)rarity.GetValue(random.Next(rarity.Length)), Resource:new Resource(Quantity:1, Material:Materials[random.Next(Materials.Count)], Rarity:(Rarity)rarity.GetValue(random.Next(rarity.Length)))),
                 new Sword   (Quantity:random.Next(0, 10), Rarity:(Rarity)rarity.GetValue(random.Next(rarity.Length)), Resource:new Resource(Quantity:1, Material:Materials[random.Next(Materials.Count)], Rarity:(Rarity)rarity.GetValue(random.Next(rarity.Length)))),
                 new Sword   (Quantity:random.Next(0, 10), Rarity:(Rarity)rarity.GetValue(random.Next(rarity.Length)), Resource:new Resource(Quantity:1, Material:Materials[random.Next(Materials.Count)], Rarity:(Rarity)rarity.GetValue(random.Next(rarity.Length)))),
                 new Sword   (Quantity:random.Next(0, 10), Rarity:(Rarity)rarity.GetValue(random.Next(rarity.Length)), Resource:new Resource(Quantity:1, Material:Materials[random.Next(Materials.Count)], Rarity:(Rarity)rarity.GetValue(random.Next(rarity.Length)))),
                 new Sword   (Quantity:random.Next(0, 10), Rarity:(Rarity)rarity.GetValue(random.Next(rarity.Length)), Resource:new Resource(Quantity:1, Material:Materials[random.Next(Materials.Count)], Rarity:(Rarity)rarity.GetValue(random.Next(rarity.Length)))),
                 new Shield  (Quantity:random.Next(0, 10), Rarity:(Rarity)rarity.GetValue(random.Next(rarity.Length)), Resource:new Resource(Quantity:1, Material:Materials[random.Next(Materials.Count)], Rarity:(Rarity)rarity.GetValue(random.Next(rarity.Length)))),
                 new Shield  (Quantity:random.Next(0, 10), Rarity:(Rarity)rarity.GetValue(random.Next(rarity.Length)), Resource:new Resource(Quantity:1, Material:Materials[random.Next(Materials.Count)], Rarity:(Rarity)rarity.GetValue(random.Next(rarity.Length)))),
                 new Shield  (Quantity:random.Next(0, 10), Rarity:(Rarity)rarity.GetValue(random.Next(rarity.Length)), Resource:new Resource(Quantity:1, Material:Materials[random.Next(Materials.Count)], Rarity:(Rarity)rarity.GetValue(random.Next(rarity.Length)))),
                 new Shield  (Quantity:random.Next(0, 10), Rarity:(Rarity)rarity.GetValue(random.Next(rarity.Length)), Resource:new Resource(Quantity:1, Material:Materials[random.Next(Materials.Count)], Rarity:(Rarity)rarity.GetValue(random.Next(rarity.Length)))),
                 new Shield  (Quantity:random.Next(0, 10), Rarity:(Rarity)rarity.GetValue(random.Next(rarity.Length)), Resource:new Resource(Quantity:1, Material:Materials[random.Next(Materials.Count)], Rarity:(Rarity)rarity.GetValue(random.Next(rarity.Length)))),
                 new Shield  (Quantity:random.Next(0, 10), Rarity:(Rarity)rarity.GetValue(random.Next(rarity.Length)), Resource:new Resource(Quantity:1, Material:Materials[random.Next(Materials.Count)], Rarity:(Rarity)rarity.GetValue(random.Next(rarity.Length)))),
                 new Shield  (Quantity:random.Next(0, 10), Rarity:(Rarity)rarity.GetValue(random.Next(rarity.Length)), Resource:new Resource(Quantity:1, Material:Materials[random.Next(Materials.Count)], Rarity:(Rarity)rarity.GetValue(random.Next(rarity.Length)))),
                 new Shield  (Quantity:random.Next(0, 10), Rarity:(Rarity)rarity.GetValue(random.Next(rarity.Length)), Resource:new Resource(Quantity:1, Material:Materials[random.Next(Materials.Count)], Rarity:(Rarity)rarity.GetValue(random.Next(rarity.Length)))),
                 new Shield  (Quantity:random.Next(0, 10), Rarity:(Rarity)rarity.GetValue(random.Next(rarity.Length)), Resource:new Resource(Quantity:1, Material:Materials[random.Next(Materials.Count)], Rarity:(Rarity)rarity.GetValue(random.Next(rarity.Length)))),
                 new Shield  (Quantity:random.Next(0, 10), Rarity:(Rarity)rarity.GetValue(random.Next(rarity.Length)), Resource:new Resource(Quantity:1, Material:Materials[random.Next(Materials.Count)], Rarity:(Rarity)rarity.GetValue(random.Next(rarity.Length)))),
                 new Shield  (Quantity:random.Next(0, 10), Rarity:(Rarity)rarity.GetValue(random.Next(rarity.Length)), Resource:new Resource(Quantity:1, Material:Materials[random.Next(Materials.Count)], Rarity:(Rarity)rarity.GetValue(random.Next(rarity.Length)))),
                 new Shield  (Quantity:random.Next(0, 10), Rarity:(Rarity)rarity.GetValue(random.Next(rarity.Length)), Resource:new Resource(Quantity:1, Material:Materials[random.Next(Materials.Count)], Rarity:(Rarity)rarity.GetValue(random.Next(rarity.Length)))),
            };
            // Randomize the list
            worldItems = worldItems.OrderBy(x => random.Next()).ToList();

            int counter = 0;

            foreach (IItem item in worldItems)
            {
                Console.SetCursorPosition((int)(ItemsPosition.X += 3), (int)GroundPosition.Y - 1);

                Console.ForegroundColor = ColorItem(item);

                Console.Write($" {RetourneChar(item)}  ");

                Console.ResetColor();

                Console.SetCursorPosition((int)(ItemsPosition.X), (int)GroundPosition.Y - 2);

                Console.Write($" {counter++} ");
            }

            Console.SetCursorPosition((int)GroundPosition.X, (int)GroundPosition.Y);
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------");

            while (true)
            {
                // Ask for the index first
                Console.SetCursorPosition((int)InputPosition.X, (int)InputPosition.Y);
                Console.Write("                                                                                           ");
                Console.SetCursorPosition((int)InputPosition.X, (int)InputPosition.Y);
                Console.Write("Entrer le numero de l'objet de 0 à " + (worldItems.Count - 1) + ": ");

                // Read the user input
                string input = Console.ReadLine();

                int index;  // Declare the index variable

                // Try to parse the user input into an integer
                if (int.TryParse(input, out index))
                {
                    if (index >= 0 && index < worldItems.Count) // Check if the index is valid
                    {
                        Console.Write("                                                                                           ");
                        IItem selectedItem = worldItems[index];

                        // Call Display method based on the type of the selected item
                        if (selectedItem is Sword thisSword)
                        {
                            thisSword.Display(DisplayPosition, InputPosition, worldItems.Count);
                        }
                        else if (selectedItem is Shield thisShield)
                        {
                            thisShield.Display(DisplayPosition, InputPosition, worldItems.Count);
                        }
                        else if (selectedItem is Resource thisResource)
                        {
                            thisResource.Display(DisplayPosition, InputPosition, worldItems.Count);
                        }
                    }
                    else
                    { 
                        Console.SetCursorPosition((int)InputPosition.X, (int)InputPosition.Y + 1);
                        Console.Write("Index hors limites. Veuillez entrer un index valide.");
                        Console.SetCursorPosition((int)InputPosition.X, (int)InputPosition.Y);
                        Console.Write("                                                                                           ");
                        Console.SetCursorPosition((int)InputPosition.X, (int)InputPosition.Y);
                        Console.Write("Entrer le numero de l'objet de 0 à " + (worldItems.Count - 1) + "): ");
                    }
                }
                else
                {
                    Console.SetCursorPosition((int)InputPosition.X, (int)InputPosition.Y + 1);
                    Console.Write("Entrée invalide. Veuillez entrer un nombre entier.");
                    Console.SetCursorPosition((int)InputPosition.X, (int)InputPosition.Y);
                    Console.Write("                                                                                           ");
                    Console.SetCursorPosition((int)InputPosition.X, (int)InputPosition.Y);
                    Console.Write("Entrer le numero de l'objet de 0 à " + (worldItems.Count - 1) + "): ");
                }

                Console.SetCursorPosition((int)GroundPosition.X, (int)GroundPosition.Y);
                Console.WriteLine("-----------------------------------------------------------------");
            }
        }

        static ConsoleColor ColorItem(IItem item)
        {
            if (item is Resource resource)
                return ColorMaterial(resource.Material);
            if (item is Shield shield)
                return ColorMaterial(shield.Resource.Material);
            if (item is Sword sword)
                return ColorMaterial(sword.Resource.Material);
            else
                return ConsoleColor.White;
        }

        static ConsoleColor ColorMaterial(Material Material)
        {
            switch (Material.Name)
            {
                case "wood":
                    return ConsoleColor.DarkRed;
                case "stone":
                    return ConsoleColor.Green;
                case "iron":
                    return ConsoleColor.Red;
                case "steel":
                    return ConsoleColor.DarkGray;
                case "silver":
                    return ConsoleColor.Gray;
                case "gold":
                    return ConsoleColor.Yellow;
                case "diamond":
                    return ConsoleColor.Cyan;
                default:
                    break;
            }
            return ConsoleColor.White;
        }

        static char RetourneChar(IItem item)
        {
            if (item is Resource)
                return 'R';
            if (item is Shield)
                return 'S';
            if (item is Sword)
                return 'T';
            else
                return 'E';
        }
    }
}
