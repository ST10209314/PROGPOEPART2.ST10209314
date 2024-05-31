using PROGPOEPART2.ST10209314.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGPOEPART2.ST10209314.Model
{
    // Delegates definition for recipe-related events
    public delegate void RecipeEventHandler(object sender, EventArgs e);

    public class Recipe


    {
        // Properties for the recipe's name, ingredients, and steps
        public string Name { get; set; }

        public List<Ingredient> Ingredients { get; set; }

        private List<string> Steps { get; set; }

        // Events for recipe-related actions
        public static event RecipeEventHandler RecipeAdded;
        public static event RecipeEventHandler RecipeScaled;
        public static event RecipeEventHandler RecipeReset;


        // This constructor initializes the recipe with a name
        public Recipe(string name)
        {
            Name = name;
            Ingredients = new List<Ingredient>();
            Steps = new List<string>();
        }


        // A static method to create a new recipe from user input
        public static Recipe CreateRecipe()
        {

            string recipeName = PrintUtil.ReadStringInput(Constants.ENTER_RECIPE_NAME_MESSAGE, ConsoleColor.Magenta);
            int numIngredients = PrintUtil.ReadIntegerInput(Constants.ENTER_NUM_INGREDIENTS_MESSAGE, ConsoleColor.Magenta);
            var ingredients = Ingredient.GetIngredientsFromUser(numIngredients);

            var recipe = new Recipe(recipeName)
            {
                Ingredients = ingredients
            };

            // Checkif the total calories exceed a limit and notify if true
 
            recipe.NotifyIfCaloriesExceed(300, () =>
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(Constants.CALORIE_EXCEED_MESSAGE);
                Console.ForegroundColor = ConsoleColor.White;
            });

            int numSteps = PrintUtil.ReadIntegerInput(Constants.ENTER_NUM_STEPS_MESSAGE, ConsoleColor.Magenta);
            recipe.AddStepsFromUserInput(numSteps);

            OnRecipeAdded(EventArgs.Empty);

            // Displays the total calories
            Console.WriteLine($"{Constants.TOTAL_CALORIES_MESSAGE} {recipe.GetTotalCalories()}");

            return recipe;
        }

        public void DisplayRecipe()
        {
            //Display recipe name
            Console.WriteLine($"{Constants.RECIPE_TITLE}: {Name}");
            //Display ingredients title
            Console.WriteLine(Constants.INGREDIENTS_TITLE);
            //Show each ingredients
            foreach (var ingredient in Ingredients)
            {
                Console.WriteLine($"{ingredient.Quantiy} {ingredient.UnitOfMeasurement} of {ingredient.Name} ({ingredient.Calories} calories, {ingredient.FoodGroup})");
            }
            //Showing steps title
            Console.WriteLine(Constants.STEPS_TITLE);
            //Show each step
            for (int i = 0; i < Steps.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Steps[i]}");
            }
        }

        // Static method to list all recipes
        public static void ListRecipes(List<Recipe> recipes)
        {
            if (!recipes.Any())
            {
                Console.WriteLine(Constants.NO_RECIPES_AVAILABLE_MESSAGE);
                return;
            }

            Console.WriteLine(Constants.LIST_OF_RECIPES_TITLE_MESSAGE);
            foreach (var recipe in recipes.OrderBy(r => r.Name))
            {
                Console.WriteLine(recipe.Name);
            }
        }

        // Static method to display a specific recipe by name
        public static void DisplayRecipe(List<Recipe> recipes)
        {
            if (!recipes.Any())
            {
                Console.WriteLine(Constants.NO_RECIPES_AVAILABLE_MESSAGE);
                return;
            }

            ListRecipes(recipes);

            // Reads the name of the recipe to display
            string recipeName = PrintUtil.ReadStringInput(Constants.ENTER_RECIPE_NAME_TO_DISPLAY_MESSAGE, ConsoleColor.Yellow);
            var recipe = recipes.FirstOrDefault(r => r.Name.Equals(recipeName, StringComparison.OrdinalIgnoreCase));

            if (recipe != null)
            {
                recipe.DisplayRecipe();
            }
            else
            {
                Console.WriteLine(Constants.RECIPE_NOT_FOUND_MESSAGE);
            }
        }

        // Static method to clear all recipe data
        public static void ClearAllData(List<Recipe> recipes)
        {
            recipes.Clear();
            Console.WriteLine(Constants.ALL_RECIPES_CLEARED_MESSAGE);
        }


        public static void ScaleRecipe()
        {
            OnRecipeScaled(EventArgs.Empty);
        }

        public static void ResetRecipe()
        {
            OnRecipeReset(EventArgs.Empty);
        }

        protected static void OnRecipeAdded(EventArgs e)
        {
            RecipeAdded?.Invoke(null, e);
        }

        protected static void OnRecipeScaled(EventArgs e)
        {
            RecipeScaled?.Invoke(null, e);
        }

        protected static void OnRecipeReset(EventArgs e)
        {
            RecipeReset?.Invoke(null, e);
        }


        public double GetTotalCalories()
        {
            return Ingredients.Sum(i => i.Calories * i.Quantiy);
        }

        // Private method to notify if total calories exceed a limit
        private void NotifyIfCaloriesExceed(int limit, Action notify)
        {
            if (GetTotalCalories() > limit)
            {
                notify();
            }
        }

        // Method to add steps to the recipe from user input
        public void AddStepsFromUserInput(int numSteps)
        {
            for (int i = 0; i < numSteps; i++)
            {
                string description = PrintUtil.ReadStringInput($"{Constants.ENTER_STEP_MESSAGE} {i + 1}:", ConsoleColor.Magenta);
                Steps.Add(description);
            }
        }


    }
}
