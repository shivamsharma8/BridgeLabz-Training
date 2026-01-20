using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.scenariobased.PersonalizedMealPlan
{
    public class VegetarianMeal : IMealPlan
    {
        public string MealType()
        {
            return "Vegetarian";
        }

        public int GetCal()
        {
            return 1800;
        }
        public void DisplayMeal()
        {
            Console.WriteLine( "Paneer, Rice, Salad");
        }
    }
}
