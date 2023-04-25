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



        }

    }
}
