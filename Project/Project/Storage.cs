using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    class Storage
    {
        private static Storage instance;
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();
        private NpgsqlConnection conn;
        private NpgsqlDataAdapter da;

        internal Food GetFood(string name)
        {
            string query = String.Format("select * from food where name='{0}'", name);
            da = new NpgsqlDataAdapter(query, conn);
            da.Fill(ds);

            DataTable d2 = ds.Tables[0];
            Food f = new Food(d2.Rows[0].ItemArray[1].ToString(), (int)d2.Rows[0].ItemArray[2], (int)d2.Rows[0].ItemArray[3]);

            /*var f2 = (Food)ds.Tables[0].AsEnumerable().Select(row => new Food(row.ItemArray[1].ToString(), (int)row.ItemArray[2], 
                (int)row.ItemArray.[3]).Take(1);*/
            return f;
        }

        private Storage()
        {
            Foods = new List<Food>();
        }

        internal void OpenConnection()
        {
            try
            {
                string connstring = "Server=localhost;Port=5432;User Id=postgres;Password=dikachdikach;Database=Foods;";
                conn = new NpgsqlConnection(connstring);
                conn.Open();
                /*
                string sql = "SELECT * FROM people";
                // data adapter making request from our connection
                da = new NpgsqlDataAdapter(sql, conn);
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                */
            }
            catch (Exception msg)
            {
                // something went wrong, and you wanna know why
                MessageBox.Show(msg.ToString());
                throw;
            }
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
        /*
        public Food GetFood(string name)
        {
            return Foods.Select(food => food).Where(food => food.name.Contains(name)).Take(1).ToList().ElementAt(0);
        }*/

        internal void CloseConnection()
        {
            ds.Reset();
            conn.Close();
        }
    }
}
