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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_auth_login = new System.Windows.Forms.Label();
            this.label_auth_pass = new System.Windows.Forms.Label();
            this.textBox_auth_login = new System.Windows.Forms.TextBox();
            this.textBox_auth_pass = new System.Windows.Forms.TextBox();
            this.button_auth_check = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_auth_check);
            this.panel1.Controls.Add(this.textBox_auth_pass);
            this.panel1.Controls.Add(this.textBox_auth_login);
            this.panel1.Controls.Add(this.label_auth_pass);
            this.panel1.Controls.Add(this.label_auth_login);
            this.panel1.Location = new System.Drawing.Point(185, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 381);
            this.panel1.TabIndex = 0;
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
            // label_auth_pass
            // 
            this.label_auth_pass.AutoSize = true;
            this.label_auth_pass.Location = new System.Drawing.Point(97, 193);
            this.label_auth_pass.Name = "label_auth_pass";
            this.label_auth_pass.Size = new System.Drawing.Size(52, 13);
            this.label_auth_pass.TabIndex = 1;
            this.label_auth_pass.Text = "password";
            // 
            // textBox_auth_login
            // 
            this.textBox_auth_login.Location = new System.Drawing.Point(209, 142);
            this.textBox_auth_login.Name = "textBox_auth_login";
            this.textBox_auth_login.Size = new System.Drawing.Size(100, 20);
            this.textBox_auth_login.TabIndex = 2;
            // 
            // textBox_auth_pass
            // 
            this.textBox_auth_pass.Location = new System.Drawing.Point(209, 193);
            this.textBox_auth_pass.Name = "textBox_auth_pass";
            this.textBox_auth_pass.Size = new System.Drawing.Size(100, 20);
            this.textBox_auth_pass.TabIndex = 3;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 658);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_auth_check;
        private System.Windows.Forms.TextBox textBox_auth_pass;
        private System.Windows.Forms.TextBox textBox_auth_login;
        private System.Windows.Forms.Label label_auth_pass;
        private System.Windows.Forms.Label label_auth_login;
    }
}

