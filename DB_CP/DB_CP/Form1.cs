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
        User currentUser = null;
        List<Eatery> currEateries = null;
        List<Meal> currMenu = null;
        List<User> allUsers = null;
        List<DataStructures.Menu> realMenu = null;
        
        public Form1()
        {
            InitializeComponent();
            panel_auth.BringToFront();
            
        }

        #region Авторизация

        /// <summary>
        /// Вызывается при нажатии на кнопку авторизации
        /// </summary>
        private void button_auth_check_Click(object sender, EventArgs e)
        {
            string login = textBox_auth_login.Text;
            string pass = Program.sha256_hash(textBox_auth_pass.Text);
            textBox_auth_pass.Text = ""; // сброс пароля

            bool taken = CheckInfo.IsLoginTaken(connectDB, login);
            if (taken)
            {
                currentUser = GetInfo.GetUserByLogin(connectDB, login, pass);
                if (currentUser == null)
                {
                    label_auth_res.Text = "Неправильный пароль";
                    label_auth_res.Visible = true;
                }
                else
                {
                    label_auth_res.Visible = false;
                    button_dislogin.Visible = true;
                    CheckPerms();
                    LoadBrowseEateryPanel();
                }
            }
            else
            {
                label_auth_res.Text = "Такого пользователя не существует";
                label_auth_res.Visible = true;
            }
        }

        private void button_auth_newUser_Click(object sender, EventArgs e)
        {
            textBox_auth_pass.Text = "";
            label_auth_res.Visible = false;
            panel_newUser.BringToFront();
        }

        private void button_newUser_register_Click(object sender, EventArgs e)
        {
            if (CheckInfo.IsLoginTaken(connectDB, textBox_newUser_login.Text))
            {
                label_newUser_result.Text = "Такой логин занят";
                label_newUser_result.Visible = true;
            }
            else if (textBox_newUser_pass.Text != textBox_newUser_pass2.Text)
            {
                label_newUser_result.Text = "Пароли не совпадают";
                label_newUser_result.Visible = true;
            }
            else
            {
                label_newUser_result.Visible = false;
                var login = textBox_newUser_login.Text;
                var pass = Program.sha256_hash(textBox_newUser_pass.Text);
                InsertInfo.InsertUser(connectDB, login, pass);
                currentUser = GetInfo.GetUserByLogin(connectDB, login, pass);
                LoadBrowseEateryPanel();
            }
        }

        private void button_newUser_return_Click(object sender, EventArgs e)
        {
            label_newUser_result.Text = "";
            label_newUser_result.Visible = false;
            textBox_newUser_login.Text = "";
            textBox_newUser_pass.Text = "";
            textBox_newUser_pass2.Text = "";
            panel_auth.BringToFront();
        }

        private void CheckPerms()
        {
            if (currentUser.permission == 0)
            {
                button_forAdmin.Visible = true;
                button_ruler.Visible = true;
            }
            else if (currentUser.permission == 1)
            {
                button_ruler.Visible = true;
            }
            button_dislogin.Visible = true;
        }

        private void button_dislogin_Click(object sender, EventArgs e)
        {
            bindingSource1.Clear();
            myBindingSource.Clear();
            currentUser = null;
            currMenu = null;
            currEateries = null;
            realMenu = null;
            allUsers = null;
            button_dislogin.Visible = false;
            button_forAdmin.Visible = false;
            button_ruler.Visible = false;
            label_browse_username.Visible = false;
            panel_auth.BringToFront();
        }
        #endregion

        #region Страница со списком столовых
        private void LoadBrowseEateryPanel()
        {
            bindingSource1.Clear();
            myBindingSource.Clear();
            label_browse_username.Text = "Имя пользователя:\n" + currentUser.login;
            label_browse_username.Visible = true;
            panel_browseEatery.BringToFront();
            currEateries = GetInfo.GetAllEatery(connectDB);
            foreach (Eatery eat in currEateries)
            {
                myBindingSource.Add(eat);
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
            bindingSource1.Clear();
            currMenu = GetInfo.GetAllMealsOfEatery(connectDB, eatery.eateryID);
            foreach (Meal m in currMenu)
                bindingSource1.Add(m);
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
        }

        private void button_browseEatery_filter_Click(object sender, EventArgs e)
        {
            string colName = comboBox_browseEatery.Text;
            string val = textBox_browseEatery_value.Text;
            bindingSource1.Clear(); // очистить блюда
            myBindingSource.Clear(); // очистить питальни
            currEateries = GetInfo.GetEateryWhere(connectDB, colName, val);
            foreach (Eatery eat in currEateries)
                myBindingSource.Add(eat);
        }

        private void dataGridView_Meals_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int ind = e.RowIndex;
            Meal m = currMenu[ind];
            InsertInfo.InsertMealChoosen(connectDB, currentUser.userID, m.mealID);
            label_browseEatery_insertInfo.Text = "В личный список добавлено блюдо.";
        }

        private void button_browseEatery_Click(object sender, EventArgs e)
        {
            label_browseEatery_insertInfo.Text = "";
            myBindingSource.Clear();
            bindingSource1.Clear();
            currMenu = GetInfo.GetChoosenMeals(connectDB, currentUser.userID);
            foreach (Meal m in currMenu)
                bindingSource1.Add(m);
            panel_choosenMeals.BringToFront();
        }

        private void dataGridView_choosenMeals_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int ind = e.RowIndex;
            DeleteInfo.DeleteMealChoosen(connectDB, currentUser.userID, currMenu[ind].mealID);
            bindingSource1.RemoveAt(ind);
            currMenu.RemoveAt(ind);
        }

        private void button_choosenMeals_Click(object sender, EventArgs e)
        {
            LoadBrowseEateryPanel();
            panel_browseEatery.BringToFront();
        }

        private void dataGridView_choosenMeals_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ind = e.RowIndex;
            currEateries = GetInfo.GetEateryWhereMealIsAvailable(connectDB, currMenu[ind].mealID);
            foreach (Eatery eat in currEateries)
                myBindingSource.Add(eat);
        }


        #region Admin
        private void adminUsersLoad()
        {
            bindingSource2.Clear();
            allUsers = GetInfo.GetAllUsers(connectDB);
            foreach (User u in allUsers)
                bindingSource2.Add(u);
        }

        private void button_forAdmin_Click(object sender, EventArgs e)
        {
            adminUsersLoad();
            panel_admin.BringToFront();
        }

        private void button_admin_back_Click(object sender, EventArgs e)
        {
            bindingSource2.Clear();
            panel_browseEatery.BringToFront();
        }

        private void dataGridView_usersForAdmin_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int ind = e.RowIndex;
            User u = allUsers[ind];
            string newRole = "";

            if (e.ColumnIndex == 2)
                newRole = "-1";
            else if (e.ColumnIndex == 3)
                newRole = "1";
            else if (e.ColumnIndex == 4)
                newRole = "0";
            else
                return;

            UpdateInfo.UpdateUserPermissions(connectDB, u.userID, newRole);
            adminUsersLoad();
        }
        #endregion

        private void dataGridView_eateryRuler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            menuBindingSource.Clear();
            int ind = e.RowIndex;
            realMenu = GetInfo.GetMenu(connectDB, currEateries[ind].eateryID);
            foreach (DataStructures.Menu m in realMenu)
                menuBindingSource.Add(m);
        }

        private void LoadRulerEateries()
        {
            myBindingSource.Clear();
            currEateries = GetInfo.GetAllEatery(connectDB);
            foreach (Eatery eat in currEateries)
                myBindingSource.Add(eat);
        }

        private void button_ruler_Click(object sender, EventArgs e)
        {
            LoadRulerEateries();
            panel_ruler.BringToFront();
        }

        private void button_ruler_goBack_Click(object sender, EventArgs e)
        {
            myBindingSource.Clear();
            menuBindingSource.Clear();
            panel_browseEatery.BringToFront();
        }
    }
}
