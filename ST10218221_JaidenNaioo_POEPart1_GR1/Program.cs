using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10218221_JaidenNaioo_POEPart1_GR1
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Recipe recipe = new Recipe();

            while (true)
            {
                Console.WriteLine("________________________________________________________");
                Console.WriteLine("               Recipe Program                           ");
                Console.WriteLine("________________________________________________________");

                Console.WriteLine("\nSelect an option:");
                Console.WriteLine("1. Enter a recipe");
                Console.WriteLine("2. Display the recipe");
                Console.WriteLine("3. Scale the recipe");
                Console.WriteLine("4. Reset the quantities");
                Console.WriteLine("5. Clear the recipe data");
                Console.WriteLine("6. Exit");

                Console.WriteLine("________________________________________________________");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        recipe.EnterRecipe();
                        break;
                    case 2:
                        recipe.DisplayRecipe();
                        break;
                    case 3:
                        recipe.ScaleRecipe();
                        break;
                    case 4:
                        recipe.ResetQuantity();
                        break;
                    case 5:
                        recipe.Clear();
                        break;
                    case 6:
                        Environment.Exit(6);
                        break;
                    default:
                        Console.WriteLine("Sorry option not available");
                        break;

                }

                Console.ReadKey();
            }
        }
    }
}

