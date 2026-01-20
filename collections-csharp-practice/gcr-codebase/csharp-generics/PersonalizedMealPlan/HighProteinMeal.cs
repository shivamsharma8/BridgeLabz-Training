using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.scenariobased.PersonalizedMealPlan
{
    public class HighProteinMeal : IMealPlan
    {
        public string MealType()
        {
            return "High-Protein Meal";
        }

        public int GetCal()
        {
            return 550;
        }
        public void DisplayMeal()
        {
            Console.WriteLine("Chicken Breast, Beans, Eggs");

        }
    }

}
