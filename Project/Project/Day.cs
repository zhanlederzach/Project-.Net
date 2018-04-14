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
        
        public int GetCalories()
        {
            int cal = 0;
            for (int i = 0; i < periods.Count; i++)
            {
                cal += periods.ElementAt(i).GetCalories();
            }

            return cal;
        }

        public string GetPercent()
        {
            return GetCalories() * 100 / 2500 + "%";
        }

        public string GetMotivation()
        {
            string motivation="";
            if (coef > 1) motivation = "Молодчинка!";
            else if (coef < 1) motivation = "Ну постарайся еще, жируха уахахах";
            else if (coef == 0)
            {
                return "";
            }
            return motivation;
        }
    }
}
