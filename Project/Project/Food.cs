using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Food
    {
        public string name;
        public int calories;
        public int category;

        public Food(string n, int c, int cat)
        {
            calories = c;
            category = cat;
            name = n;
        }
        
    }
}
