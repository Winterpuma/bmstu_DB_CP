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

        #endregion

        #region Страница со списком столовых
        private void LoadBrowseEateryPanel()
        {
            label_browse_username.Text = "Имя пользователя:\n" + currentUser.login;
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
            {
                bindingSource1.Add(m);
            }
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

        
    }
}
