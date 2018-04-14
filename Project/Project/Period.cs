using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    enum PeriodType
    {
        Breakfast, Lunch, Dinner
    }

    class Period
    {
        public PeriodType type;
        public List<Food> foods = new List<Food>();
        public static List<Tuple<Food, Food>> diverse = new List<Tuple<Food, Food>>(); 

        public Period(PeriodType type)
        {
            this.type = type;
        }

        public Dictionary<Tuple<Food, Food>, int> GetDiverse()
        {
            Dictionary<Tuple<Food, Food>, int> d = new Dictionary<Tuple<Food, Food>, int>();
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    int degree = 0;
                    //int degree = a[foods.ElementAt(i).category, foods.ElementAt(j).category];
                    if (degree > 1)
                    {
                        d.Add(new Tuple<Food, Food>(foods.ElementAt(i), foods.ElementAt(j)), degree);
                    }
                }
            }
            return d;
        }

        public int GetCalories()
        {
            int cal = 0;
            foreach (Food f in foods)
            {
                cal += f.calories;
            }
            return 0;
        }
    }
}
