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

           

        }

    }
}
