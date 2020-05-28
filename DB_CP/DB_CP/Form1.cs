using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccessToDB;
using DataStructures;


using System.Data.SqlClient;

namespace DB_CP
{
    public partial class Form1 : Form
    {
        Connector connectDB = new Connector();
        List<Eatery> currEateries = null;
        List<Meal> currMenu = null;
        
        public Form1()
        {
            InitializeComponent();
            panel_auth.BringToFront();
            //CreateMyListView();
            //listView1.Columns.Add("ProductName", 100);
            
            //Form1_Load();
        }
        

        private void button_auth_check_Click(object sender, EventArgs e)
        {
            string login = textBox_auth_login.Text;
            string pass = textBox_auth_pass.Text;

            bool taken = CheckInfo.IsLoginTaken(connectDB, login);
            if (taken)
            {
                User u = GetInfo.GetUserByLogin(connectDB, login, pass);
                if (u == null)
                {
                    label_auth_res.Text = "Wrong password";
                    label_auth_res.Visible = true;
                }
                else
                {
                    label_auth_res.Visible = false;
                    LoadBrowseEateryPanel(u.login);
                }
            }
            else
            {
                label_auth_res.Text = "No such login";
                label_auth_res.Visible = true;
            }
        }

        #region Страница со списком столовых
        private void LoadBrowseEateryPanel(string login)
        {
            label_browse_username.Text = "Имя пользователя:\n" + login;
            panel_browseEatery.BringToFront();
            currEateries = GetInfo.GetAllEatery(connectDB);
            foreach (Eatery eat in currEateries)
            {
                eateryBindingSource.Add(eat);
            }
        }

        private void dataGridView_Eatery_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int ind = e.RowIndex;
            LoadBrowseEateryMenuPanel(currEateries[ind]);
        }
        #endregion

        private void LoadBrowseEateryMenuPanel(Eatery eatery)
        {
            /*currMenu = GetInfo.GetAllMealsOfEatery(connectDB, eateryID);
            foreach (Meal m in currMenu)
            {
                //mealBindingSource.Add(m);
            }*/
            MDA(eatery);
            panel_browseEateryMenu.BringToFront();
        }

        private void MDA(Eatery eatery)
        {
            string sqlCommand = "select Meal.mealID, mealName, mealType, kkal, cost " +
                "from Menu join Meal on Menu.MealID = Meal.mealID " +
                "where eateryID = '" + eatery.eateryID + "'";
            string connectionString = "Server=LAPTOP-HJHG4ROO\\HM;Database=DB_CP;Integrated Security=true;";
            var connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sqlCommand, connection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;

            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            adapter.Fill(table);
            dataGridView_Meals.DataSource = table;

            label_EateryMealsEateryInfo_type.Text = eatery.eateryType + " в " + eatery.location;
            label_EateryMealsEateryInfo_name.Text = eatery.eateryName;
            label_EateryMealsEateryInfo_description.Text = eatery.description;
        }
    }
}
