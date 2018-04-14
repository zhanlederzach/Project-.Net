using System;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Day today = new Day();
        private void btnAddClick(object sender, EventArgs e)
        {
            
            Storage storage = Storage.Instance;

            Food f = new Food();
            f.calories = 20;
            f.name = "egg";
            f.category = 1; storage.Foods.Add(f);

            Food f2 = new Food();
            f2.calories = 20;
            f2.name = "meat";
            f2.category = 2; storage.Foods.Add(f2);

            Food f3 = new Food();
            f3.calories = 20;
            f3.name = "fish";
            f3.category = 3; storage.Foods.Add(f3);

            string input = textBoxInput.Text;

            Food food = storage.GetFood(input);
            if (food != null)
            {
                if (radioButtonBreakfast.Checked)
                {
                    Period breakfast = new Period(PeriodType.Breakfast);
                    breakfast.foods.Add(food);
                    listBoxBreakfast.Items.Add(food.name);            
                    today.periods.Add(breakfast);
                }
                else if (radioButtonLunch.Checked)
                {
                    Period lunch = new Period(PeriodType.Lunch);
                    lunch.foods.Add(food);
                    listBoxLunch.Items.Add(food.name);
                    today.periods.Add(lunch);
                }
                else if (radioButtonDinner.Checked)
                {
                    Period dinner = new Period(PeriodType.Dinner);
                    dinner.foods.Add(food);
                    listBoxDinner.Items.Add(food.name);
                    today.periods.Add(dinner);
                }
                textBoxInput.Text = "";
            }

        }

        private void btnAnalyzeClick(object sender, EventArgs e)
        {
            foreach(Period d in today.periods)
            {
                listBoxResult.Items.Add(d.type+" " + d.foods);
            }

            Statistics st = Statistics.Instance;
            st.Days.Add(today);

            today.periods.Clear();
            listBoxDinner.Items.Clear();
            listBoxBreakfast.Items.Clear();
            listBoxLunch.Items.Clear();
            
        }
    }
}
