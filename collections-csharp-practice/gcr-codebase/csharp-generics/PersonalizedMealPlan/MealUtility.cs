using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.scenariobased.PersonalizedMealPlan
{
    internal class MealUtility
    {
        public static void GenerateMealPlan<T>(T meal) where T : IMealPlan
        {
            Console.WriteLine("\nValidating Meal Plan...");

            if (meal.GetCal() < 300 || meal.GetCal() > 2000)
            {
                Console.WriteLine("Invalid Meal Plan (Calories out of range)");
                return;
            }

            Console.WriteLine("Meal Plan Validated Successfully!");
            Meal<T> userMeal = new Meal<T>(meal);
            userMeal.ShowMealDetails();
        }
    }
}
