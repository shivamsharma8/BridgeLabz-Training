using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.scenariobased.PersonalizedMealPlan
{
    public class VeganMeal : IMealPlan
    {
        public string MealType()
        {
            return "Vegan";
        }

        public int GetCal()
        {
            return 1600;
        }
        public void DisplayMeal()
        {
            Console.WriteLine("Tofu, Quinoa, Vegetables");
           
        }
    }
}
