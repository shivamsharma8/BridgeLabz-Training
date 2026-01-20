using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.scenariobased.PersonalizedMealPlan
{
    public interface IMealPlan
    {
        string MealType();
        int GetCal();
        void DisplayMeal();
    }
}
