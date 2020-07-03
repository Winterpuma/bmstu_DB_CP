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
        Eatery currentEatery = null;
        Meal currentMeal = null;
        List<Eatery> currEateries = null;
        List<Meal> currMenu = null;
        List<User> allUsers = null;
        List<DataStructures.Menu> realMenu = null;
        
        public Form1()
        {
            InitializeComponent();
            panel_auth.BringToFront();
            panel_menu_auth.BringToFront();
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
                    button_favorite.Visible = true;
                    panel_menu.BringToFront();
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
                button_dislogin.Visible = true;
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
            mealbindingSource.Clear();
            eateryBindingSource.Clear();
            currentUser = null;
            currMenu = null;
            currEateries = null;
            realMenu = null;
            allUsers = null;
            button_forAdmin.Visible = false;
            button_ruler.Visible = false;
            label_browse_username.Visible = false;
            button_favorite.Visible = false;
            panel_auth.BringToFront();
            panel_menu_auth.BringToFront();
        }
        #endregion


        #region Страница со списком столовых
        private void LoadBrowseEateryPanel()
        {
            mealbindingSource.Clear();
            eateryBindingSource.Clear();
            label_browse_username.Text = "Имя пользователя:\n" + currentUser.login;
            label_browse_username.Visible = true;
            panel_menu.BringToFront();
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
            LoadEateryPanel(currEateries[ind]);
        }

        private void button_browseEatery_filter_Click(object sender, EventArgs e)
        {
            string colName = comboBox_browseEatery.Text;
            string val = textBox_browseEatery_value.Text;
            mealbindingSource.Clear();
            eateryBindingSource.Clear();
            currEateries = GetInfo.GetEateryWhere(connectDB, colName, val);
            foreach (Eatery eat in currEateries)
                eateryBindingSource.Add(eat);
        }

        private void button_browseEateryMenu_goBack_Click(object sender, EventArgs e)
        {
            LoadBrowseEateryPanel();
        }

        private void button_menu_inStock_Click(object sender, EventArgs e)
        {
            menuBindingSource.Clear();
            realMenu = GetInfo.GetMenuState(connectDB, currentEatery.eateryID, "В наличии");
            foreach (DataStructures.Menu m in realMenu)
                menuBindingSource.Add(m);
        }

        private void button_menu_all_Click(object sender, EventArgs e)
        {
            menuBindingSource.Clear();
            realMenu = GetInfo.GetMenu(connectDB, currentEatery.eateryID);
            foreach (DataStructures.Menu m in realMenu)
                menuBindingSource.Add(m);
        }

        private void button_auth_guest_Click(object sender, EventArgs e)
        {
            currentUser = new User("-2", "guest");
            LoadBrowseEateryPanel();
        }

        #endregion


        #region Страница конкретной столовой
        private void LoadEateryPanel(Eatery eatery)
        {
            label_eatery_name.Text = eatery.eateryName;
            label_eatery_location.Text = eatery.location;
            label_eatery_description.Text = eatery.description;
            label_eatery_type.Text = eatery.eateryType;

            currentEatery = eatery;
            /*bindingSource1.Clear();
            currMenu = GetInfo.GetAllMealsOfEatery(connectDB, eatery.eateryID);
            foreach (Meal m in currMenu)
                bindingSource1.Add(m);
            panel_browseEateryMenu.BringToFront();*/
            EateryWasChoosen(eatery.eateryID);
        }


        private void EateryWasChoosen(string eateryID)
        {
            menuBindingSource.Clear();
            realMenu = GetInfo.GetMenu(connectDB, eateryID);
            foreach (DataStructures.Menu m in realMenu)
                menuBindingSource.Add(m);
            panel_browseEateryMenu.BringToFront();
        }


        private void LoadMealClick(object sender, DataGridViewCellEventArgs e)
        {
            int ind = e.RowIndex;

            LoadMealPanel(GetInfo.GetMealByID(connectDB, realMenu[ind].mealID));
        }
        #endregion


        #region Избранные блюда
        private void AddToChoosen(object sender, DataGridViewCellEventArgs e)
        {
            int ind = e.RowIndex;
            Meal m = currMenu[ind];
            InsertInfo.InsertMealChoosen(connectDB, currentUser.userID, m.mealID);
            label_browseEatery_insertInfo.Text = "В личный список добавлено блюдо.";
        }

        private void button_browseEatery_Click(object sender, EventArgs e)
        {
            label_browseEatery_insertInfo.Text = "";
            eateryBindingSource.Clear();
            mealbindingSource.Clear();
            currMenu = GetInfo.GetChoosenMeals(connectDB, currentUser.userID);
            foreach (Meal m in currMenu)
                mealbindingSource.Add(m);
            panel_choosenMeals.BringToFront();
        }

        private void DeleteFromChoosen(object sender, DataGridViewCellEventArgs e)
        {
            int ind = e.RowIndex;
            DeleteInfo.DeleteMealChoosen(connectDB, currentUser.userID, currMenu[ind].mealID);
            mealbindingSource.RemoveAt(ind);
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
            LoadMealPanel(currMenu[ind]);
            panel_mealInfo.BringToFront();
        }

        private void button_favorite_Click(object sender, EventArgs e)
        {
            label_browseEatery_insertInfo.Text = "";
            eateryBindingSource.Clear();
            mealbindingSource.Clear();
            currMenu = GetInfo.GetChoosenMeals(connectDB, currentUser.userID);
            foreach (Meal m in currMenu)
                mealbindingSource.Add(m);
            panel_choosenMeals.BringToFront();
        }
        #endregion


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
       

        #region Страница блюда
        private void LoadMealPanel(Meal m)
        {
            currentMeal = m;

            label_meal_name.Text = m.mealName;
            label_meal_type.Text = m.mealType;
            label_meal_kkal.Text = m.kkal.ToString();
            label_meal_cost.Text = m.cost.ToString();

            eateryBindingSource.Clear();
            currEateries = GetInfo.GetEateryWhereMealIsAvailable(connectDB, m.mealID);
            foreach (Eatery eat in currEateries)
                eateryBindingSource.Add(eat);

            if (CheckInfo.IsMealChoosen(connectDB, currentUser.userID, m.mealID))
            {
                button_meal_deleteChoosen.Visible = true;
                button_meal_addChoosen.Visible = false;
            }
            else
            {
                button_meal_deleteChoosen.Visible = false;
                button_meal_addChoosen.Visible = true;
            }

            panel_mealInfo.BringToFront();
        }

        private void button_meal_addChoosen_Click(object sender, EventArgs e)
        {
            InsertInfo.InsertMealChoosen(connectDB, currentUser.userID, currentMeal.mealID);
            button_meal_addChoosen.Visible = false;
            button_meal_deleteChoosen.Visible = true;
        }

        private void button_meal_deleteChoosen_Click(object sender, EventArgs e)
        {
            DeleteInfo.DeleteMealChoosen(connectDB, currentUser.userID, currentMeal.mealID);
            button_meal_addChoosen.Visible = true;
            button_meal_deleteChoosen.Visible = false;
        }

        /// <summary>
        /// Для изменения блюда
        /// </summary>
        private void button_ruler_Click(object sender, EventArgs e)
        {
            textBox_mealChange_name.Text = currentMeal.mealName.TrimEnd(' ');
            textBox_mealChange_type.Text = currentMeal.mealType.TrimEnd(' ');
            textBox_mealChange_kkal.Text = currentMeal.kkal.ToString();
            textBox_mealChange_cost.Text = currentMeal.cost.ToString();

            panel_meal_dataChange.BringToFront();
            button_cancelMealEdit.Visible = true;
            button_saveMealEdit.Visible = true;
            button_ruler.Visible = false;
        }

        /// <summary>
        /// Отмена изменения блюда
        /// </summary>
        private void FinishEditingMeal(object sender, EventArgs e)
        {
            textBox_mealChange_name.Text = "";
            textBox_mealChange_type.Text = "";
            textBox_mealChange_kkal.Text = "";
            textBox_mealChange_cost.Text = "";

            button_cancelMealEdit.Visible = false;
            button_saveMealEdit.Visible = false;
            button_ruler.Visible = true;

            panel_meal_dataInfo.BringToFront();
        }

        private void button_saveMealEdit_Click(object sender, EventArgs e)
        {
            UpdateInfo.UpdateMeal(connectDB, currentMeal.mealID,
                textBox_mealChange_name.Text,
                textBox_mealChange_type.Text,
                textBox_mealChange_kkal.Text,
                textBox_mealChange_cost.Text);

            label_meal_name.Text = textBox_mealChange_name.Text;
            label_meal_type.Text = textBox_mealChange_type.Text;
            label_meal_kkal.Text = textBox_mealChange_kkal.Text;
            label_meal_cost.Text = textBox_mealChange_cost.Text;
            
            FinishEditingMeal(null, null);
        }
        #endregion
    }
}
