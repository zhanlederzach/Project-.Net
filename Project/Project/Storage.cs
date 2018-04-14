using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Storage
    {
        private static Storage instance;

        private Storage()
        {
            Foods = new List<Food>();
        }

        public static Storage Instance {
            get {
                if (instance == null) {
                    instance = new Storage();
                }
                return instance;
            }
        }

        public List<Food> Foods { get; set; }

        public Food GetFood(string name)
        {
            return Foods.Select(food => food).Where(food => food.name.Contains(name)).Take(1).ToList().ElementAt(0);
        }
    }
}
