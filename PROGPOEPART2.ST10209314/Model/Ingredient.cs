using PROGPOEPART2.ST10209314.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGPOEPART2.ST10209314.Model
{
    // Represents an ingredient used in a recipe
    public class Ingredient
    {
        // Properties for the ingredient's details
        public string Name { get; set; }
        public double Quantiy { get; set; }
        public string UnitOfMeasurement { get; set; }
        public double Calories { get; set; }
        public string FoodGroup { get; set; }

        // Constructor to initialize an ingredient with specific details
        public Ingredient(string name, double quantity, string unitOfMeasurement, double calories, string foodGroup)
        {
            Name = name;
            Quantiy = quantity;
            UnitOfMeasurement = unitOfMeasurement;
            Calories = calories;
            FoodGroup = foodGroup;
        }

        // Static method to gather a list of ingredients from user input
        public static List<Ingredient> GetIngredientsFromUser(int count)
        {
            var ingredients = new List<Ingredient>();

            // Loop to collect details for each ingredient from the user
            for (int i = 0; i < count; i++)
            {
                string name = PrintUtil.ReadStringInput(Constants.ENTER_INGREDIENT_NAME_MESSAGE, ConsoleColor.Yellow);
                double quantity = PrintUtil.ReadDoubleInput(Constants.ENTER_INGREDIENT_QUANTITY_MESSAGE, ConsoleColor.Yellow);
                string unitOfMeasurement = PrintUtil.ReadStringInput(Constants.ENTER_INGREDIENT_UNIT_MESSAGE, ConsoleColor.Yellow);
                double calories = PrintUtil.ReadDoubleInput(Constants.ENTER_INGREDIENT_CALORIES_MESSAGE, ConsoleColor.Yellow);
                string foodGroup = GetFoodGroupFromUser();

                // Add the ingredient to the list
                ingredients.Add(new Ingredient(name, quantity, unitOfMeasurement, calories, foodGroup));
            }

            // Return the list of ingredients
            return ingredients;
        }

        // Private static method to get the food group from user input
        private static string GetFoodGroupFromUser()
        {
            // Prompt the user to enter the food group
            Console.WriteLine(Constants.ENTER_INGREDIENT_FOOD_GROUP_MESSAGE);

            // Display the list of food groups for the user to choose from
            for (int i = 0; i < Constants.FOOD_GROUPS.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {Constants.FOOD_GROUPS[i]}");
            }

            // Get the user's choice
            int choice = PrintUtil.ReadIntegerInput(Constants.CHOOSE_OPTION_MESSAGE, ConsoleColor.Yellow);

            // Validate the choice and return the selected food group
            if (choice >= 1 && choice <= Constants.FOOD_GROUPS.Length)
            {
                return Constants.FOOD_GROUPS[choice - 1];
            }

            // If the choice is invalid, prompt the user again
            Console.WriteLine(Constants.INVALID_CHOICE_MESSAGE);
            return GetFoodGroupFromUser();
        }
    }
}