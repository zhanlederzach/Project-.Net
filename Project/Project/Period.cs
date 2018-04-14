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

        public List<Tuple<Food, Food>> GetDiverse()
        {
            return diverse;
        }

        public int GetCalories()
        {
            return 0;
        }
    }
}
