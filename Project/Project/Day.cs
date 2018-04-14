using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Day
    {
        public List<Period> periods = new List<Period>();
        public int coef;

        public int Coef { get; set; }

        public int GetCalories()
        {
            return 0;
        }

        public List<Tuple<Food, Food>> GetDiverse()
        {
            List<Tuple<Food, Food>> diverses = new List<Tuple<Food, Food>>();
            foreach (Period p in periods)
            {
                foreach(Tuple<Food, Food> t in p.GetDiverse())
                {
                    diverses.Add(t);
                }
            }
            return diverses;
        }
    }
}
