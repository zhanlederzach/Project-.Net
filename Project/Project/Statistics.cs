using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Statistics
    {
        private static Statistics instance;
        
        private Statistics()
        {
            Days = new List<Day>();
        }
        
        public static Statistics Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Statistics();
                }
                return instance;
            }
        }
        public List<Day> Days { get; set; }

        public string GetAverageCalories(int days)
        {
            return "";
        }
    }
}
