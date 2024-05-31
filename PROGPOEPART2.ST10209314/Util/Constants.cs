using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGPOEPART2.ST10209314.Util
{
    // Class to store constant values used throughout the application
    public class Constants
    {
        // Welcome message displayed when the application starts
        public const string WELCOME_MESSAGE = "Welcome to the Recipe Application!";

        // Error messages for invalid input types
        public const string STRING_INPUT_ERROR_MESSAGE = "Error: Only words are allowed. Please enter a valid string input";
        public const string INTEGER_INPUT_ERROR_MESSAGE = "Error: Only integers are allowed. Please enter a valid integer input";
        public const string DOUBLE_INPUT_ERROR_MESSAGE = "Error: Only decimal numbers are allowed. Please enter a decimal number input";

        // Prompt messages for ingredient input
        public const string ENTER_INGREDIENT_NAME_MESSAGE = "Enter the name of the ingredient:";
        public const string ENTER_INGREDIENT_QUANTITY_MESSAGE = "Enter the quantity of the ingredient:";
        public const string ENTER_INGREDIENT_UNIT_MESSAGE = "Enter the unit of measurement of the ingredient";

        // Explanation and prompt messages for additional ingredient details
        public const string CALORIES_EXPLANATION_MESSAGE = "Calories are units of energy. Please enter the number of calories in the ingredient:";
        public const string ENTER_INGREDIENT_CALORIES_MESSAGE = "Enter the number of calories in the ingredient:";
        public const string FOOD_GROUPS_EXPLANATION_MESSAGE = "Food groups categorize foods based on their nutritional properties.";
        public const string ENTER_INGREDIENT_FOOD_GROUP_MESSAGE = "Enter the food group of the ingredient:";

        // Prompt messages for recipe input
        public const string ENTER_RECIPE_NAME_MESSAGE = "Enter the name of the recipe:";
        public const string ENTER_NUM_INGREDIENTS_MESSAGE = "Enter the number of ingredients:";
        public const string ENTER_NUM_STEPS_MESSAGE = "Enter the number of steps:";
        public const string ENTER_RECIPE_NAME_TO_DISPLAY_MESSAGE = "Enter the name of the recipe to display";
        public const string ENTER_INGREDIENT_DETAILS_MESSAGE = "Enter the details for ingredient";
        public const string ENTER_STEP_MESSAGE = "Step";

        // Messages for displaying recipe information
        public const string TOTAL_CALORIES_MESSAGE = "Total calories in the recipe:";
        public const string CALORIE_EXCEED_MESSAGE = "This recipe exceeds 300 calories! It's getting more unhealthy, consider adding fewer high-calorie ingredients.";
        public const string CALORIE_UNDER_LIMIT_MESSAGE = "Nice! Keeping the recipe under 300 calories is a good range of calories.";

        // Messages for various recipe operations
        public const string RECIPE_ADDED_MESSAGE = "Recipe has been added successfully!";
        public const string RECIPE_SCALED_MESSAGE = "Recipe has been scaled successfully!";
        public const string RECIPE_RESET_MESSAGE = "Recipe has been reset successfully!";
        public const string NO_RECIPES_AVAILABLE_MESSAGE = "No recipes available.";
        public const string RECIPE_NOT_FOUND_MESSAGE = "Recipe not found.";
        public const string ALL_RECIPES_CLEARED_MESSAGE = "All recipes have been cleared.";
        public const string LIST_OF_RECIPES_TITLE_MESSAGE = "List of recipes:";
        public const string RECIPE_TITLE = "Recipe";
        public const string INGREDIENTS_TITLE = "Ingredients:";
        public const string STEPS_TITLE = "Steps:";

        // Menu options displayed to the user
        public const string MENU = "Menu:" +
                                   "\n1. Add a new recipe" +
                                   "\n2. Scale a recipe" +
                                   "\n3. Display a recipe" +
                                   "\n4. Reset recipe quantities" +
                                   "\n5. Clear all the data" +
                                   "\n6. Exit";

        // Prompt message for choosing a menu option
        public const string CHOOSE_OPTION_MESSAGE = "Choose an option:";
        // Message displayed for invalid menu choices
        public const string INVALID_CHOICE_MESSAGE = "Invalid choice. Please try again";

        // Array of food groups used for ingredient categorization
        public static readonly string[] FOOD_GROUPS =
        {
            "Starchy foods",
            "Vegetables and fruits",
            "Dry beans, peas, lentils and soya",
            "Chicken, fish, meat and eggs",
            "Fats and oil",
            "Water"
        };
    }
}
