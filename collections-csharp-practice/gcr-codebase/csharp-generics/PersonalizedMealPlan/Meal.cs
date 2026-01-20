using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.scenariobased.PersonalizedMealPlan
{
    public class Meal<T> where T : IMealPlan
    {
        private T mealPlan;

        public Meal(T mealPlan)
        {
            this.mealPlan = mealPlan;
        }

        public void ShowMealDetails()
        {
            mealPlan.DisplayMeal();
        }
    }
}
