using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10218221_JaidenNaioo_POEPart1_GR1
{
    internal class Recipe
    {

        private string[] ingredientNames;
        private double[] ingredientQuantities;
        private string[] ingredientUnits;
        private string[] steps;
        private double[] OriginalitQuantities;

        public Recipe()
        {
            // Initialize empty arrays
            ingredientNames = new string[0];
            ingredientQuantities = new double[0];
            ingredientUnits = new string[0];
            steps = new string[0];
        }

        //a method used to capture elements assosiated with the recipe
        public void EnterRecipe()
        {

            // Clear previous data
            ingredientNames = new string[0];
            ingredientQuantities = new double[0];
            ingredientUnits = new string[0];
            steps = new string[0];
            OriginalitQuantities = new double[0];

            //Allowing for user input
            Console.Write("Please enter number of ingredients to be used in the recipe: ");
            int numIngredients = int.Parse(Console.ReadLine());

            // Initialize arrays with user-specified length
            ingredientNames = new string[numIngredients];
            ingredientQuantities = new double[numIngredients];
            ingredientUnits = new string[numIngredients];
            OriginalitQuantities = new double[numIngredients];

            // Get user input for each ingredient
            for (int i = 0; i < numIngredients; i++)
            {
                Console.WriteLine($"Please enter details for ingredient number " + numIngredients);
                Console.Write("Name: ");
                ingredientNames[i] = Console.ReadLine();

                Console.Write("Quantity: ");
                ingredientQuantities[i] = double.Parse(Console.ReadLine());
                OriginalitQuantities[i] = ingredientQuantities[i]; //saves origanal when user decides to scale

                Console.Write("Unit of measurement: ");
                ingredientUnits[i] = Console.ReadLine();
            }

            Console.Write("Please enter the number of steps required for the recipe: ");
            int numSteps = int.Parse(Console.ReadLine());

            // Initialize steps array with user-specified length
            steps = new string[numSteps];

            // Get user input for each step and repeats as per number of steps
            for (int i = 0; i < numSteps; i++)
            {
                Console.Write($"Please the " +
                    $"enter step {i + 1}: ");
                steps[i] = Console.ReadLine();
            }

        }

        //a method used to display inputs of user
        public void DisplayRecipe()
        {
            if (ingredientNames.Length == 0)
            {
                Console.WriteLine("Please input a valid recipe \nPress ENTER to continue");
            }
            else
            {
                Console.WriteLine("Ingredients:");
                for (int i = 0; i < ingredientNames.Length; i++)
                {
                    Console.WriteLine($"{ingredientQuantities[i]} {ingredientUnits[i]} of {ingredientNames[i]}");
                }

                Console.WriteLine("\nSteps:");
                for (int i = 0; i < steps.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {steps[i]} \nPress ENTER to continue");
                }

            }



        }

        // a method used to scale a recipe, by either a factor of 0.5, 2 or 3
        public void ScaleRecipe()
        {
            Console.WriteLine("Please enter a scaling factor: \n 1. 0,5 \n 2. 2 \n 3. 3");

            int options = int.Parse(Console.ReadLine());

            switch (options)
            {
                case 1:
                    for (int i = 0; i < ingredientQuantities.Length; i++)
                    {
                        ingredientQuantities[i] *= 0.5;
                        Console.WriteLine("The recipe you have enter has now been scaled to 0,5. \nPress ENTER to continue");
                    }
                    break;
                case 2:
                    for (int i = 0; i < ingredientQuantities.Length; i++)
                    {
                        ingredientQuantities[i] *= 2;
                        Console.WriteLine("The recipe you have enter has now been scaled to 2. \nPress ENTER to continue");
                    }
                    break;
                case 3:
                    for (int i = 0; i < ingredientQuantities.Length; i++)
                    {
                        ingredientQuantities[i] *= 3;
                        Console.WriteLine("The recipe you have enter has now been scaled to 3. \nPress ENTER to continue");
                    }
                    break;
                default:
                    Console.WriteLine("Sorry option not available");
                    break;

            }

        }

    }
}
