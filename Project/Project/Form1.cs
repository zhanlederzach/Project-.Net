using System;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Storage storage = Storage.Instance;
            storage.OpenConnection();
        }

        Day today = new Day();
        private void btnAddClick(object sender, EventArgs e)
        {
            Storage storage = Storage.Instance;
            string input = textBoxInput.Text;

            Food food = storage.GetFood(input);
            if (food != null)
            {
                if(!radioButtonBreakfast.Checked && !radioButtonLunch.Checked && !radioButtonDinner.Checked)
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
            string s = "";

            string cal  = "Сегодня вы съели " + today.GetCalories() + " калорий";
            string percent = "Это составляет " + today.GetPercent() + " от суточной нормы";
            string foods = "";
            for (int i = 0; i < today.periods.Count; i++)
            {
                int size = today.periods[i].GetDiverse().Count;
                if ( size> 0)
                {
                    foods = "Не стоит употреблять вместе ";
                    for (int j = 0; j < size; j++)
                    {
                        //
                    }
                } 
            }

            string analog = "Вы также можете заменить " + "!" + " на это "+")";
            s = cal + percent + foods + analog;

            listBoxResult.Items.Add(s);
            Statistics st = Statistics.Instance;
            st.Days.Add(today);

            today.periods.Clear();
            listBoxDinner.Items.Clear();
            listBoxBreakfast.Items.Clear();
            listBoxLunch.Items.Clear();
        }

        private void btnCloseClick(object sender, EventArgs e)
        {
            Storage storage = Storage.Instance;
            storage.CloseConnection();
          Application.Exit();
        }
    }
}
