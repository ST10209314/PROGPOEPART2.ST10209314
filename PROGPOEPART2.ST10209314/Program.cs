using System;
using PROGPOEPART2.ST10209314.Model;
using PROGPOEPART2.ST10209314.Util;



namespace PROGPOEPART2.ST10209314
{

    // Main class of the program
    class Program
    {

        static void Main(string[] args)


        {
            // Display a welcome message 
            Console.WriteLine(Constants.WELCOME_MESSAGE);

            // Initialize a list to store recipe
            var recipes = new List<Recipe>();


            // This calls the method to show the menu and handle user interaction
            MenuUtil.ShowMenuLoop(recipes);
        }

    }

}