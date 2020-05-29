namespace DB_CP
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel_auth = new System.Windows.Forms.Panel();
            this.label_auth_res = new System.Windows.Forms.Label();
            this.button_auth_check = new System.Windows.Forms.Button();
            this.textBox_auth_pass = new System.Windows.Forms.TextBox();
            this.textBox_auth_login = new System.Windows.Forms.TextBox();
            this.label_auth_pass = new System.Windows.Forms.Label();
            this.label_auth_login = new System.Windows.Forms.Label();
            this.panel_browseEatery = new System.Windows.Forms.Panel();
            this.label_browseEateryDescription2 = new System.Windows.Forms.Label();
            this.label_browseEateryDescription1 = new System.Windows.Forms.Label();
            this.label_browse_welcome = new System.Windows.Forms.Label();
            this.dataGridView_Eatery = new System.Windows.Forms.DataGridView();
            this.myBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label_browse_username = new System.Windows.Forms.Label();
            this.dataGridView_Meals = new System.Windows.Forms.DataGridView();
            this.label_auth_welcome = new System.Windows.Forms.Label();
            this.button_auth_newUser = new System.Windows.Forms.Button();
            this.panel_newUser = new System.Windows.Forms.Panel();
            this.label_newUser_result = new System.Windows.Forms.Label();
            this.button_newUser_register = new System.Windows.Forms.Button();
            this.textBox_newUser_pass = new System.Windows.Forms.TextBox();
            this.textBox_newUser_login = new System.Windows.Forms.TextBox();
            this.label_newUser_pass = new System.Windows.Forms.Label();
            this.label_newUser_login = new System.Windows.Forms.Label();
            this.label_newUser_pass2 = new System.Windows.Forms.Label();
            this.textBox_newUser_pass2 = new System.Windows.Forms.TextBox();
            this.label_newUser_info = new System.Windows.Forms.Label();
            this.button_newUser_return = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.mealName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mealType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kkal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eateryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eateryType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_auth.SuspendLayout();
            this.panel_browseEatery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Eatery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Meals)).BeginInit();
            this.panel_newUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_auth
            // 
            this.panel_auth.Controls.Add(this.button_auth_newUser);
            this.panel_auth.Controls.Add(this.label_auth_welcome);
            this.panel_auth.Controls.Add(this.label_auth_res);
            this.panel_auth.Controls.Add(this.button_auth_check);
            this.panel_auth.Controls.Add(this.textBox_auth_pass);
            this.panel_auth.Controls.Add(this.textBox_auth_login);
            this.panel_auth.Controls.Add(this.label_auth_pass);
            this.panel_auth.Controls.Add(this.label_auth_login);
            this.panel_auth.Location = new System.Drawing.Point(19, 12);
            this.panel_auth.Name = "panel_auth";
            this.panel_auth.Size = new System.Drawing.Size(630, 381);
            this.panel_auth.TabIndex = 0;
            // 
            // label_auth_res
            // 
            this.label_auth_res.AutoSize = true;
            this.label_auth_res.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_auth_res.Location = new System.Drawing.Point(209, 314);
            this.label_auth_res.Name = "label_auth_res";
            this.label_auth_res.Size = new System.Drawing.Size(58, 13);
            this.label_auth_res.TabIndex = 5;
            this.label_auth_res.Text = "результат";
            this.label_auth_res.Visible = false;
            // 
            // button_auth_check
            // 
            this.button_auth_check.Location = new System.Drawing.Point(209, 254);
            this.button_auth_check.Name = "button_auth_check";
            this.button_auth_check.Size = new System.Drawing.Size(75, 23);
            this.button_auth_check.TabIndex = 4;
            this.button_auth_check.Text = "Войти";
            this.button_auth_check.UseVisualStyleBackColor = true;
            this.button_auth_check.Click += new System.EventHandler(this.button_auth_check_Click);
            // 
            // textBox_auth_pass
            // 
            this.textBox_auth_pass.Location = new System.Drawing.Point(209, 193);
            this.textBox_auth_pass.Name = "textBox_auth_pass";
            this.textBox_auth_pass.PasswordChar = '*';
            this.textBox_auth_pass.Size = new System.Drawing.Size(100, 20);
            this.textBox_auth_pass.TabIndex = 3;
            // 
            // textBox_auth_login
            // 
            this.textBox_auth_login.Location = new System.Drawing.Point(209, 142);
            this.textBox_auth_login.Name = "textBox_auth_login";
            this.textBox_auth_login.Size = new System.Drawing.Size(100, 20);
            this.textBox_auth_login.TabIndex = 2;
            // 
            // label_auth_pass
            // 
            this.label_auth_pass.AutoSize = true;
            this.label_auth_pass.Location = new System.Drawing.Point(130, 196);
            this.label_auth_pass.Name = "label_auth_pass";
            this.label_auth_pass.Size = new System.Drawing.Size(48, 13);
            this.label_auth_pass.TabIndex = 1;
            this.label_auth_pass.Text = "Пароль:";
            // 
            // label_auth_login
            // 
            this.label_auth_login.AutoSize = true;
            this.label_auth_login.Location = new System.Drawing.Point(137, 149);
            this.label_auth_login.Name = "label_auth_login";
            this.label_auth_login.Size = new System.Drawing.Size(41, 13);
            this.label_auth_login.TabIndex = 0;
            this.label_auth_login.Text = "Логин:";
            // 
            // panel_browseEatery
            // 
            this.panel_browseEatery.Controls.Add(this.label_browseEateryDescription2);
            this.panel_browseEatery.Controls.Add(this.label_browseEateryDescription1);
            this.panel_browseEatery.Controls.Add(this.label_browse_welcome);
            this.panel_browseEatery.Controls.Add(this.dataGridView_Meals);
            this.panel_browseEatery.Controls.Add(this.dataGridView_Eatery);
            this.panel_browseEatery.Controls.Add(this.label_browse_username);
            this.panel_browseEatery.Location = new System.Drawing.Point(30, 424);
            this.panel_browseEatery.Name = "panel_browseEatery";
            this.panel_browseEatery.Size = new System.Drawing.Size(971, 381);
            this.panel_browseEatery.TabIndex = 6;
            // 
            // label_browseEateryDescription2
            // 
            this.label_browseEateryDescription2.AutoSize = true;
            this.label_browseEateryDescription2.Location = new System.Drawing.Point(39, 145);
            this.label_browseEateryDescription2.Name = "label_browseEateryDescription2";
            this.label_browseEateryDescription2.Size = new System.Drawing.Size(415, 13);
            this.label_browseEateryDescription2.TabIndex = 11;
            this.label_browseEateryDescription2.Text = "Чтобы посмотреть меню конкретной столовой дважды нажмите на нужный ряд";
            // 
            // label_browseEateryDescription1
            // 
            this.label_browseEateryDescription1.AutoSize = true;
            this.label_browseEateryDescription1.Location = new System.Drawing.Point(39, 111);
            this.label_browseEateryDescription1.Name = "label_browseEateryDescription1";
            this.label_browseEateryDescription1.Size = new System.Drawing.Size(284, 13);
            this.label_browseEateryDescription1.TabIndex = 9;
            this.label_browseEateryDescription1.Text = "Ниже представлен список  всех доступных столовых. ";
            // 
            // label_browse_welcome
            // 
            this.label_browse_welcome.AutoSize = true;
            this.label_browse_welcome.Location = new System.Drawing.Point(48, 50);
            this.label_browse_welcome.Name = "label_browse_welcome";
            this.label_browse_welcome.Size = new System.Drawing.Size(158, 13);
            this.label_browse_welcome.TabIndex = 5;
            this.label_browse_welcome.Text = "Добро пожаловать в систему";
            // 
            // dataGridView_Eatery
            // 
            this.dataGridView_Eatery.AutoGenerateColumns = false;
            this.dataGridView_Eatery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Eatery.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eateryName,
            this.location,
            this.eateryType,
            this.description});
            this.dataGridView_Eatery.DataSource = this.myBindingSource;
            this.dataGridView_Eatery.Location = new System.Drawing.Point(42, 158);
            this.dataGridView_Eatery.Name = "dataGridView_Eatery";
            this.dataGridView_Eatery.Size = new System.Drawing.Size(445, 159);
            this.dataGridView_Eatery.TabIndex = 8;
            this.dataGridView_Eatery.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Eatery_CellDoubleClick);
            // 
            // myBindingSource
            // 
            this.myBindingSource.DataSource = typeof(DataStructures.Eatery);
            // 
            // label_browse_username
            // 
            this.label_browse_username.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_browse_username.AutoSize = true;
            this.label_browse_username.Location = new System.Drawing.Point(852, 41);
            this.label_browse_username.Name = "label_browse_username";
            this.label_browse_username.Size = new System.Drawing.Size(29, 13);
            this.label_browse_username.TabIndex = 0;
            this.label_browse_username.Text = "login";
            this.label_browse_username.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridView_Meals
            // 
            this.dataGridView_Meals.AutoGenerateColumns = false;
            this.dataGridView_Meals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Meals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mealName,
            this.mealType,
            this.kkal,
            this.cost});
            this.dataGridView_Meals.DataSource = this.bindingSource1;
            this.dataGridView_Meals.Location = new System.Drawing.Point(507, 158);
            this.dataGridView_Meals.Name = "dataGridView_Meals";
            this.dataGridView_Meals.Size = new System.Drawing.Size(448, 159);
            this.dataGridView_Meals.TabIndex = 9;
            // 
            // label_auth_welcome
            // 
            this.label_auth_welcome.AutoSize = true;
            this.label_auth_welcome.Location = new System.Drawing.Point(45, 58);
            this.label_auth_welcome.Name = "label_auth_welcome";
            this.label_auth_welcome.Size = new System.Drawing.Size(104, 13);
            this.label_auth_welcome.TabIndex = 6;
            this.label_auth_welcome.Text = "Добро пожаловать";
            // 
            // button_auth_newUser
            // 
            this.button_auth_newUser.Location = new System.Drawing.Point(459, 329);
            this.button_auth_newUser.Name = "button_auth_newUser";
            this.button_auth_newUser.Size = new System.Drawing.Size(143, 23);
            this.button_auth_newUser.TabIndex = 7;
            this.button_auth_newUser.Text = "Новый пользователь";
            this.button_auth_newUser.UseVisualStyleBackColor = true;
            this.button_auth_newUser.Click += new System.EventHandler(this.button_auth_newUser_Click);
            // 
            // panel_newUser
            // 
            this.panel_newUser.Controls.Add(this.button_newUser_return);
            this.panel_newUser.Controls.Add(this.label_newUser_info);
            this.panel_newUser.Controls.Add(this.textBox_newUser_pass2);
            this.panel_newUser.Controls.Add(this.label_newUser_pass2);
            this.panel_newUser.Controls.Add(this.label_newUser_result);
            this.panel_newUser.Controls.Add(this.button_newUser_register);
            this.panel_newUser.Controls.Add(this.textBox_newUser_pass);
            this.panel_newUser.Controls.Add(this.textBox_newUser_login);
            this.panel_newUser.Controls.Add(this.label_newUser_pass);
            this.panel_newUser.Controls.Add(this.label_newUser_login);
            this.panel_newUser.Location = new System.Drawing.Point(0, 32);
            this.panel_newUser.Name = "panel_newUser";
            this.panel_newUser.Size = new System.Drawing.Size(630, 381);
            this.panel_newUser.TabIndex = 8;
            // 
            // label_newUser_result
            // 
            this.label_newUser_result.AutoSize = true;
            this.label_newUser_result.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_newUser_result.Location = new System.Drawing.Point(209, 314);
            this.label_newUser_result.Name = "label_newUser_result";
            this.label_newUser_result.Size = new System.Drawing.Size(58, 13);
            this.label_newUser_result.TabIndex = 5;
            this.label_newUser_result.Text = "результат";
            this.label_newUser_result.Visible = false;
            // 
            // button_newUser_register
            // 
            this.button_newUser_register.Location = new System.Drawing.Point(209, 254);
            this.button_newUser_register.Name = "button_newUser_register";
            this.button_newUser_register.Size = new System.Drawing.Size(125, 23);
            this.button_newUser_register.TabIndex = 4;
            this.button_newUser_register.Text = "Зарегестрироваться";
            this.button_newUser_register.UseVisualStyleBackColor = true;
            this.button_newUser_register.Click += new System.EventHandler(this.button_newUser_register_Click);
            // 
            // textBox_newUser_pass
            // 
            this.textBox_newUser_pass.Location = new System.Drawing.Point(209, 193);
            this.textBox_newUser_pass.Name = "textBox_newUser_pass";
            this.textBox_newUser_pass.PasswordChar = '*';
            this.textBox_newUser_pass.Size = new System.Drawing.Size(125, 20);
            this.textBox_newUser_pass.TabIndex = 3;
            // 
            // textBox_newUser_login
            // 
            this.textBox_newUser_login.Location = new System.Drawing.Point(209, 142);
            this.textBox_newUser_login.Name = "textBox_newUser_login";
            this.textBox_newUser_login.Size = new System.Drawing.Size(125, 20);
            this.textBox_newUser_login.TabIndex = 2;
            // 
            // label_newUser_pass
            // 
            this.label_newUser_pass.AutoSize = true;
            this.label_newUser_pass.Location = new System.Drawing.Point(130, 196);
            this.label_newUser_pass.Name = "label_newUser_pass";
            this.label_newUser_pass.Size = new System.Drawing.Size(48, 13);
            this.label_newUser_pass.TabIndex = 1;
            this.label_newUser_pass.Text = "Пароль:";
            // 
            // label_newUser_login
            // 
            this.label_newUser_login.AutoSize = true;
            this.label_newUser_login.Location = new System.Drawing.Point(137, 149);
            this.label_newUser_login.Name = "label_newUser_login";
            this.label_newUser_login.Size = new System.Drawing.Size(41, 13);
            this.label_newUser_login.TabIndex = 0;
            this.label_newUser_login.Text = "Логин:";
            // 
            // label_newUser_pass2
            // 
            this.label_newUser_pass2.AutoSize = true;
            this.label_newUser_pass2.Location = new System.Drawing.Point(124, 220);
            this.label_newUser_pass2.Name = "label_newUser_pass2";
            this.label_newUser_pass2.Size = new System.Drawing.Size(54, 13);
            this.label_newUser_pass2.TabIndex = 6;
            this.label_newUser_pass2.Text = "Пароль2:";
            // 
            // textBox_newUser_pass2
            // 
            this.textBox_newUser_pass2.Location = new System.Drawing.Point(209, 217);
            this.textBox_newUser_pass2.Name = "textBox_newUser_pass2";
            this.textBox_newUser_pass2.PasswordChar = '*';
            this.textBox_newUser_pass2.Size = new System.Drawing.Size(125, 20);
            this.textBox_newUser_pass2.TabIndex = 7;
            // 
            // label_newUser_info
            // 
            this.label_newUser_info.AutoSize = true;
            this.label_newUser_info.Location = new System.Drawing.Point(92, 98);
            this.label_newUser_info.Name = "label_newUser_info";
            this.label_newUser_info.Size = new System.Drawing.Size(242, 13);
            this.label_newUser_info.TabIndex = 8;
            this.label_newUser_info.Text = "Для регистрации заполните следующие поля:";
            // 
            // button_newUser_return
            // 
            this.button_newUser_return.Location = new System.Drawing.Point(19, 31);
            this.button_newUser_return.Name = "button_newUser_return";
            this.button_newUser_return.Size = new System.Drawing.Size(75, 23);
            this.button_newUser_return.TabIndex = 9;
            this.button_newUser_return.Text = "Вернуться";
            this.button_newUser_return.UseVisualStyleBackColor = true;
            this.button_newUser_return.Click += new System.EventHandler(this.button_newUser_return_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(DataStructures.Meal);
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataSource = typeof(DataStructures.User);
            // 
            // mealName
            // 
            this.mealName.DataPropertyName = "mealName";
            this.mealName.HeaderText = "mealName";
            this.mealName.Name = "mealName";
            this.mealName.ReadOnly = true;
            // 
            // mealType
            // 
            this.mealType.DataPropertyName = "mealType";
            this.mealType.HeaderText = "mealType";
            this.mealType.Name = "mealType";
            this.mealType.ReadOnly = true;
            // 
            // kkal
            // 
            this.kkal.DataPropertyName = "kkal";
            this.kkal.HeaderText = "kkal";
            this.kkal.Name = "kkal";
            this.kkal.ReadOnly = true;
            // 
            // cost
            // 
            this.cost.DataPropertyName = "cost";
            this.cost.HeaderText = "cost";
            this.cost.Name = "cost";
            this.cost.ReadOnly = true;
            // 
            // eateryName
            // 
            this.eateryName.DataPropertyName = "eateryName";
            this.eateryName.HeaderText = "eateryName";
            this.eateryName.Name = "eateryName";
            this.eateryName.ReadOnly = true;
            // 
            // location
            // 
            this.location.DataPropertyName = "location";
            this.location.HeaderText = "location";
            this.location.Name = "location";
            this.location.ReadOnly = true;
            // 
            // eateryType
            // 
            this.eateryType.DataPropertyName = "eateryType";
            this.eateryType.HeaderText = "eateryType";
            this.eateryType.Name = "eateryType";
            this.eateryType.ReadOnly = true;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "description";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 782);
            this.Controls.Add(this.panel_newUser);
            this.Controls.Add(this.panel_browseEatery);
            this.Controls.Add(this.panel_auth);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel_auth.ResumeLayout(false);
            this.panel_auth.PerformLayout();
            this.panel_browseEatery.ResumeLayout(false);
            this.panel_browseEatery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Eatery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Meals)).EndInit();
            this.panel_newUser.ResumeLayout(false);
            this.panel_newUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_auth;
        private System.Windows.Forms.Button button_auth_check;
        private System.Windows.Forms.TextBox textBox_auth_pass;
        private System.Windows.Forms.TextBox textBox_auth_login;
        private System.Windows.Forms.Label label_auth_pass;
        private System.Windows.Forms.Label label_auth_login;
        private System.Windows.Forms.Label label_auth_res;
        private System.Windows.Forms.Panel panel_browseEatery;
        private System.Windows.Forms.Label label_browse_welcome;
        private System.Windows.Forms.Label label_browse_username;
        private System.Windows.Forms.DataGridView dataGridView_Eatery;
        private System.Windows.Forms.BindingSource myBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn eateryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView_Meals;
        private System.Windows.Forms.Label label_browseEateryDescription1;
        private System.Windows.Forms.Label label_browseEateryDescription2;
        private System.Windows.Forms.Button button_auth_newUser;
        private System.Windows.Forms.Label label_auth_welcome;
        private System.Windows.Forms.Panel panel_newUser;
        private System.Windows.Forms.Label label_newUser_info;
        private System.Windows.Forms.TextBox textBox_newUser_pass2;
        private System.Windows.Forms.Label label_newUser_pass2;
        private System.Windows.Forms.Label label_newUser_result;
        private System.Windows.Forms.Button button_newUser_register;
        private System.Windows.Forms.TextBox textBox_newUser_pass;
        private System.Windows.Forms.TextBox textBox_newUser_login;
        private System.Windows.Forms.Label label_newUser_pass;
        private System.Windows.Forms.Label label_newUser_login;
        private System.Windows.Forms.Button button_newUser_return;
        private System.Windows.Forms.DataGridViewTextBoxColumn mealName;
        private System.Windows.Forms.DataGridViewTextBoxColumn mealType;
        private System.Windows.Forms.DataGridViewTextBoxColumn kkal;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn eateryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn location;
        private System.Windows.Forms.DataGridViewTextBoxColumn eateryType;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.BindingSource bindingSource2;
    }
}

