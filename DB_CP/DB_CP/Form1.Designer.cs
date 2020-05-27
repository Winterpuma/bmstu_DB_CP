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
            this.label_browse_welcome = new System.Windows.Forms.Label();
            this.dataGridView_Eatery = new System.Windows.Forms.DataGridView();
            this.eateryType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_browse_username = new System.Windows.Forms.Label();
            this.panel_browseEateryMenu = new System.Windows.Forms.Panel();
            this.dataGridView_Meals = new System.Windows.Forms.DataGridView();
            this.eateryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eateryTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eateryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel_auth.SuspendLayout();
            this.panel_browseEatery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Eatery)).BeginInit();
            this.panel_browseEateryMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Meals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eateryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_auth
            // 
            this.panel_auth.Controls.Add(this.label_auth_res);
            this.panel_auth.Controls.Add(this.button_auth_check);
            this.panel_auth.Controls.Add(this.textBox_auth_pass);
            this.panel_auth.Controls.Add(this.textBox_auth_login);
            this.panel_auth.Controls.Add(this.label_auth_pass);
            this.panel_auth.Controls.Add(this.label_auth_login);
            this.panel_auth.Location = new System.Drawing.Point(12, 12);
            this.panel_auth.Name = "panel_auth";
            this.panel_auth.Size = new System.Drawing.Size(630, 381);
            this.panel_auth.TabIndex = 0;
            // 
            // label_auth_res
            // 
            this.label_auth_res.AutoSize = true;
            this.label_auth_res.Location = new System.Drawing.Point(209, 314);
            this.label_auth_res.Name = "label_auth_res";
            this.label_auth_res.Size = new System.Drawing.Size(35, 13);
            this.label_auth_res.TabIndex = 5;
            this.label_auth_res.Text = "label1";
            this.label_auth_res.Visible = false;
            // 
            // button_auth_check
            // 
            this.button_auth_check.Location = new System.Drawing.Point(209, 254);
            this.button_auth_check.Name = "button_auth_check";
            this.button_auth_check.Size = new System.Drawing.Size(75, 23);
            this.button_auth_check.TabIndex = 4;
            this.button_auth_check.Text = "Log in";
            this.button_auth_check.UseVisualStyleBackColor = true;
            this.button_auth_check.Click += new System.EventHandler(this.button_auth_check_Click);
            // 
            // textBox_auth_pass
            // 
            this.textBox_auth_pass.Location = new System.Drawing.Point(209, 193);
            this.textBox_auth_pass.Name = "textBox_auth_pass";
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
            this.label_auth_pass.Location = new System.Drawing.Point(97, 193);
            this.label_auth_pass.Name = "label_auth_pass";
            this.label_auth_pass.Size = new System.Drawing.Size(52, 13);
            this.label_auth_pass.TabIndex = 1;
            this.label_auth_pass.Text = "password";
            // 
            // label_auth_login
            // 
            this.label_auth_login.AutoSize = true;
            this.label_auth_login.Location = new System.Drawing.Point(97, 142);
            this.label_auth_login.Name = "label_auth_login";
            this.label_auth_login.Size = new System.Drawing.Size(29, 13);
            this.label_auth_login.TabIndex = 0;
            this.label_auth_login.Text = "login";
            // 
            // panel_browseEatery
            // 
            this.panel_browseEatery.Controls.Add(this.label_browse_welcome);
            this.panel_browseEatery.Controls.Add(this.dataGridView_Eatery);
            this.panel_browseEatery.Controls.Add(this.label_browse_username);
            this.panel_browseEatery.Location = new System.Drawing.Point(9, 9);
            this.panel_browseEatery.Name = "panel_browseEatery";
            this.panel_browseEatery.Size = new System.Drawing.Size(630, 381);
            this.panel_browseEatery.TabIndex = 6;
            // 
            // label_browse_welcome
            // 
            this.label_browse_welcome.AutoSize = true;
            this.label_browse_welcome.Location = new System.Drawing.Point(140, 48);
            this.label_browse_welcome.Name = "label_browse_welcome";
            this.label_browse_welcome.Size = new System.Drawing.Size(52, 13);
            this.label_browse_welcome.TabIndex = 5;
            this.label_browse_welcome.Text = "Welcome";
            // 
            // dataGridView_Eatery
            // 
            this.dataGridView_Eatery.AutoGenerateColumns = false;
            this.dataGridView_Eatery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Eatery.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eateryType,
            this.location,
            this.description,
            this.eateryNameDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.eateryTypeDataGridViewTextBoxColumn});
            this.dataGridView_Eatery.DataSource = this.eateryBindingSource;
            this.dataGridView_Eatery.Location = new System.Drawing.Point(28, 171);
            this.dataGridView_Eatery.Name = "dataGridView_Eatery";
            this.dataGridView_Eatery.Size = new System.Drawing.Size(445, 159);
            this.dataGridView_Eatery.TabIndex = 8;
            this.dataGridView_Eatery.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Eatery_CellDoubleClick);
            // 
            // eateryType
            // 
            this.eateryType.DataPropertyName = "eateryType";
            this.eateryType.HeaderText = "eateryType";
            this.eateryType.Name = "eateryType";
            this.eateryType.ReadOnly = true;
            // 
            // location
            // 
            this.location.DataPropertyName = "location";
            this.location.HeaderText = "location";
            this.location.Name = "location";
            this.location.ReadOnly = true;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "description";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // label_browse_username
            // 
            this.label_browse_username.AutoSize = true;
            this.label_browse_username.Location = new System.Drawing.Point(568, 32);
            this.label_browse_username.Name = "label_browse_username";
            this.label_browse_username.Size = new System.Drawing.Size(29, 13);
            this.label_browse_username.TabIndex = 0;
            this.label_browse_username.Text = "login";
            // 
            // panel_browseEateryMenu
            // 
            this.panel_browseEateryMenu.Controls.Add(this.dataGridView_Meals);
            this.panel_browseEateryMenu.Location = new System.Drawing.Point(645, 219);
            this.panel_browseEateryMenu.Name = "panel_browseEateryMenu";
            this.panel_browseEateryMenu.Size = new System.Drawing.Size(630, 381);
            this.panel_browseEateryMenu.TabIndex = 8;
            // 
            // dataGridView_Meals
            // 
            this.dataGridView_Meals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Meals.Location = new System.Drawing.Point(51, 122);
            this.dataGridView_Meals.Name = "dataGridView_Meals";
            this.dataGridView_Meals.Size = new System.Drawing.Size(445, 159);
            this.dataGridView_Meals.TabIndex = 9;
            // 
            // eateryNameDataGridViewTextBoxColumn
            // 
            this.eateryNameDataGridViewTextBoxColumn.DataPropertyName = "eateryName";
            this.eateryNameDataGridViewTextBoxColumn.HeaderText = "eateryName";
            this.eateryNameDataGridViewTextBoxColumn.Name = "eateryNameDataGridViewTextBoxColumn";
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // eateryTypeDataGridViewTextBoxColumn
            // 
            this.eateryTypeDataGridViewTextBoxColumn.DataPropertyName = "eateryType";
            this.eateryTypeDataGridViewTextBoxColumn.HeaderText = "eateryType";
            this.eateryTypeDataGridViewTextBoxColumn.Name = "eateryTypeDataGridViewTextBoxColumn";
            // 
            // eateryBindingSource
            // 
            this.eateryBindingSource.DataSource = typeof(DataStructures.Eatery);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 658);
            this.Controls.Add(this.panel_browseEateryMenu);
            this.Controls.Add(this.panel_browseEatery);
            this.Controls.Add(this.panel_auth);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel_auth.ResumeLayout(false);
            this.panel_auth.PerformLayout();
            this.panel_browseEatery.ResumeLayout(false);
            this.panel_browseEatery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Eatery)).EndInit();
            this.panel_browseEateryMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Meals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eateryBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource eateryBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn eateryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eateryType;
        private System.Windows.Forms.DataGridViewTextBoxColumn location;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.Panel panel_browseEateryMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn eateryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eateryTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView_Meals;
    }
}

