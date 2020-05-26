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

namespace DB_CP
{
    public partial class Form1 : Form
    {
        Connector connectDB = new Connector();
        
        public Form1()
        {
            InitializeComponent();
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
                    button_auth_check.BackColor = Color.Red;
                else
                    button_auth_check.BackColor = Color.Green;
            }
            else
                button_auth_check.BackColor = Color.Orange;
        }
    }
}
