using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROGPOEPART2.ST10209314.Model;

namespace PROGPOEPART2.ST10209314.Util
{
    // Utility class to manage the menu operations
    public class MenuUtil
    {
        // Method to display the menu and handle user choices in a loop
        public static void ShowMenuLoop(List<Recipe> recipes)
        {
            while (true)
            {
                // Display the menu options
                Console.WriteLine(Constants.MENU);

                // Get the user's menu choice
                int choice = PrintUtil.ReadIntegerInput(Constants.CHOOSE_OPTION_MESSAGE, ConsoleColor.Yellow);

                // Handle the user's menu choice
                switch (choice)
                {
                    // Create a new recipe and add it to the list
                    case 1:
                        var newRecipe = Recipe.CreateRecipe();
                        recipes.Add(newRecipe);
                        break;
                    // Scale an existing recipe
                    case 2:
                        Recipe.ScaleRecipe();
                        break;
                    // Display a specific recipe
                    case 3:
                        Recipe.DisplayRecipe(recipes);
                        break;
                    // Reset a recipe
                    case 4:
                        Recipe.ResetRecipe();
                        break;
                    // Clear all recipes from the list
                    case 5:
                        Recipe.ClearAllData(recipes);
                        break;
                    // Exit the menu loop
                    case 6:
                        return;
                    // Handle invalid menu choices
                    default:
                        Console.WriteLine(Constants.INVALID_CHOICE_MESSAGE);
                        break;
                }
            }
        }
    }
}