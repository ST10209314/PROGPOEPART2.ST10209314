
using System.Collections.Generic;
using PROGPOEPART2.ST10209314.Model;
using Xunit;


namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CalculateTotalCalories_OneIngredient()
        {

            {
                // Arrange
                var ingredients = new List<Ingredient>
            {
                new Ingredient("Ingredient1", 100, "g", 50, "Starchy foods")
            };
                var recipe = new Recipe("TestRecipe")
                {
                    Ingredients = ingredients
                };

                // Act
                var totalCalories = recipe.GetTotalCalories();

                // Assert
                Assert.Equal(5000, totalCalories);



            }


        }
    }
}



