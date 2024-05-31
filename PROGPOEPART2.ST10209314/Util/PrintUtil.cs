using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROGPOEPART2.ST10209314.Exception;
using PROGPOEPART2.ST10209314.Model;

namespace PROGPOEPART2.ST10209314.Util
{
    // Utility class for handling console input and output operations
    public class PrintUtil
    {
        // Method to read string input from the console with validation and color customization
        public static string ReadStringInput(string prompt, ConsoleColor consoleColor)
        {
            // Set the console text color and display the prompt
            Console.ForegroundColor = consoleColor;
            Console.WriteLine(prompt);
            // Reset console color to default
            Console.ForegroundColor = ConsoleColor.White;

            // Read input from the user
            string input = Console.ReadLine();

            // Check if input is a valid string (not an integer)
            if (int.TryParse(input, out _))
            {
                // Handle string input error and prompt again
                ExceptionHandler.HandleStringInputError();
                return ReadStringInput(prompt, consoleColor);
            }

            // Return valid input
            return input;
        }

        // Method to read integer input from the console with validation and color customization
        public static int ReadIntegerInput(string prompt, ConsoleColor consoleColor)
        {
            // Set the console text color and display the prompt
            Console.ForegroundColor = consoleColor;
            Console.WriteLine(prompt);
            // Reset console color to default
            Console.ForegroundColor = ConsoleColor.White;

            // Read input from the user
            string input = Console.ReadLine();

            // Check if input is a valid integer
            if (!int.TryParse(input, out int result))
            {
                // Handle integer input error and prompt again
                ExceptionHandler.HandleIntegerInputError();
                return ReadIntegerInput(prompt, consoleColor);
            }

            // Return valid input
            return result;
        }

        // Method to read double input from the console with validation and color customization
        public static double ReadDoubleInput(string prompt, ConsoleColor consoleColor)
        {
            // Set the console text color and display the prompt
            Console.ForegroundColor = consoleColor;
            Console.WriteLine(prompt);
            // Reset console color to default
            Console.ForegroundColor = ConsoleColor.White;

            // Read input from the user
            string input = Console.ReadLine();

            // Check if input is a valid double
            if (!double.TryParse(input, out double result))
            {
                // Handle double input error and prompt again
                ExceptionHandler.HandleDoubleInputError();
                return ReadDoubleInput(prompt, consoleColor);
            }

            // Return valid input
            return result;
        }

        // Event handler for when a recipe is added
        private static void OnRecipeAdded(object sender, EventArgs e)
        {
            Console.WriteLine(Constants.RECIPE_ADDED_MESSAGE);
        }

        // Event handler for when a recipe is scaled
        private static void OnRecipeScaled(object sender, EventArgs e)
        {
            Console.WriteLine(Constants.RECIPE_SCALED_MESSAGE);
        }

        // Event handler for when a recipe is reset
        private static void OnRecipeReset(object sender, EventArgs e)
        {
            Console.WriteLine(Constants.RECIPE_RESET_MESSAGE);
        }

        // Static constructor to subscribe to recipe events
        static PrintUtil()
        {
            Recipe.RecipeAdded += OnRecipeAdded;
            Recipe.RecipeScaled += OnRecipeScaled;
            Recipe.RecipeReset += OnRecipeReset;
        }
    }
}
