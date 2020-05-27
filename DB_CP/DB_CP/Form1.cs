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

        private void Form1_Load()
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            //Add column header
            listView1.Columns.Add("ProductName", 100);
            listView1.Columns.Add("Price", 70);
            listView1.Columns.Add("Quantity", 70);

            //Add items in the listview
            string[] arr = new string[4];
            ListViewItem itm;

            //Add first item
            arr[0] = "product_1";
            arr[1] = "100";
            arr[2] = "10";
            itm = new ListViewItem(arr);
            listView1.Items.Add(itm);

            //Add second item
            arr[0] = "product_2";
            arr[1] = "200";
            arr[2] = "20";
            itm = new ListViewItem(arr);
            listView1.Items.Add(itm);

            
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
            label_browse_username.Text = login;
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
            LoadBrowseEateryMenuPanel(currEateries[ind].eateryID);
        }
        #endregion

        private void LoadBrowseEateryMenuPanel(string eateryID)
        {
            /*currMenu = GetInfo.GetAllMealsOfEatery(connectDB, eateryID);
            foreach (Meal m in currMenu)
            {
                //mealBindingSource.Add(m);
            }*/
            MDA(eateryID);
            panel_browseEateryMenu.BringToFront();
        }

        private void MDA(string EateryID)
        {
            string sqlCommand = "select Meal.mealID, mealName, mealType, kkal, cost " +
                "from Menu join Meal on Menu.MealID = Meal.mealID " +
                "where eateryID = '" + EateryID + "'";
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
