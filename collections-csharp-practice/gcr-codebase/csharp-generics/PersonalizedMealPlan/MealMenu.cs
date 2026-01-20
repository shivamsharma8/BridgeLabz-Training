using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.scenariobased.PersonalizedMealPlan
{
    public class MealMenu
    {
        public static void Start()
        {
            while (true)
            {
                Console.WriteLine("1. Vegetarian");
                Console.WriteLine("2. Vegan");
                Console.WriteLine("3. Keto");
                Console.WriteLine("4. High Protein");
                Console.WriteLine("5. Exit");

                int ch = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch (ch)
                {
                    case 1:
                        MealUtility.GenerateMealPlan(new VegetarianMeal());
                        break;

                    case 2:
                        MealUtility.GenerateMealPlan(new VeganMeal());
                        break;

                    case 3:
                        MealUtility.GenerateMealPlan(new KetoMeal());
                        break;

                    case 4:
                        MealUtility.GenerateMealPlan(new HighProteinMeal());
                        break;

                    case 5:
                        return;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }

}
