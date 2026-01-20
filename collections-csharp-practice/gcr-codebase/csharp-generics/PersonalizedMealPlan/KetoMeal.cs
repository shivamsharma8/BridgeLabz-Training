using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.scenariobased.PersonalizedMealPlan
{
    public class KetoMeal : IMealPlan
    {
        public string MealType()
        {
            return "Keto";
        }

        public int GetCal()
        {
            return 2000;
        }
        public void DisplayMeal()
        {
            Console.WriteLine("Grilled Chicken, Avocado, Eggs");
           
        }
    }
}
